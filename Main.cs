using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

using ServiceStack.Redis;
using Newtonsoft.Json.Linq;

namespace RedisAdmin
{
    public partial class Main : Form
    {
        #region Properties
        private static readonly Regex dbRegex = new Regex( @"db(?<dbnum>\d+)", RegexOptions.IgnoreCase );
        private static readonly Regex keysRegex = new Regex( @"keys=(?<keynum>\d+)", RegexOptions.IgnoreCase );
        private const string AesKey = "Uk4T0f9mpc7XuAsHgrO223zgrwvR8taAyzFZWoXLyGg=";
        private const string AesIV = "mLGwr8pbunnyrt6vz0NcTg==";

        private RedisCredentials Credentials { get; set; }

        private List<RedisCredentials> RedisCredentials { get; set; }

        private IRedisClientsManager ClientManager { get; set; }

        private UrnFilterDialog UrnFilterDialog { get; set; }

        /// <summary>
        /// Holds the original value of a DataGridView 
        /// cell before it was edited.
        /// </summary>
        private string OriginalValue { get; set; }

        /// <summary>
        /// Because loading the URN list will re-select
        /// the current node, this will prevent the value
        /// from being reloaded.
        /// </summary>
        private bool IgnoreEvents { get; set; }
        #endregion

        public Main()
        {
            InitializeComponent();

            this.UrnFilterDialog = new UrnFilterDialog
            {
                StartPosition = FormStartPosition.CenterParent
            };

            this.LoadSettings();
            this.Tabs.HideTab( this.stringValueTab );
            this.Tabs.HideTab( this.listValueTab );
            this.Tabs.HideTab( this.hashValueTab );
        }

        private void SaveSettings()
        {
            var settings = new Settings
            {
                X = this.Location.X,
                Y = this.Location.Y,
                Width = this.Size.Width,
                Height = this.Size.Height,
                SplitterDistance = this.splitContainer1.SplitterDistance,

                SaveHostPort = true,
                SavePasswords = true,
            };

            // If the user has elected to save their credentials
            if( settings.SaveHostPort && this.RedisCredentials != null )
            {
                // If the user has elected to save their passwords
                if( settings.SavePasswords )
                {
                    // Convert the actual password to a AES encrypted version to save in the file
                    foreach( var c in this.RedisCredentials )
                    {
                        c.EncryptedPassword = Convert.ToBase64String( encrypt( c.Password, Convert.FromBase64String( AesKey ), Convert.FromBase64String( AesIV ) ) );
                    }
                }

                // Include the credentials in the xml file
                settings.RedisCredentials = this.RedisCredentials;
            }

            // Write the settings to file
            using( var w = new StreamWriter( "Settings.xml" ) )
            {
                var x = new XmlSerializer( typeof( Settings ) );
                x.Serialize( w, settings );
            }
        }

        private void LoadSettings()
        {
            try
            {
                if( !File.Exists( "Settings.xml" ) ) return;
                using( var r = new StreamReader( "Settings.xml" ) )
                {
                    var x = new XmlSerializer( typeof( Settings ) );
                    var settings = x.Deserialize( r ) as Settings;
                    if( settings == null ) return;

                    this.splitContainer1.SplitterDistance = settings.SplitterDistance;
                    this.SetBounds( settings.X, settings.Y, settings.Width, settings.Height );
                    this.Location = new System.Drawing.Point( settings.X, settings.Y );
                    this.Size = new System.Drawing.Size( settings.Width, settings.Height );
                    this.RedisCredentials = settings.RedisCredentials;
                }

                if( this.RedisCredentials == null ) return;

                foreach( var c in this.RedisCredentials.Where( m => !string.IsNullOrEmpty( m.EncryptedPassword ) ) )
                {
                    c.Password = decrypt( Convert.FromBase64String( c.EncryptedPassword ), Convert.FromBase64String( AesKey ), Convert.FromBase64String( AesIV ) );
                }
            }
            catch { }
        }

        private void Connect()
        {
            new ConnectDialog( this, this.RedisCredentials ) { StartPosition = FormStartPosition.CenterParent }.ShowDialog();
        }

        private void Disconnect()
        {
            this.ClientManager = null;
            this.Credentials = null;
            this.keyList.Nodes.Clear();
        }

        public void Authorize( RedisCredentials c )
        {
            if( this.RedisCredentials == null )
            {
                this.RedisCredentials = new List<RedisCredentials>();
            }

            if( string.IsNullOrEmpty( c.Name ) )
            {
                c.Name = c.Host + ":" + c.Port;
            }

            var existing = this.RedisCredentials.FirstOrDefault( m => m.Host.Equals( c.Host, StringComparison.OrdinalIgnoreCase ) && m.Port == c.Port );
            if( existing != null )
            {
                existing.Name = c.Name;
                existing.Password = c.Password;
            }
            else
            {
                this.RedisCredentials.Add( c );
            }

            try
            {
                this.ClientManager = new PooledRedisClientManager( CreateRedisUrl( c.Host, c.Port, c.Password ) );
                this.Credentials = c;
                this.LoadUrnList();
            }
            catch( Exception ex )
            {
                MessageBox.Show( ex.Message, @"Could not connect to redis", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        public void LoadUrnList()
        {
            var selected = this.keyList.SelectedNode;
            var SelectUrn = selected != null ? selected.Name : null;

            using( var client = this.ClientManager.GetClient() )
            {
                this.keyList.Nodes.Clear();

                foreach( var d in client.Info.Where( m => dbRegex.IsMatch( m.Key ) ) )
                {
                    var n = int.Parse( dbRegex.Match( d.Key ).Groups["dbnum"].Value );
                    var c = int.Parse( keysRegex.Match( d.Value ).Groups["keynum"].Value );
                    var db = new TreeNodeEx( d.Key + " (" + c + ")", 0, 0 );
                    client.Db = n;

                    foreach( var k in client.GetAllKeys() )
                    {
                        switch( client.GetEntryType( k ) )
                        {
                            case RedisKeyType.String:
                                db.Nodes.Add( new TreeNodeEx( k, 1, 1 )
                                {
                                    Name = k
                                } );
                                break;

                            case RedisKeyType.List:
                                var listCount = client.GetListCount( k );
                                db.Nodes.Add( new TreeNodeEx( k + " (" + listCount.ToString( "N0" ) + ")", 2, 2 )
                                {
                                    Name = k
                                } );
                                break;

                            case RedisKeyType.Set:
                                var setCount = client.GetSetCount( k );
                                db.Nodes.Add( new TreeNodeEx( k + " (" + setCount.ToString( "N0" ) + ")", 3, 3 )
                                {
                                    Name = k
                                } );
                                break;

                            case RedisKeyType.SortedSet:
                                var sortedSetCount = client.GetSortedSetCount( k );
                                db.Nodes.Add( new TreeNodeEx( k + " (" + sortedSetCount.ToString( "N0" ) + ")", 4, 4 )
                                {
                                    Name = k
                                } );
                                break;

                            case RedisKeyType.Hash:
                                var key = new TreeNodeEx( k, 5, 5 )
                                {
                                    Name = k
                                };
                                foreach( var h in client.GetHashKeys( k ) )
                                {
                                    key.Nodes.Add( new TreeNodeEx( h, 6, 6 ) );
                                }
                                db.Nodes.Add( key );
                                break;
                        }
                    }

                    this.keyList.Nodes.Add( db );
                }

                if( this.keyList.Nodes.Count == 1 )
                {
                    this.keyList.Nodes[0].Expand();
                }
                this.keyList.Sort();

                if( !string.IsNullOrEmpty( SelectUrn ) )
                {
                    var node =
                    (
                        from db in this.keyList.Nodes.Cast<TreeNode>()
                        from n in db.Nodes.Cast<TreeNode>()
                        where n.Name.Equals( SelectUrn )
                        select n
                    )
                    .FirstOrDefault();

                    if( node != null )
                    {
                        this.IgnoreEvents = true;
                        this.keyList.SelectedNode = node;
                        node.Expand();
                        this.IgnoreEvents = false;
                    }
                }

                this.LoadStats( client.Info );
            }

            FilterUrnList();
        }

        public void FilterUrnList()
        {
            var filter = this.UrnFilterDialog.Filter.ToLower();
            foreach( var db in keyList.Nodes.Cast<TreeNodeEx>() )
            {
                db.ShowAll();
                if( string.IsNullOrEmpty( filter ) ) continue;

                foreach( var Node in db.Nodes.Cast<TreeNodeEx>().ToList() )
                {
                    if( !Node.Name.ToLower().Contains( filter ) )
                    {
                        db.HideNode( Node );
                    }
                }
            }
        }

        public void LoadStats( Dictionary<string,string> Stats = null )
        {
            if( Stats == null )
            {
                using( var client = this.ClientManager.GetClient() )
                {
                    Stats = client.Info;
                }
            }

            this.lblHostName.Text = this.Credentials.Host;
            this.lblPortNumber.Text = this.Credentials.Port.ToString( "D" );
            this.lblRedisVersion.Text = Stats["redis_version"];
            this.lblUptimeSeconds.Text = long.Parse( Stats["uptime_in_seconds"] ).ToString( "N0" );
            this.lblUptimeDays.Text = long.Parse( Stats["uptime_in_days"] ).ToString( "N0" );
            this.lblMemoryUsage.Text = Stats["used_memory_human"];
            this.lblPeakMemoryUsage.Text = Stats["used_memory_peak_human"];
            this.lblServerRole.Text = Stats["role"];

            int dbs = 0, keys = 0;
            foreach( var d in Stats.Where( m => dbRegex.IsMatch( m.Key ) ) )
            {
                dbs++;
                var match = keysRegex.Match( Stats[d.Key] );
                if( !match.Success ) continue;
                keys += int.Parse( match.Groups["keynum"].Value );
            }

            this.lblDatabaseCount.Text = dbs.ToString( "N0" );
            this.lblKeyCount.Text = keys.ToString( "N0" );
        }

        public void LoadUrnValue( string Urn )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                switch( client.GetEntryType( Urn ) )
                {
                    case RedisKeyType.String:
                        var value = client.GetValue( Urn );
                        if( !string.IsNullOrEmpty( value ) && ( value[0] == '[' || value[0] == '{' ) )
                        {
                            value = JToken.Parse( value ).ToString();
                        }
                        this.txtStringKeyValue.Text = value;
                        this.Tabs.ShowTab( this.stringValueTab );
                        this.Tabs.HideTab( this.listValueTab );
                        this.Tabs.HideTab( this.hashValueTab );
                        this.Tabs.SelectedTab = this.stringValueTab;
                        break;

                    case RedisKeyType.List:
                        var listData = new DataTable( "List Results" );
                        listData.Columns.Add( new DataColumn() );       // The only column
                        foreach( var i in client.GetAllItemsFromList( Urn ) )
                        {
                            var row = listData.NewRow();
                            row[0] = i;
                            listData.Rows.Add( row );
                        }
                        this.dgListKeyValue.DataSource = listData;
                        this.Tabs.ShowTab( this.listValueTab );
                        this.Tabs.HideTab( this.stringValueTab );
                        this.Tabs.HideTab( this.hashValueTab );
                        this.Tabs.SelectedTab = this.listValueTab;
                        break;

                    case RedisKeyType.Set:
                        var setData = new DataTable( "Set Results" );
                        setData.Columns.Add( new DataColumn() );       // The only column
                        foreach( var i in client.GetAllItemsFromSet( Urn ) )
                        {
                            var row = setData.NewRow();
                            row[0] = i;
                            setData.Rows.Add( row );
                        }
                        this.dgListKeyValue.DataSource = setData;
                        this.Tabs.ShowTab( this.listValueTab );
                        this.Tabs.HideTab( this.stringValueTab );
                        this.Tabs.HideTab( this.hashValueTab );
                        this.Tabs.SelectedTab = this.listValueTab;
                        break;

                    case RedisKeyType.SortedSet:
                        var sortData = new DataTable( "Sort Results" );
                        sortData.Columns.Add( new DataColumn() );       // The only column
                        foreach( var i in client.GetAllItemsFromSortedSet( Urn ) )
                        {
                            var row = sortData.NewRow();
                            row[0] = i;
                            sortData.Rows.Add( row );
                        }
                        this.dgListKeyValue.DataSource = sortData;
                        this.Tabs.ShowTab( this.listValueTab );
                        this.Tabs.HideTab( this.stringValueTab );
                        this.Tabs.HideTab( this.hashValueTab );
                        this.Tabs.SelectedTab = this.listValueTab;
                        break;

                    case RedisKeyType.Hash:
                        var hashData = new DataTable( "Hash Results" );
                        hashData.Columns.Add( new DataColumn() );
                        hashData.Columns.Add( new DataColumn() );
                        foreach( var key in client.GetHashKeys( Urn ) )
                        {
                            var row = hashData.NewRow();
                            row[0] = key;
                            row[1] = client.GetValueFromHash( Urn, key );
                            hashData.Rows.Add( row );
                        }
                        this.dgHashKeyValue.DataSource = hashData;
                        this.Tabs.ShowTab( this.hashValueTab );
                        this.Tabs.HideTab( this.stringValueTab );
                        this.Tabs.HideTab( this.listValueTab );
                        this.Tabs.SelectedTab = this.hashValueTab;
                        break;
                }
            }
        }

        public void CreateStringValue( string Urn, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.SetEntry( Urn, Value );
            }
            this.LoadUrnList();
            this.LoadUrnValue( Urn );
        }

        public void SetStringValue( string Urn, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.SetEntry( Urn, Value );
                this.LoadUrnValue( Urn );
            }
        }

        public void CreateListValue( string Urn, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.AddItemToList( Urn, Value );
            }
            this.LoadUrnList();
            this.LoadUrnValue( Urn );
        }

        public void CreateSetValue( string Urn, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.AddItemToSet( Urn, Value );
            }
            this.LoadUrnList();
            this.LoadUrnValue( Urn );
        }

        public void CreateSortedSetValue( string Urn, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.AddItemToSortedSet( Urn, Value );
            }
            this.LoadUrnList();
            this.LoadUrnValue( Urn );
        }

        public void SetListValue( string Urn, int Index, string Original, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                switch( client.GetEntryType( Urn ) )
                {
                    case RedisKeyType.List:
                        if( Index >= client.GetListCount( Urn ) )
                            client.AddItemToList( Urn, Value );
                        else
                            client.SetItemInList( Urn, Index, Value );
                        break;

                    case RedisKeyType.Set:
                        client.RemoveItemFromSet( Urn, Original );
                        client.AddItemToSet( Urn, Value );
                        break;

                    case RedisKeyType.SortedSet:
                        client.RemoveItemFromSortedSet( Urn, Original );
                        client.AddItemToSortedSet( Urn, Value );
                        break;
                }

                this.LoadUrnValue( Urn );
            }
        }

        public void DeleteListKeyValue( string Urn, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                switch( client.GetEntryType( Urn ) )
                {
                    case RedisKeyType.List:
                        client.RemoveItemFromList( Urn, Value );
                        break;

                    case RedisKeyType.Set:
                        client.RemoveItemFromSet( Urn, Value );
                        break;

                    case RedisKeyType.SortedSet:
                        client.RemoveItemFromSortedSet( Urn, Value );
                        break;
                }

                this.LoadUrnValue( Urn );
            }
        }

        public void CreateHashKeyValue( string Urn, string Key, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.SetEntryInHash( Urn, Key, Value );
            }
            this.LoadUrnList();
        }

        public void SetHashKeyValue( string Urn, string Key, string Value )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.SetEntryInHash( Urn, Key, Value );
            }
        }

        public void DeleteHashKeyValue( string Urn, string Key )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.RemoveEntryFromHash( Urn, Key );
            }
            this.LoadUrnList();
        }

        public void DeleteKey( string Urn )
        {
            using( var client = this.ClientManager.GetClient() )
            {
                client.Remove( Urn );
            }

            this.LoadUrnList();
        }

        #region Helpers
        #region Hashing and Encryption
        private static string HashSha2( string str )
        {
            using( var sha2Hash = new SHA512Managed() )
            {
                return Convert.ToBase64String( sha2Hash.ComputeHash( System.Text.Encoding.UTF8.GetBytes( str ) ) );
            }
        }

        public static byte[] encrypt( string plainText, byte[] key, byte[] iv )
        {
            return encrypt( System.Text.Encoding.UTF8.GetBytes( plainText ), key, iv );
        }

        public static byte[] encrypt( byte[] plainText, byte[] key, byte[] iv )
        {
            // http://msdn.microsoft.com/en-us/library/system.security.cryptography.rijndaelmanaged.aspx

            // Check arguments.
            if( plainText == null || plainText.Length <= 0 ) throw new ArgumentNullException( "plainText" );
            if( key == null || key.Length <= 0 ) throw new ArgumentNullException( "key" );
            if( iv == null || iv.Length <= 0 ) throw new ArgumentNullException( "iv" );

            // Create an RijndaelManaged object
            // with the specified key and IV.
            using( var aesAlg = new AesManaged() )
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                try
                {
                    using( var stream = new MemoryStream() )
                    using( var encryptor = aesAlg.CreateEncryptor( aesAlg.Key, aesAlg.IV ) )
                    using( var encrypt = new CryptoStream( stream, encryptor, CryptoStreamMode.Write ) )
                    {
                        encrypt.Write( plainText, 0, plainText.Length );
                        encrypt.FlushFinalBlock();
                        return stream.ToArray();
                    }
                }
                catch
                {
                }
            }

            // Return the encrypted bytes from the memory stream.
            return null;
        }

        public static string decrypt( byte[] cipherText, byte[] key, byte[] iv )
        {
            // http://msdn.microsoft.com/en-us/library/system.security.cryptography.rijndaelmanaged.aspx
            // http://stackoverflow.com/questions/4501289/c-sharp-byte-encryption

            // Check arguments.
            if( cipherText == null || cipherText.Length <= 0 ) throw new ArgumentNullException( "cipherText" );
            if( key == null || key.Length <= 0 ) throw new ArgumentNullException( "key" );
            if( iv == null || iv.Length <= 0 ) throw new ArgumentNullException( "iv" );

            byte[] plaintext = null;

            using( var aesAlg = new AesManaged() )
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                try
                {
                    using( var stream = new MemoryStream() )
                    using( var decryptor = aesAlg.CreateDecryptor( aesAlg.Key, aesAlg.IV ) )
                    using( var encrypt = new CryptoStream( stream, decryptor, CryptoStreamMode.Write ) )
                    {
                        encrypt.Write( cipherText, 0, cipherText.Length );
                        encrypt.FlushFinalBlock();
                        plaintext = stream.ToArray();
                    }
                }
                catch
                {
                }
            }

            return System.Text.Encoding.UTF8.GetString( plaintext );
        }

        public static byte[] GetRandomAesKey()
        {
            using( var r = new System.Security.Cryptography.RijndaelManaged() )
            {
                r.GenerateKey();
                return r.Key;
            }
        }

        public static byte[] GetRandomAesIV()
        {
            using( var r = new System.Security.Cryptography.RijndaelManaged() )
            {
                r.GenerateIV();
                return r.IV;
            }
        }
        #endregion

        private static string CreateRedisUrl( string Host = "localhost", int Port = 6379, string Password = null )
        {
            // password@host:port
            return ( !string.IsNullOrEmpty( Password ) ? Password + "@" : string.Empty ) + Host + ":" + Port;
        }

        private string GetSelectedUrn()
        {
            var node = this.keyList.SelectedNode;
            return node != null && node.Level == 1 ? node.Name : null;
        }
        #endregion

        #region Event Handlers
        private void connectButton_Click( object sender, EventArgs e )
        {
            this.Connect();
        }

        private void refreshButton_Click( object sender, EventArgs e )
        {
            this.LoadUrnList();
        }

        private void refreshStats_Click( object sender, EventArgs e )
        {
            this.LoadStats();
        }

        private void keyList_AfterSelect( object sender, TreeViewEventArgs e )
        {
            if( this.IgnoreEvents ) return;
            var key = this.GetSelectedUrn();
            if( key == null ) return;
            this.LoadUrnValue( key );
        }

        private void deleteKey_Click( object sender, EventArgs e )
        {
            var key = this.GetSelectedUrn();
            if( key == null ) return;
            this.DeleteKey( key );
        }

        private void btnSetStringKeyValue_Click( object sender, EventArgs e )
        {
            var key = this.GetSelectedUrn();
            if( key == null ) return;
            this.SetStringValue( key, this.txtStringKeyValue.Text );
        }

        private void dgListKeyValue_CellBeginEdit( object sender, DataGridViewCellCancelEventArgs e )
        {
            this.OriginalValue = this.dgListKeyValue[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void dgListKeyValue_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
            var key = this.GetSelectedUrn();
            if( key == null ) return;
            var value = this.dgListKeyValue.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            this.SetListValue( key, e.RowIndex, this.OriginalValue, value );
        }

        private void dgListKeyValue_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
        {
            var key = this.GetSelectedUrn();
            if( key == null ) return;
            this.DeleteListKeyValue( key, e.Row.Cells[0].Value.ToString() );
            e.Cancel = true;
        }

        private void Main_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.SaveSettings();
        }

        private void btnAddString_Click( object sender, EventArgs e )
        {
            var d = new KeyNameDialog{ StartPosition = FormStartPosition.CenterParent };
            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.CreateStringValue( d.KeyName, "empty string" );
        }

        private void btnAddList_Click( object sender, EventArgs e )
        {
            var d = new KeyNameDialog { StartPosition = FormStartPosition.CenterParent };
            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.CreateListValue( d.KeyName, "list item" );
        }

        private void btnAddSet_Click( object sender, EventArgs e )
        {
            var d = new KeyNameDialog { StartPosition = FormStartPosition.CenterParent };
            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.CreateSetValue( d.KeyName, "set item" );
        }

        private void btnAddSortedSet_Click( object sender, EventArgs e )
        {
            var d = new KeyNameDialog { StartPosition = FormStartPosition.CenterParent };
            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.CreateSortedSetValue( d.KeyName, "set item" );
        }

        private void btnAddHash_Click( object sender, EventArgs e )
        {
            var d = new KeyNameDialog { StartPosition = FormStartPosition.CenterParent };
            if( d.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;
            this.CreateHashKeyValue( d.KeyName, "key", "value" );
        }

        private void dgHashKeyValue_CellBeginEdit( object sender, DataGridViewCellCancelEventArgs e )
        {
            this.OriginalValue = this.dgHashKeyValue[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void dgHashKeyValue_CellValueChanged( object sender, DataGridViewCellEventArgs e )
        {
            var urn = this.GetSelectedUrn();
            if( urn == null ) return;

            var c0Value = this.dgHashKeyValue[0, e.RowIndex].Value.ToString();
            var c1Value = this.dgHashKeyValue[1, e.RowIndex].Value.ToString();
            if( string.IsNullOrEmpty( c0Value ) || string.IsNullOrEmpty( c1Value ) ) return;

            var row = ( (DataRowView)this.dgHashKeyValue.Rows[e.RowIndex].DataBoundItem ).Row;
            if( row.RowState == DataRowState.Detached )
            {
                // New row, create the key/value
                this.CreateHashKeyValue( urn, c0Value, c1Value );
            }
            else
            {
                if( e.ColumnIndex == 0 )
                {
                    // The key has changed
                    this.DeleteHashKeyValue( urn, this.OriginalValue );
                }
                this.SetHashKeyValue( urn, c0Value, c1Value );
            }
        }

        private void dgHashKeyValue_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
        {
            var urn = this.GetSelectedUrn();
            if( urn == null ) return;

            var c0Value = e.Row.Cells[0].Value.ToString();
            if( string.IsNullOrEmpty( c0Value ) ) return;

            this.DeleteHashKeyValue( urn, c0Value );
        }

        private void filterButton_Click( object sender, EventArgs e )
        {
            if( this.UrnFilterDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK ) return;

            this.LoadUrnList();
        }

        private void disconnectButton_Click( object sender, EventArgs e )
        {
            this.Disconnect();
        }
        #endregion
    }
}
