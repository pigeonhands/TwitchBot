using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot.CommandTypeForms
{
    public partial class Command_sayText : UserControl
    {
        CommandCallback callback;
        public Command_sayText(CommandCallback cc)
        {
            callback = cc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Command_sayText_Load(object sender, EventArgs e)
        {

        }

        public void SetValues(string text)
        {
            richTextBox1.Text = text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (callback != null)
                callback(new CommandData(TBotCommandType.SayText, richTextBox1.Text));
        }
    }
}
