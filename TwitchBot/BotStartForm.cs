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
    public partial class BotStartForm : Form
    {
        private TBot _bot;
        public TBot Bot
        {
            get { return _bot; }
        }
        public BotStartForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bot = new TBot(textBox1.Text, textBox2.Text, textBox3.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BotStartForm_Load(object sender, EventArgs e)
        {
            _bot = new TBot("BahNahNahBot", "oauth:68g2aewlvaon4i99ze354odf99keti", "BahNahNah");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
