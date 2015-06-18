namespace TwitchBot
{
    partial class AddCommandForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.commandTypeList = new System.Windows.Forms.ComboBox();
            this.commandOptionPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command Type:";
            // 
            // commandTypeList
            // 
            this.commandTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commandTypeList.FormattingEnabled = true;
            this.commandTypeList.Location = new System.Drawing.Point(89, 6);
            this.commandTypeList.Name = "commandTypeList";
            this.commandTypeList.Size = new System.Drawing.Size(217, 21);
            this.commandTypeList.TabIndex = 1;
            this.commandTypeList.SelectedIndexChanged += new System.EventHandler(this.commandTypeList_SelectedIndexChanged);
            // 
            // commandOptionPanel
            // 
            this.commandOptionPanel.Location = new System.Drawing.Point(6, 55);
            this.commandOptionPanel.Name = "commandOptionPanel";
            this.commandOptionPanel.Size = new System.Drawing.Size(300, 130);
            this.commandOptionPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Command Flag:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "!defaultFlag";
            // 
            // AddCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 192);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commandOptionPanel);
            this.Controls.Add(this.commandTypeList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCommandForm";
            this.Text = "AddCommandForm";
            this.Load += new System.EventHandler(this.AddCommandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox commandTypeList;
        private System.Windows.Forms.Panel commandOptionPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}