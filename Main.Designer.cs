namespace RedisAdmin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.parentTable = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.leftPaneTable = new System.Windows.Forms.TableLayoutPanel();
            this.keyList = new RedisAdmin.TreeViewEx();
            this.keyTypeImageList = new System.Windows.Forms.ImageList(this.components);
            this.leftPaneTopButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnAddHash = new System.Windows.Forms.Button();
            this.btnAddSortedSet = new System.Windows.Forms.Button();
            this.btnAddSet = new System.Windows.Forms.Button();
            this.btnAddString = new System.Windows.Forms.Button();
            this.Tabs = new RedisAdmin.TabControlEx();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatabaseCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKeyCount = new System.Windows.Forms.Label();
            this.refreshStats = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPeakMemoryUsage = new System.Windows.Forms.Label();
            this.lblMemoryUsage = new System.Windows.Forms.Label();
            this.lblUptimeSeconds = new System.Windows.Forms.Label();
            this.lblRedisVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblServerRole = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblUptimeDays = new System.Windows.Forms.Label();
            this.flushAllKeys = new System.Windows.Forms.Button();
            this.stringValueTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStringKey = new System.Windows.Forms.Button();
            this.txtStringKeyValue = new System.Windows.Forms.TextBox();
            this.btnSetStringKeyValue = new System.Windows.Forms.Button();
            this.listValueTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteListKey = new System.Windows.Forms.Button();
            this.dgListKeyValue = new System.Windows.Forms.DataGridView();
            this.hashValueTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteHashKey = new System.Windows.Forms.Button();
            this.dgHashKeyValue = new System.Windows.Forms.DataGridView();
            this.parentTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.leftPaneTable.SuspendLayout();
            this.leftPaneTopButtonTable.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.statsTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.stringValueTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.listValueTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListKeyValue)).BeginInit();
            this.hashValueTab.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHashKeyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // parentTable
            // 
            this.parentTable.ColumnCount = 1;
            this.parentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parentTable.Controls.Add(this.splitContainer1, 0, 0);
            this.parentTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentTable.Location = new System.Drawing.Point(0, 0);
            this.parentTable.Margin = new System.Windows.Forms.Padding(4);
            this.parentTable.Name = "parentTable";
            this.parentTable.RowCount = 1;
            this.parentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parentTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 629F));
            this.parentTable.Size = new System.Drawing.Size(824, 629);
            this.parentTable.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.leftPaneTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Tabs);
            this.splitContainer1.Size = new System.Drawing.Size(816, 621);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // leftPaneTable
            // 
            this.leftPaneTable.ColumnCount = 1;
            this.leftPaneTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPaneTable.Controls.Add(this.keyList, 0, 1);
            this.leftPaneTable.Controls.Add(this.leftPaneTopButtonTable, 0, 0);
            this.leftPaneTable.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.leftPaneTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPaneTable.Location = new System.Drawing.Point(0, 0);
            this.leftPaneTable.Margin = new System.Windows.Forms.Padding(4);
            this.leftPaneTable.Name = "leftPaneTable";
            this.leftPaneTable.RowCount = 3;
            this.leftPaneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.leftPaneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPaneTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.leftPaneTable.Size = new System.Drawing.Size(206, 621);
            this.leftPaneTable.TabIndex = 0;
            // 
            // keyList
            // 
            this.keyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyList.HideSelection = false;
            this.keyList.ImageIndex = 0;
            this.keyList.ImageList = this.keyTypeImageList;
            this.keyList.Location = new System.Drawing.Point(4, 53);
            this.keyList.Margin = new System.Windows.Forms.Padding(4);
            this.keyList.Name = "keyList";
            this.keyList.SelectedImageIndex = 0;
            this.keyList.Size = new System.Drawing.Size(198, 515);
            this.keyList.TabIndex = 20;
            this.keyList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.keyList_AfterSelect);
            // 
            // keyTypeImageList
            // 
            this.keyTypeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("keyTypeImageList.ImageStream")));
            this.keyTypeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.keyTypeImageList.Images.SetKeyName(0, "database.png");
            this.keyTypeImageList.Images.SetKeyName(1, "text.png");
            this.keyTypeImageList.Images.SetKeyName(2, "list.png");
            this.keyTypeImageList.Images.SetKeyName(3, "set.png");
            this.keyTypeImageList.Images.SetKeyName(4, "sortedset.png");
            this.keyTypeImageList.Images.SetKeyName(5, "hash.png");
            this.keyTypeImageList.Images.SetKeyName(6, "item.png");
            // 
            // leftPaneTopButtonTable
            // 
            this.leftPaneTopButtonTable.ColumnCount = 4;
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftPaneTopButtonTable.Controls.Add(this.connectButton, 0, 0);
            this.leftPaneTopButtonTable.Controls.Add(this.disconnectButton, 1, 0);
            this.leftPaneTopButtonTable.Controls.Add(this.filterButton, 2, 0);
            this.leftPaneTopButtonTable.Controls.Add(this.refreshButton, 3, 0);
            this.leftPaneTopButtonTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPaneTopButtonTable.Location = new System.Drawing.Point(0, 0);
            this.leftPaneTopButtonTable.Margin = new System.Windows.Forms.Padding(0);
            this.leftPaneTopButtonTable.Name = "leftPaneTopButtonTable";
            this.leftPaneTopButtonTable.RowCount = 1;
            this.leftPaneTopButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPaneTopButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.leftPaneTopButtonTable.Size = new System.Drawing.Size(206, 49);
            this.leftPaneTopButtonTable.TabIndex = 22;
            // 
            // connectButton
            // 
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectButton.Image = ((System.Drawing.Image)(resources.GetObject("connectButton.Image")));
            this.connectButton.Location = new System.Drawing.Point(4, 4);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(43, 41);
            this.connectButton.TabIndex = 0;
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnectButton.Image = ((System.Drawing.Image)(resources.GetObject("disconnectButton.Image")));
            this.disconnectButton.Location = new System.Drawing.Point(55, 4);
            this.disconnectButton.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(43, 41);
            this.disconnectButton.TabIndex = 1;
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.Location = new System.Drawing.Point(106, 4);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(43, 41);
            this.filterButton.TabIndex = 2;
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(157, 4);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(45, 41);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnAddList, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddHash, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddSortedSet, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddSet, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddString, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 576);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(198, 41);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // btnAddList
            // 
            this.btnAddList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddList.Image")));
            this.btnAddList.Location = new System.Drawing.Point(43, 4);
            this.btnAddList.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(31, 33);
            this.btnAddList.TabIndex = 4;
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnAddHash
            // 
            this.btnAddHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddHash.Image = ((System.Drawing.Image)(resources.GetObject("btnAddHash.Image")));
            this.btnAddHash.Location = new System.Drawing.Point(160, 4);
            this.btnAddHash.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHash.Name = "btnAddHash";
            this.btnAddHash.Size = new System.Drawing.Size(34, 33);
            this.btnAddHash.TabIndex = 3;
            this.btnAddHash.UseVisualStyleBackColor = true;
            this.btnAddHash.Click += new System.EventHandler(this.btnAddHash_Click);
            // 
            // btnAddSortedSet
            // 
            this.btnAddSortedSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSortedSet.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSortedSet.Image")));
            this.btnAddSortedSet.Location = new System.Drawing.Point(121, 4);
            this.btnAddSortedSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSortedSet.Name = "btnAddSortedSet";
            this.btnAddSortedSet.Size = new System.Drawing.Size(31, 33);
            this.btnAddSortedSet.TabIndex = 2;
            this.btnAddSortedSet.UseVisualStyleBackColor = true;
            this.btnAddSortedSet.Click += new System.EventHandler(this.btnAddSortedSet_Click);
            // 
            // btnAddSet
            // 
            this.btnAddSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSet.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSet.Image")));
            this.btnAddSet.Location = new System.Drawing.Point(82, 4);
            this.btnAddSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSet.Name = "btnAddSet";
            this.btnAddSet.Size = new System.Drawing.Size(31, 33);
            this.btnAddSet.TabIndex = 1;
            this.btnAddSet.UseVisualStyleBackColor = true;
            this.btnAddSet.Click += new System.EventHandler(this.btnAddSet_Click);
            // 
            // btnAddString
            // 
            this.btnAddString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddString.Image = ((System.Drawing.Image)(resources.GetObject("btnAddString.Image")));
            this.btnAddString.Location = new System.Drawing.Point(4, 4);
            this.btnAddString.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddString.Name = "btnAddString";
            this.btnAddString.Size = new System.Drawing.Size(31, 33);
            this.btnAddString.TabIndex = 0;
            this.btnAddString.UseVisualStyleBackColor = true;
            this.btnAddString.Click += new System.EventHandler(this.btnAddString_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.statsTab);
            this.Tabs.Controls.Add(this.stringValueTab);
            this.Tabs.Controls.Add(this.listValueTab);
            this.Tabs.Controls.Add(this.hashValueTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(605, 621);
            this.Tabs.TabIndex = 0;
            // 
            // statsTab
            // 
            this.statsTab.Controls.Add(this.tableLayoutPanel2);
            this.statsTab.Location = new System.Drawing.Point(4, 33);
            this.statsTab.Margin = new System.Windows.Forms.Padding(4);
            this.statsTab.Name = "statsTab";
            this.statsTab.Padding = new System.Windows.Forms.Padding(4);
            this.statsTab.Size = new System.Drawing.Size(597, 584);
            this.statsTab.TabIndex = 0;
            this.statsTab.Text = "Stats";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDatabaseCount, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lblKeyCount, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.refreshStats, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblPeakMemoryUsage, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblMemoryUsage, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblUptimeSeconds, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblRedisVersion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblServerRole, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblHostName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPortNumber, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblUptimeDays, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.flushAllKeys, 0, 12);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 14;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(589, 576);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // lblDatabaseCount
            // 
            this.lblDatabaseCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatabaseCount.AutoSize = true;
            this.lblDatabaseCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseCount.Location = new System.Drawing.Point(297, 353);
            this.lblDatabaseCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabaseCount.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblDatabaseCount.Name = "lblDatabaseCount";
            this.lblDatabaseCount.Size = new System.Drawing.Size(160, 24);
            this.lblDatabaseCount.TabIndex = 13;
            this.lblDatabaseCount.Text = "0";
            this.lblDatabaseCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Database Count";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Key Count";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKeyCount
            // 
            this.lblKeyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeyCount.AutoSize = true;
            this.lblKeyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyCount.Location = new System.Drawing.Point(297, 396);
            this.lblKeyCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeyCount.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblKeyCount.Name = "lblKeyCount";
            this.lblKeyCount.Size = new System.Drawing.Size(160, 24);
            this.lblKeyCount.TabIndex = 15;
            this.lblKeyCount.Text = "0";
            this.lblKeyCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // refreshStats
            // 
            this.refreshStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.refreshStats, 2);
            this.refreshStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshStats.Location = new System.Drawing.Point(4, 459);
            this.refreshStats.Margin = new System.Windows.Forms.Padding(4);
            this.refreshStats.Name = "refreshStats";
            this.refreshStats.Size = new System.Drawing.Size(581, 41);
            this.refreshStats.TabIndex = 18;
            this.refreshStats.Text = "Refresh Stats";
            this.refreshStats.UseVisualStyleBackColor = true;
            this.refreshStats.Click += new System.EventHandler(this.refreshStats_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Port Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Memory Peak Use";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPeakMemoryUsage
            // 
            this.lblPeakMemoryUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeakMemoryUsage.AutoSize = true;
            this.lblPeakMemoryUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakMemoryUsage.Location = new System.Drawing.Point(297, 310);
            this.lblPeakMemoryUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeakMemoryUsage.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblPeakMemoryUsage.Name = "lblPeakMemoryUsage";
            this.lblPeakMemoryUsage.Size = new System.Drawing.Size(160, 24);
            this.lblPeakMemoryUsage.TabIndex = 10;
            this.lblPeakMemoryUsage.Text = "0";
            this.lblPeakMemoryUsage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblMemoryUsage
            // 
            this.lblMemoryUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemoryUsage.AutoSize = true;
            this.lblMemoryUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryUsage.Location = new System.Drawing.Point(297, 267);
            this.lblMemoryUsage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemoryUsage.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblMemoryUsage.Name = "lblMemoryUsage";
            this.lblMemoryUsage.Size = new System.Drawing.Size(160, 24);
            this.lblMemoryUsage.TabIndex = 9;
            this.lblMemoryUsage.Text = "0";
            this.lblMemoryUsage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUptimeSeconds
            // 
            this.lblUptimeSeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUptimeSeconds.AutoSize = true;
            this.lblUptimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptimeSeconds.Location = new System.Drawing.Point(297, 181);
            this.lblUptimeSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUptimeSeconds.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblUptimeSeconds.Name = "lblUptimeSeconds";
            this.lblUptimeSeconds.Size = new System.Drawing.Size(160, 24);
            this.lblUptimeSeconds.TabIndex = 8;
            this.lblUptimeSeconds.Text = "0";
            this.lblUptimeSeconds.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRedisVersion
            // 
            this.lblRedisVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRedisVersion.AutoSize = true;
            this.lblRedisVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedisVersion.Location = new System.Drawing.Point(297, 138);
            this.lblRedisVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedisVersion.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblRedisVersion.Name = "lblRedisVersion";
            this.lblRedisVersion.Size = new System.Drawing.Size(160, 24);
            this.lblRedisVersion.TabIndex = 7;
            this.lblRedisVersion.Text = "0";
            this.lblRedisVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Memory in Use";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uptime in Seconds";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redis Version";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Server Role";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblServerRole
            // 
            this.lblServerRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServerRole.AutoSize = true;
            this.lblServerRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerRole.Location = new System.Drawing.Point(297, 95);
            this.lblServerRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServerRole.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblServerRole.Name = "lblServerRole";
            this.lblServerRole.Size = new System.Drawing.Size(160, 24);
            this.lblServerRole.TabIndex = 11;
            this.lblServerRole.Text = "0";
            this.lblServerRole.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHostName
            // 
            this.lblHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHostName.AutoSize = true;
            this.lblHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Location = new System.Drawing.Point(297, 9);
            this.lblHostName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostName.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(160, 24);
            this.lblHostName.TabIndex = 21;
            this.lblHostName.Text = "0";
            this.lblHostName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNumber.Location = new System.Drawing.Point(297, 52);
            this.lblPortNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortNumber.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(160, 24);
            this.lblPortNumber.TabIndex = 22;
            this.lblPortNumber.Text = "0";
            this.lblPortNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Host Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(285, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Uptime in Days";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblUptimeDays
            // 
            this.lblUptimeDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUptimeDays.AutoSize = true;
            this.lblUptimeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUptimeDays.Location = new System.Drawing.Point(297, 224);
            this.lblUptimeDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUptimeDays.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblUptimeDays.Name = "lblUptimeDays";
            this.lblUptimeDays.Size = new System.Drawing.Size(160, 24);
            this.lblUptimeDays.TabIndex = 24;
            this.lblUptimeDays.Text = "0";
            this.lblUptimeDays.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flushAllKeys
            // 
            this.flushAllKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.flushAllKeys, 2);
            this.flushAllKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushAllKeys.Location = new System.Drawing.Point(4, 508);
            this.flushAllKeys.Margin = new System.Windows.Forms.Padding(4);
            this.flushAllKeys.Name = "flushAllKeys";
            this.flushAllKeys.Size = new System.Drawing.Size(581, 41);
            this.flushAllKeys.TabIndex = 25;
            this.flushAllKeys.Text = "Flush All Keys";
            this.flushAllKeys.UseVisualStyleBackColor = true;
            this.flushAllKeys.Click += new System.EventHandler(this.flushAllKeys_Click);
            // 
            // stringValueTab
            // 
            this.stringValueTab.Controls.Add(this.tableLayoutPanel1);
            this.stringValueTab.Location = new System.Drawing.Point(4, 33);
            this.stringValueTab.Margin = new System.Windows.Forms.Padding(4);
            this.stringValueTab.Name = "stringValueTab";
            this.stringValueTab.Padding = new System.Windows.Forms.Padding(4);
            this.stringValueTab.Size = new System.Drawing.Size(597, 584);
            this.stringValueTab.TabIndex = 1;
            this.stringValueTab.Text = "Value";
            this.stringValueTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteStringKey, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStringKeyValue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetStringKeyValue, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 576);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // btnDeleteStringKey
            // 
            this.btnDeleteStringKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStringKey.Location = new System.Drawing.Point(307, 531);
            this.btnDeleteStringKey.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnDeleteStringKey.Name = "btnDeleteStringKey";
            this.btnDeleteStringKey.Size = new System.Drawing.Size(269, 41);
            this.btnDeleteStringKey.TabIndex = 2;
            this.btnDeleteStringKey.Text = "Delete";
            this.btnDeleteStringKey.UseVisualStyleBackColor = true;
            this.btnDeleteStringKey.Click += new System.EventHandler(this.deleteKey_Click);
            // 
            // txtStringKeyValue
            // 
            this.txtStringKeyValue.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.txtStringKeyValue, 2);
            this.txtStringKeyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStringKeyValue.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringKeyValue.Location = new System.Drawing.Point(4, 4);
            this.txtStringKeyValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtStringKeyValue.Multiline = true;
            this.txtStringKeyValue.Name = "txtStringKeyValue";
            this.txtStringKeyValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStringKeyValue.Size = new System.Drawing.Size(581, 519);
            this.txtStringKeyValue.TabIndex = 0;
            // 
            // btnSetStringKeyValue
            // 
            this.btnSetStringKeyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetStringKeyValue.Location = new System.Drawing.Point(13, 531);
            this.btnSetStringKeyValue.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnSetStringKeyValue.Name = "btnSetStringKeyValue";
            this.btnSetStringKeyValue.Size = new System.Drawing.Size(268, 41);
            this.btnSetStringKeyValue.TabIndex = 1;
            this.btnSetStringKeyValue.Text = "Set";
            this.btnSetStringKeyValue.UseVisualStyleBackColor = true;
            this.btnSetStringKeyValue.Click += new System.EventHandler(this.btnSetStringKeyValue_Click);
            // 
            // listValueTab
            // 
            this.listValueTab.Controls.Add(this.tableLayoutPanel3);
            this.listValueTab.Location = new System.Drawing.Point(4, 33);
            this.listValueTab.Margin = new System.Windows.Forms.Padding(4);
            this.listValueTab.Name = "listValueTab";
            this.listValueTab.Size = new System.Drawing.Size(597, 584);
            this.listValueTab.TabIndex = 2;
            this.listValueTab.Text = "Value";
            this.listValueTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.deleteListKey, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgListKeyValue, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(597, 584);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // deleteListKey
            // 
            this.deleteListKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteListKey.Location = new System.Drawing.Point(13, 539);
            this.deleteListKey.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.deleteListKey.Name = "deleteListKey";
            this.deleteListKey.Size = new System.Drawing.Size(571, 41);
            this.deleteListKey.TabIndex = 0;
            this.deleteListKey.Text = "Delete Entire Key";
            this.deleteListKey.UseVisualStyleBackColor = true;
            this.deleteListKey.Click += new System.EventHandler(this.deleteKey_Click);
            // 
            // dgListKeyValue
            // 
            this.dgListKeyValue.AllowUserToOrderColumns = true;
            this.dgListKeyValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListKeyValue.ColumnHeadersVisible = false;
            this.dgListKeyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListKeyValue.EnableHeadersVisualStyles = false;
            this.dgListKeyValue.Location = new System.Drawing.Point(4, 4);
            this.dgListKeyValue.Margin = new System.Windows.Forms.Padding(4);
            this.dgListKeyValue.MultiSelect = false;
            this.dgListKeyValue.Name = "dgListKeyValue";
            this.dgListKeyValue.ShowCellErrors = false;
            this.dgListKeyValue.ShowCellToolTips = false;
            this.dgListKeyValue.ShowRowErrors = false;
            this.dgListKeyValue.Size = new System.Drawing.Size(589, 527);
            this.dgListKeyValue.TabIndex = 1;
            this.dgListKeyValue.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgListKeyValue_CellBeginEdit);
            this.dgListKeyValue.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListKeyValue_CellValueChanged);
            this.dgListKeyValue.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgListKeyValue_UserDeletingRow);
            // 
            // hashValueTab
            // 
            this.hashValueTab.Controls.Add(this.tableLayoutPanel5);
            this.hashValueTab.Location = new System.Drawing.Point(4, 33);
            this.hashValueTab.Margin = new System.Windows.Forms.Padding(4);
            this.hashValueTab.Name = "hashValueTab";
            this.hashValueTab.Size = new System.Drawing.Size(597, 584);
            this.hashValueTab.TabIndex = 3;
            this.hashValueTab.Text = "Value";
            this.hashValueTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.deleteHashKey, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.dgHashKeyValue, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(597, 584);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // deleteHashKey
            // 
            this.deleteHashKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteHashKey.Location = new System.Drawing.Point(13, 539);
            this.deleteHashKey.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.deleteHashKey.Name = "deleteHashKey";
            this.deleteHashKey.Size = new System.Drawing.Size(571, 41);
            this.deleteHashKey.TabIndex = 0;
            this.deleteHashKey.Text = "Delete Entire Key";
            this.deleteHashKey.UseVisualStyleBackColor = true;
            this.deleteHashKey.Click += new System.EventHandler(this.deleteKey_Click);
            // 
            // dgHashKeyValue
            // 
            this.dgHashKeyValue.AllowUserToOrderColumns = true;
            this.dgHashKeyValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHashKeyValue.ColumnHeadersVisible = false;
            this.dgHashKeyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHashKeyValue.EnableHeadersVisualStyles = false;
            this.dgHashKeyValue.Location = new System.Drawing.Point(4, 4);
            this.dgHashKeyValue.Margin = new System.Windows.Forms.Padding(4);
            this.dgHashKeyValue.MultiSelect = false;
            this.dgHashKeyValue.Name = "dgHashKeyValue";
            this.dgHashKeyValue.ShowCellErrors = false;
            this.dgHashKeyValue.ShowCellToolTips = false;
            this.dgHashKeyValue.ShowRowErrors = false;
            this.dgHashKeyValue.Size = new System.Drawing.Size(589, 527);
            this.dgHashKeyValue.TabIndex = 1;
            this.dgHashKeyValue.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgHashKeyValue_CellBeginEdit);
            this.dgHashKeyValue.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHashKeyValue_CellValueChanged);
            this.dgHashKeyValue.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgHashKeyValue_UserDeletingRow);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 629);
            this.Controls.Add(this.parentTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Redis Administrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.parentTable.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.leftPaneTable.ResumeLayout(false);
            this.leftPaneTopButtonTable.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.statsTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.stringValueTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.listValueTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListKeyValue)).EndInit();
            this.hashValueTab.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHashKeyValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel parentTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel leftPaneTable;
        private TreeViewEx keyList;
        private System.Windows.Forms.TableLayoutPanel leftPaneTopButtonTable;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ImageList keyTypeImageList;
        private TabControlEx Tabs;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDatabaseCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKeyCount;
        private System.Windows.Forms.Button refreshStats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPeakMemoryUsage;
        private System.Windows.Forms.Label lblMemoryUsage;
        private System.Windows.Forms.Label lblUptimeSeconds;
        private System.Windows.Forms.Label lblRedisVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblServerRole;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage stringValueTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtStringKeyValue;
        private System.Windows.Forms.Button btnSetStringKeyValue;
        private System.Windows.Forms.Button btnDeleteStringKey;
        private System.Windows.Forms.TabPage listValueTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button deleteListKey;
        private System.Windows.Forms.DataGridView dgListKeyValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnAddHash;
        private System.Windows.Forms.Button btnAddSortedSet;
        private System.Windows.Forms.Button btnAddSet;
        private System.Windows.Forms.Button btnAddString;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblUptimeDays;
        private System.Windows.Forms.TabPage hashValueTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button deleteHashKey;
        private System.Windows.Forms.DataGridView dgHashKeyValue;
        private System.Windows.Forms.Button flushAllKeys;
    }
}

