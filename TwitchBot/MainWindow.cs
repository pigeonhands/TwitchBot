using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchBot.CommandTypeForms;

namespace TwitchBot
{
    public partial class MainWindow : Form
    {
        TBot _bot;

        public TBot Bot
        {
            get { return _bot; }
        }

        public MainWindow()
        {
            
            using(BotStartForm bsf = new BotStartForm())
            {
                if(bsf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    Environment.Exit(0);
                    return;
                }
                _bot = bsf.Bot;
            }
            InitializeComponent();
            _bot.OnMessageRead += _bot_OnMessageRead;
            _bot.OnDisconnect += _bot_OnDisconnect;
            _bot.OnConnect += _bot_OnConnect;
            _bot.Start();
        }

        void _bot_OnConnect(TBot sender, bool success)
        {
            if (success)
            {
                MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("Failed to connect");
                Environment.Exit(0);
                return;
            }
        }

        void _bot_OnDisconnect(TBot sender, Exception ex)
        {
            MessageBox.Show("Lost connection! \n " + ex.Message);
            Environment.Exit(0);
            return;
        }

        void _bot_OnMessageRead(TBot sender, TBotMessage message, string raw)
        {
            Chatlog.AppendText(string.Format("<{0}> {1}\n", message.Username, message.Text));
            CommandData cd = null;
            foreach(ListViewItem i in commandList.Items)
            {
                if(i.Text.ToLower() == message.Text.ToLower())
                {
                    cd = (CommandData)i.Tag;
                    break;
                }
            }
            if (cd != null)
                ExecuteCommand(cd, message);
        }

        void ExecuteCommand(CommandData cd, TBotMessage msg)
        {
            switch(cd.Type)

            {
                case TBotCommandType.SayText:
                    Bot.SayAsync(((string)cd.TagData[0]).Replace("{username}", msg.Username));
                    break;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void CommandsContext_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void addNewCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddCommandForm acf = new AddCommandForm())
            {
                if(acf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ListViewItem i = new ListViewItem(acf.CommandFlag);
                    i.Tag = acf.Command;
                    i.SubItems.Add(acf.Command.Type);
                    commandList.Items.Add(i);
                }
            }
        }

        private void commandsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commandsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(commandList.SelectedIndices.Count > 0)
            {
                ListViewItem i = commandList.SelectedItems[0];
                CommandData cd = (CommandData)i.Tag;
                using(AddCommandForm acf = new AddCommandForm(cd, i.Text))
                {
                    if(acf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        i.Text = acf.CommandFlag;
                        i.Tag = acf.Command;
                        i.SubItems[1].Text = acf.Command.Type;
                    }
                }
            }
        }
    }
}
