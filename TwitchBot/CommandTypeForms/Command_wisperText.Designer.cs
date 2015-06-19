namespace TwitchBot.CommandTypeForms
{
    partial class Command_wisperText
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "{username} = senders username";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(291, 82);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Shhhh, wisper.";
            // 
            // Command_wisperText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Command_wisperText";
            this.Size = new System.Drawing.Size(300, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
