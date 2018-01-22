namespace SQL_O_Nator {
    partial class main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb1 = new System.Windows.Forms.ToolStripProgressBar();
            this.query_window = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.source_split = new System.Windows.Forms.SplitContainer();
            this.sources = new System.Windows.Forms.CheckedListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Toggle = new System.Windows.Forms.ToolStripButton();
            this.add_host = new System.Windows.Forms.ToolStripButton();
            this.edit_host = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.query_results = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_group = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.add_host_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.open_group_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.save_group = new System.Windows.Forms.ToolStripMenuItem();
            this.save_group_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.close_group = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLQuerysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_query = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.open_query = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.save_query = new System.Windows.Forms.ToolStripMenuItem();
            this.save_query_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.close_query = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.run_query_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.open_query_2 = new System.Windows.Forms.ToolStripButton();
            this.run_query = new System.Windows.Forms.ToolStripButton();
            this.delete_host = new System.Windows.Forms.ToolStripButton();
            this.host_config = new SQL_O_Nator.controls.new_host();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query_window)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source_split)).BeginInit();
            this.source_split.Panel1.SuspendLayout();
            this.source_split.Panel2.SuspendLayout();
            this.source_split.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 867);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1580, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb1
            // 
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 16);
            // 
            // query_window
            // 
            this.query_window.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.query_window.AutoIndentCharsPatterns = "";
            this.query_window.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.query_window.BackBrush = null;
            this.query_window.CharHeight = 14;
            this.query_window.CharWidth = 8;
            this.query_window.CommentPrefix = "--";
            this.query_window.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.query_window.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.query_window.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_window.IsReplaceMode = false;
            this.query_window.Language = FastColoredTextBoxNS.Language.SQL;
            this.query_window.LeftBracket = '(';
            this.query_window.Location = new System.Drawing.Point(0, 0);
            this.query_window.Name = "query_window";
            this.query_window.Paddings = new System.Windows.Forms.Padding(0);
            this.query_window.RightBracket = ')';
            this.query_window.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.query_window.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("query_window.ServiceColors")));
            this.query_window.Size = new System.Drawing.Size(1236, 385);
            this.query_window.TabIndex = 1;
            this.query_window.Zoom = 100;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1580, 773);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 66);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1580, 798);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.source_split);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1580, 773);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 2;
            // 
            // source_split
            // 
            this.source_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.source_split.Location = new System.Drawing.Point(0, 0);
            this.source_split.Name = "source_split";
            this.source_split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // source_split.Panel1
            // 
            this.source_split.Panel1.Controls.Add(this.sources);
            this.source_split.Panel1.Controls.Add(this.toolStrip1);
            this.source_split.Panel1MinSize = 100;
            // 
            // source_split.Panel2
            // 
            this.source_split.Panel2.Controls.Add(this.host_config);
            this.source_split.Panel2MinSize = 50;
            this.source_split.Size = new System.Drawing.Size(329, 773);
            this.source_split.SplitterDistance = 488;
            this.source_split.TabIndex = 3;
            // 
            // sources
            // 
            this.sources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sources.FormattingEnabled = true;
            this.sources.Location = new System.Drawing.Point(0, 46);
            this.sources.Name = "sources";
            this.sources.Size = new System.Drawing.Size(329, 439);
            this.sources.TabIndex = 0;
            this.sources.SelectedIndexChanged += new System.EventHandler(this.sources_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Toggle,
            this.delete_host,
            this.add_host,
            this.edit_host});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(329, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Toggle
            // 
            this.Toggle.Image = ((System.Drawing.Image)(resources.GetObject("Toggle.Image")));
            this.Toggle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Toggle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(126, 36);
            this.Toggle.Text = "Toggle Selected";
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // add_host
            // 
            this.add_host.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.add_host.Image = ((System.Drawing.Image)(resources.GetObject("add_host.Image")));
            this.add_host.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.add_host.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_host.Name = "add_host";
            this.add_host.Size = new System.Drawing.Size(36, 36);
            this.add_host.Text = "Add Host";
            this.add_host.Click += new System.EventHandler(this.add_host_Click_1);
            // 
            // edit_host
            // 
            this.edit_host.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.edit_host.Image = ((System.Drawing.Image)(resources.GetObject("edit_host.Image")));
            this.edit_host.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.edit_host.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edit_host.Name = "edit_host";
            this.edit_host.Size = new System.Drawing.Size(36, 36);
            this.edit_host.Text = "Edit Host";
            this.edit_host.Click += new System.EventHandler(this.edit_host_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.query_window);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1236, 773);
            this.splitContainer2.SplitterDistance = 385;
            this.splitContainer2.SplitterWidth = 15;
            this.splitContainer2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.query_results);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1228, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // query_results
            // 
            this.query_results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_results.Location = new System.Drawing.Point(3, 3);
            this.query_results.Multiline = true;
            this.query_results.Name = "query_results";
            this.query_results.Size = new System.Drawing.Size(1222, 341);
            this.query_results.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sQLQuerysToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1580, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_group,
            this.toolStripSeparator6,
            this.add_host_1,
            this.toolStripSeparator1,
            this.open_group_1,
            this.toolStripSeparator7,
            this.save_group,
            this.save_group_as,
            this.toolStripSeparator2,
            this.close_group});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.fileToolStripMenuItem.Text = "SQL Groups";
            // 
            // new_group
            // 
            this.new_group.Name = "new_group";
            this.new_group.Size = new System.Drawing.Size(124, 22);
            this.new_group.Text = "New";
            this.new_group.Click += new System.EventHandler(this.new_group_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(121, 6);
            // 
            // add_host_1
            // 
            this.add_host_1.Name = "add_host_1";
            this.add_host_1.Size = new System.Drawing.Size(124, 22);
            this.add_host_1.Text = "Add Host";
            this.add_host_1.Click += new System.EventHandler(this.add_host_1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // open_group_1
            // 
            this.open_group_1.Name = "open_group_1";
            this.open_group_1.Size = new System.Drawing.Size(124, 22);
            this.open_group_1.Text = "Open";
            this.open_group_1.Click += new System.EventHandler(this.open_group_1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(121, 6);
            // 
            // save_group
            // 
            this.save_group.Name = "save_group";
            this.save_group.Size = new System.Drawing.Size(124, 22);
            this.save_group.Text = "Save";
            this.save_group.Click += new System.EventHandler(this.save_group_Click);
            // 
            // save_group_as
            // 
            this.save_group_as.Name = "save_group_as";
            this.save_group_as.Size = new System.Drawing.Size(124, 22);
            this.save_group_as.Text = "Save As";
            this.save_group_as.Click += new System.EventHandler(this.save_group_as_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // close_group
            // 
            this.close_group.Name = "close_group";
            this.close_group.Size = new System.Drawing.Size(124, 22);
            this.close_group.Text = "Close";
            this.close_group.Click += new System.EventHandler(this.close_group_Click);
            // 
            // sQLQuerysToolStripMenuItem
            // 
            this.sQLQuerysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_query,
            this.toolStripSeparator4,
            this.open_query,
            this.toolStripSeparator3,
            this.save_query,
            this.save_query_as,
            this.toolStripSeparator5,
            this.close_query,
            this.toolStripSeparator8,
            this.run_query_1});
            this.sQLQuerysToolStripMenuItem.Name = "sQLQuerysToolStripMenuItem";
            this.sQLQuerysToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.sQLQuerysToolStripMenuItem.Text = "SQL Querys";
            this.sQLQuerysToolStripMenuItem.Click += new System.EventHandler(this.sQLQuerysToolStripMenuItem_Click);
            // 
            // new_query
            // 
            this.new_query.Name = "new_query";
            this.new_query.Size = new System.Drawing.Size(152, 22);
            this.new_query.Text = "New";
            this.new_query.Click += new System.EventHandler(this.new_query_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // open_query
            // 
            this.open_query.Name = "open_query";
            this.open_query.Size = new System.Drawing.Size(152, 22);
            this.open_query.Text = "Open";
            this.open_query.Click += new System.EventHandler(this.open_query_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // save_query
            // 
            this.save_query.Name = "save_query";
            this.save_query.Size = new System.Drawing.Size(152, 22);
            this.save_query.Text = "Save";
            this.save_query.Click += new System.EventHandler(this.save_query_Click);
            // 
            // save_query_as
            // 
            this.save_query_as.Name = "save_query_as";
            this.save_query_as.Size = new System.Drawing.Size(152, 22);
            this.save_query_as.Text = "Save As";
            this.save_query_as.Click += new System.EventHandler(this.save_query_as_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // close_query
            // 
            this.close_query.Name = "close_query";
            this.close_query.Size = new System.Drawing.Size(152, 22);
            this.close_query.Text = "Close";
            this.close_query.Click += new System.EventHandler(this.close_query_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(149, 6);
            // 
            // run_query_1
            // 
            this.run_query_1.Name = "run_query_1";
            this.run_query_1.Size = new System.Drawing.Size(152, 22);
            this.run_query_1.Text = "Run Query";
            this.run_query_1.Click += new System.EventHandler(this.run_query_1_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_query_2,
            this.run_query});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1580, 39);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // open_query_2
            // 
            this.open_query_2.Image = ((System.Drawing.Image)(resources.GetObject("open_query_2.Image")));
            this.open_query_2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.open_query_2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open_query_2.Name = "open_query_2";
            this.open_query_2.Size = new System.Drawing.Size(107, 36);
            this.open_query_2.Text = "Open Query";
            this.open_query_2.Click += new System.EventHandler(this.open_query_2_Click);
            // 
            // run_query
            // 
            this.run_query.Image = ((System.Drawing.Image)(resources.GetObject("run_query.Image")));
            this.run_query.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.run_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.run_query.Name = "run_query";
            this.run_query.Size = new System.Drawing.Size(99, 36);
            this.run_query.Text = "Run Query";
            this.run_query.Click += new System.EventHandler(this.run_query_Click);
            // 
            // delete_host
            // 
            this.delete_host.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.delete_host.Image = ((System.Drawing.Image)(resources.GetObject("delete_host.Image")));
            this.delete_host.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.delete_host.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.delete_host.Name = "delete_host";
            this.delete_host.Size = new System.Drawing.Size(36, 36);
            this.delete_host.Text = "Delete Host";
            this.delete_host.Click += new System.EventHandler(this.delete_host_Click);
            // 
            // host_config
            // 
            this.host_config._server = null;
            this.host_config.Dock = System.Windows.Forms.DockStyle.Fill;
            this.host_config.Location = new System.Drawing.Point(0, 0);
            this.host_config.Name = "host_config";
            this.host_config.server = null;
            this.host_config.Size = new System.Drawing.Size(329, 281);
            this.host_config.TabIndex = 2;
            this.host_config.Save += new System.EventHandler(this.host_config_Save);
            this.host_config.Cancel += new System.EventHandler(this.host_config_Cancel);
            this.host_config.Load += new System.EventHandler(this.host_config_Load);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 889);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "SQL-O-Nator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.query_window)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.source_split.Panel1.ResumeLayout(false);
            this.source_split.Panel1.PerformLayout();
            this.source_split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.source_split)).EndInit();
            this.source_split.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pb1;
        private FastColoredTextBoxNS.FastColoredTextBox query_window;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Toggle;
        private System.Windows.Forms.CheckedListBox sources;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_group;
        private System.Windows.Forms.ToolStripMenuItem save_group;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem save_group_as;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem close_group;
        private System.Windows.Forms.ToolStripMenuItem sQLQuerysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_query;
        private System.Windows.Forms.ToolStripMenuItem open_query;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem save_query;
        private System.Windows.Forms.ToolStripMenuItem save_query_as;
        private System.Windows.Forms.ToolStripMenuItem close_query;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem open_group_1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton open_query_2;
        private System.Windows.Forms.ToolStripButton run_query;
        private System.Windows.Forms.ToolStripMenuItem add_host_1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton add_host;
        private controls.new_host host_config;
        private System.Windows.Forms.SplitContainer source_split;
        private System.Windows.Forms.ToolStripButton edit_host;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem run_query_1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox query_results;
        private System.Windows.Forms.ToolStripButton delete_host;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

