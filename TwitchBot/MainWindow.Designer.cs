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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.commandList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommandsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CommandsContext.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 261);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commandList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 235);
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
            this.commandList.Location = new System.Drawing.Point(3, 3);
            this.commandList.MultiSelect = false;
            this.commandList.Name = "commandList";
            this.commandList.Size = new System.Drawing.Size(308, 229);
            this.commandList.TabIndex = 0;
            this.commandList.UseCompatibleStateImageBehavior = false;
            this.commandList.View = System.Windows.Forms.View.Details;
            this.commandList.SelectedIndexChanged += new System.EventHandler(this.commandsList_SelectedIndexChanged);
            this.commandList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.commandsList_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action";
            this.columnHeader2.Width = 161;
            // 
            // CommandsContext
            // 
            this.CommandsContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCommandToolStripMenuItem});
            this.CommandsContext.Name = "CommandsContext";
            this.CommandsContext.Size = new System.Drawing.Size(180, 26);
            this.CommandsContext.Opening += new System.ComponentModel.CancelEventHandler(this.CommandsContext_Opening);
            // 
            // addNewCommandToolStripMenuItem
            // 
            this.addNewCommandToolStripMenuItem.Name = "addNewCommandToolStripMenuItem";
            this.addNewCommandToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addNewCommandToolStripMenuItem.Text = "Add new command";
            this.addNewCommandToolStripMenuItem.Click += new System.EventHandler(this.addNewCommandToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(314, 235);
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
            this.tabControl2.Size = new System.Drawing.Size(314, 235);
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
            this.tabPage4.Size = new System.Drawing.Size(306, 209);
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
            this.button3.Location = new System.Drawing.Point(6, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Say giveaway commands";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(6, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear current entries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Stop entries and draw winner";
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
            this.tabPage5.Size = new System.Drawing.Size(322, 209);
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
            this.giveawayEntries.Size = new System.Drawing.Size(316, 203);
            this.giveawayEntries.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.Chatlog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
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
            this.Chatlog.Size = new System.Drawing.Size(324, 198);
            this.Chatlog.TabIndex = 0;
            this.Chatlog.Text = "Made by BahNahNah\r\nuid=2388291\r\n";
            this.Chatlog.WordWrap = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 261);
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
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}