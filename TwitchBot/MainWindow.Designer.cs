namespace TwitchBot
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Public Commands", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Moderator Commands", System.Windows.Forms.HorizontalAlignment.Left);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.commandList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommandsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.blacklistedWords = new System.Windows.Forms.ListBox();
            this.BlacklistedWordsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWordsFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.GiveawayWinner = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MultipleGiveawayEntries = new System.Windows.Forms.CheckBox();
            this.currentGiveawayEntrieCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptGiveawayEntries = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.giveawayEntries = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Chatlog = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.modList = new System.Windows.Forms.ListBox();
            this.modListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addModeratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectedModeratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CommandsContext.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.BlacklistedWordsContext.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.modListContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 271);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commandList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(371, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Commands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // commandList
            // 
            this.commandList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.commandList.ContextMenuStrip = this.CommandsContext;
            this.commandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandList.FullRowSelect = true;
            this.commandList.GridLines = true;
            listViewGroup1.Header = "Public Commands";
            listViewGroup1.Name = "everyone";
            listViewGroup2.Header = "Moderator Commands";
            listViewGroup2.Name = "mod";
            this.commandList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.commandList.Location = new System.Drawing.Point(3, 3);
            this.commandList.MultiSelect = false;
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(365, 239);
            this.commandList.TabIndex = 0;
            this.commandList.UseCompatibleStateImageBehavior = false;
            this.commandList.View = System.Windows.Forms.View.Details;
            this.commandList.SelectedIndexChanged += new System.EventHandler(this.commandsList_SelectedIndexChanged);
            this.commandList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.commandsList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 154;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Info";
            this.columnHeader2.Width = 147;
            // 
            // CommandsContext
            // 
            this.CommandsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCommandToolStripMenuItem,
            this.removeSelectedCommandToolStripMenuItem});
            this.CommandsContext.Name = "CommandsContext";
            this.CommandsContext.Size = new System.Drawing.Size(222, 48);
            this.CommandsContext.Opening += new System.ComponentModel.CancelEventHandler(this.CommandsContext_Opening);
            // 
            // addNewCommandToolStripMenuItem
            // 
            this.addNewCommandToolStripMenuItem.Name = "addNewCommandToolStripMenuItem";
            this.addNewCommandToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.addNewCommandToolStripMenuItem.Text = "Add new command";
            this.addNewCommandToolStripMenuItem.Click += new System.EventHandler(this.addNewCommandToolStripMenuItem_Click);
            // 
            // removeSelectedCommandToolStripMenuItem
            // 
            this.removeSelectedCommandToolStripMenuItem.Name = "removeSelectedCommandToolStripMenuItem";
            this.removeSelectedCommandToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.removeSelectedCommandToolStripMenuItem.Text = "Remove selected command";
            this.removeSelectedCommandToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedCommandToolStripMenuItem_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabControl3);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(371, 245);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Chat Control";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(371, 245);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Controls.Add(this.groupBox2);
            this.tabPage7.Controls.Add(this.groupBox1);
            this.tabPage7.Location = new System.Drawing.Point(4, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(363, 219);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Main";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Location = new System.Drawing.Point(4, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 53);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Slow (30 sec interval)";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(191, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Disable";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(6, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Enable";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 53);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subscribers only";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(191, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Disable";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Enable";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AntiBot";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Disable";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Enable";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.blacklistedWords);
            this.tabPage8.Location = new System.Drawing.Point(4, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(363, 219);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Blacklist Words";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // blacklistedWords
            // 
            this.blacklistedWords.ContextMenuStrip = this.BlacklistedWordsContext;
            this.blacklistedWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blacklistedWords.FormattingEnabled = true;
            this.blacklistedWords.Location = new System.Drawing.Point(3, 3);
            this.blacklistedWords.Name = "blacklistedWords";
            this.blacklistedWords.Size = new System.Drawing.Size(357, 213);
            this.blacklistedWords.TabIndex = 0;
            // 
            // BlacklistedWordsContext
            // 
            this.BlacklistedWordsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewWordToolStripMenuItem,
            this.loadWordsFromFileToolStripMenuItem,
            this.removeSelectedToolStripMenuItem,
            this.clearListToolStripMenuItem});
            this.BlacklistedWordsContext.Name = "BlacklistedWordsContext";
            this.BlacklistedWordsContext.Size = new System.Drawing.Size(184, 92);
            // 
            // addNewWordToolStripMenuItem
            // 
            this.addNewWordToolStripMenuItem.Name = "addNewWordToolStripMenuItem";
            this.addNewWordToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addNewWordToolStripMenuItem.Text = "Add new word";
            this.addNewWordToolStripMenuItem.Click += new System.EventHandler(this.addNewWordToolStripMenuItem_Click);
            // 
            // loadWordsFromFileToolStripMenuItem
            // 
            this.loadWordsFromFileToolStripMenuItem.Name = "loadWordsFromFileToolStripMenuItem";
            this.loadWordsFromFileToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadWordsFromFileToolStripMenuItem.Text = "Load words from file";
            this.loadWordsFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadWordsFromFileToolStripMenuItem_Click);
            // 
            // removeSelectedToolStripMenuItem
            // 
            this.removeSelectedToolStripMenuItem.Name = "removeSelectedToolStripMenuItem";
            this.removeSelectedToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.removeSelectedToolStripMenuItem.Text = "remove selected";
            this.removeSelectedToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearListToolStripMenuItem.Text = "Clear list";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(371, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Giveaway";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(371, 245);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.GiveawayWinner);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.MultipleGiveawayEntries);
            this.tabPage4.Controls.Add(this.currentGiveawayEntrieCount);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.acceptGiveawayEntries);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(363, 219);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Main";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // GiveawayWinner
            // 
            this.GiveawayWinner.AutoSize = true;
            this.GiveawayWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveawayWinner.ForeColor = System.Drawing.Color.Lime;
            this.GiveawayWinner.Location = new System.Drawing.Point(89, 84);
            this.GiveawayWinner.Name = "GiveawayWinner";
            this.GiveawayWinner.Size = new System.Drawing.Size(106, 20);
            this.GiveawayWinner.TabIndex = 8;
            this.GiveawayWinner.Text = "-BahNahNah-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Winner:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(6, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(354, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Say giveaway commands";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(6, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear current entries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Draw a winner";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MultipleGiveawayEntries
            // 
            this.MultipleGiveawayEntries.AutoSize = true;
            this.MultipleGiveawayEntries.Location = new System.Drawing.Point(6, 26);
            this.MultipleGiveawayEntries.Name = "MultipleGiveawayEntries";
            this.MultipleGiveawayEntries.Size = new System.Drawing.Size(96, 17);
            this.MultipleGiveawayEntries.TabIndex = 3;
            this.MultipleGiveawayEntries.Text = "Multiple entries";
            this.MultipleGiveawayEntries.UseVisualStyleBackColor = true;
            // 
            // currentGiveawayEntrieCount
            // 
            this.currentGiveawayEntrieCount.AutoSize = true;
            this.currentGiveawayEntrieCount.Location = new System.Drawing.Point(95, 46);
            this.currentGiveawayEntrieCount.Name = "currentGiveawayEntrieCount";
            this.currentGiveawayEntrieCount.Size = new System.Drawing.Size(13, 13);
            this.currentGiveawayEntrieCount.TabIndex = 2;
            this.currentGiveawayEntrieCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current entered:";
            // 
            // acceptGiveawayEntries
            // 
            this.acceptGiveawayEntries.AutoSize = true;
            this.acceptGiveawayEntries.Location = new System.Drawing.Point(6, 6);
            this.acceptGiveawayEntries.Name = "acceptGiveawayEntries";
            this.acceptGiveawayEntries.Size = new System.Drawing.Size(95, 17);
            this.acceptGiveawayEntries.TabIndex = 0;
            this.acceptGiveawayEntries.Text = "Accept Entries";
            this.acceptGiveawayEntries.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.giveawayEntries);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(363, 219);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Entries";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // giveawayEntries
            // 
            this.giveawayEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giveawayEntries.FormattingEnabled = true;
            this.giveawayEntries.Location = new System.Drawing.Point(3, 3);
            this.giveawayEntries.Name = "giveawayEntries";
            this.giveawayEntries.Size = new System.Drawing.Size(357, 213);
            this.giveawayEntries.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.Chatlog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(371, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Chatlog
            // 
            this.Chatlog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chatlog.Location = new System.Drawing.Point(3, 3);
            this.Chatlog.Multiline = true;
            this.Chatlog.Name = "Chatlog";
            this.Chatlog.ReadOnly = true;
            this.Chatlog.Size = new System.Drawing.Size(381, 208);
            this.Chatlog.TabIndex = 0;
            this.Chatlog.Text = "Made by BahNahNah\r\nuid=2388291\r\n";
            this.Chatlog.WordWrap = false;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox4);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(371, 245);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Bot settings";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.modList);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(371, 245);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bot Moderator list";
            // 
            // modList
            // 
            this.modList.ContextMenuStrip = this.modListContext;
            this.modList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modList.FormattingEnabled = true;
            this.modList.Location = new System.Drawing.Point(3, 16);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(365, 226);
            this.modList.TabIndex = 0;
            // 
            // modListContext
            // 
            this.modListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModeratorToolStripMenuItem,
            this.removeSelectedModeratorToolStripMenuItem,
            this.clearListToolStripMenuItem1});
            this.modListContext.Name = "modListContext";
            this.modListContext.Size = new System.Drawing.Size(223, 70);
            // 
            // addModeratorToolStripMenuItem
            // 
            this.addModeratorToolStripMenuItem.Name = "addModeratorToolStripMenuItem";
            this.addModeratorToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addModeratorToolStripMenuItem.Text = "Add moderator";
            this.addModeratorToolStripMenuItem.Click += new System.EventHandler(this.addModeratorToolStripMenuItem_Click);
            // 
            // removeSelectedModeratorToolStripMenuItem
            // 
            this.removeSelectedModeratorToolStripMenuItem.Name = "removeSelectedModeratorToolStripMenuItem";
            this.removeSelectedModeratorToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.removeSelectedModeratorToolStripMenuItem.Text = "Remove selected moderator";
            this.removeSelectedModeratorToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedModeratorToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem1
            // 
            this.clearListToolStripMenuItem1.Name = "clearListToolStripMenuItem1";
            this.clearListToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.clearListToolStripMenuItem1.Text = "Clear list";
            this.clearListToolStripMenuItem1.Click += new System.EventHandler(this.clearListToolStripMenuItem1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 271);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainWindow";
            this.Text = "TwitchBot - BahNahNah";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CommandsContext.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.BlacklistedWordsContext.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.modListContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Chatlog;
        private System.Windows.Forms.ListView commandList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip CommandsContext;
        private System.Windows.Forms.ToolStripMenuItem addNewCommandToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox MultipleGiveawayEntries;
        private System.Windows.Forms.Label currentGiveawayEntrieCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox acceptGiveawayEntries;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox giveawayEntries;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label GiveawayWinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedCommandToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox blacklistedWords;
        private System.Windows.Forms.ContextMenuStrip BlacklistedWordsContext;
        private System.Windows.Forms.ToolStripMenuItem addNewWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWordsFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox modList;
        private System.Windows.Forms.ContextMenuStrip modListContext;
        private System.Windows.Forms.ToolStripMenuItem addModeratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSelectedModeratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem1;
    }
}