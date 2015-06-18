using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot
{
    public partial class PromptStringBox : Form
    {
        private string _text;
        public string InputText
        {
            get { return _text; }
        }
        public PromptStringBox(string message, string text)
        {
            InitializeComponent();
            this.Text = text;
            msgLabel.Text = message;
        }

        private void PromptStringBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _text = textBox1.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
