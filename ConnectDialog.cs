using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RedisAdmin
{
    public partial class ConnectDialog : Form
    {
        private Main Main { get; set; }
        private List<RedisCredentials> Credentials { get; set; }

        public ConnectDialog( Main Main, List<RedisCredentials> Credentials )
        {
            this.Main = Main;
            this.Credentials = Credentials;
            
            InitializeComponent();

            if( this.Credentials == null ) return;

            this.nickname.Items.Clear();
            this.host.Text = string.Empty;
            this.port.Text = string.Empty;
            foreach( var c in this.Credentials )
            {
                this.nickname.Items.Add( c.Name );
            }
        }

        private void button1_Click( object sender, EventArgs e )
        {
            this.button1.Text = @"Please wait...";
            this.button1.Enabled = false;
            this.Main.Authorize( new RedisCredentials
            {
                Name = this.nickname.Text,
                Host = this.host.Text,
                Port = int.Parse( this.port.Text ),
                Password = this.password.Text
            } );
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void nickname_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( this.Credentials == null ) return;
            var c = this.Credentials.FirstOrDefault( m => m.Name.Equals( this.nickname.Text, StringComparison.OrdinalIgnoreCase ) );
            if( c == null ) return;

            this.host.Text = c.Host;
            this.port.Text = c.Port.ToString();
            this.password.Text = c.Password;
        }
    }
}
