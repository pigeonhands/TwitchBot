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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Chatlog = new System.Windows.Forms.TextBox();
            this.commandList = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommandsContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.CommandsContext.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(388, 231);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commandList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Commands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Chatlog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Raw Chat";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Chatlog
            // 
            this.Chatlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chatlog.Location = new System.Drawing.Point(3, 3);
            this.Chatlog.Multiline = true;
            this.Chatlog.Name = "Chatlog";
            this.Chatlog.ReadOnly = true;
            this.Chatlog.Size = new System.Drawing.Size(374, 199);
            this.Chatlog.TabIndex = 0;
            this.Chatlog.Text = "Made by BahNahNah\r\nuid=2388291\r\n";
            this.Chatlog.WordWrap = false;
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
            this.commandList.Size = new System.Drawing.Size(374, 199);
            this.commandList.TabIndex = 0;
            this.commandList.UseCompatibleStateImageBehavior = false;
            this.commandList.View = System.Windows.Forms.View.Details;
            this.commandList.SelectedIndexChanged += new System.EventHandler(this.commandsList_SelectedIndexChanged);
            this.commandList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.commandsList_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(380, 205);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raffel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Command";
            this.columnHeader1.Width = 164;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Action";
            this.columnHeader2.Width = 184;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 231);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.CommandsContext.ResumeLayout(false);
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
    }
}