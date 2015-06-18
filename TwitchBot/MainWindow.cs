using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchBot.CommandTypeForms;

namespace TwitchBot
{
    public partial class MainWindow : Form
    {
        TBot _bot;
        Random r = new Random();
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
            TBotCommand command = null;
            foreach(ListViewItem i in commandList.Items)
            {
                TBotCommand _tCom = (TBotCommand)i.Tag;
                
                string msgCompare = message.Text;
                if (!_tCom.FlagCaseSensitive)
                    msgCompare = msgCompare.ToLower();
                if (_tCom.FlagIsRegex)
                {
                    if (Regex.Match(msgCompare, _tCom.Flag).Success)
                    {
                        command = _tCom;
                        break;
                    }
                }
                else
                {
                    if (i.Text.ToLower() == msgCompare)
                    {
                        command = _tCom;
                        break;
                    }
                }
                
            }
            if (command != null)
                ExecuteCommand(command, message);
        }

        void ExecuteCommand(TBotCommand command, TBotMessage msg)
        {
            switch(command.Data.Type)
            {
                case TBotCommandType.SayText:
                    Bot.SayAsync(((string)command.Data.TagData[0]).Replace("{username}", msg.Username));
                    break;
                case TBotCommandType.AddToGiveaway:
                    AddToGiveaway(msg.Username);
                    break;
            }
        }

        void AddToGiveaway(string username)
        {
            if (!acceptGiveawayEntries.Checked)
                return;
            if(MultipleGiveawayEntries.Checked)
            {
                giveawayEntries.Items.Add(username);
            }
            else
            {
                if(!giveawayEntries.Items.Contains(username))
                    giveawayEntries.Items.Add(username);
            }
            currentGiveawayEntrieCount.Text = giveawayEntries.Items.Count.ToString();
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
                    bool canAdd = true;
                    foreach (ListViewItem ci in commandList.Items)
                        if (ci.Text.ToLower() == acf.Command.Flag.ToLower())
                            canAdd = false;
                    if (canAdd)
                    {
                        ListViewItem i = new ListViewItem(acf.Command.Flag);
                        i.Tag = acf.Command;
                        i.SubItems.Add(acf.Command.Data.Type);
                        if (acf.Command.FlagIsRegex)
                            i.SubItems[1].Text += " [R]";
                        if(acf.Command.FlagCaseSensitive)
                            i.SubItems[1].Text += " [C]";
                        commandList.Items.Add(i);
                    }
                    else
                    {
                        MessageBox.Show("There is alredy a command with this flag.");
                    }
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
                TBotCommand cd = (TBotCommand)i.Tag;
                using(AddCommandForm acf = new AddCommandForm(cd, i.Text))
                {
                    if(acf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        i.Text = acf.Command.Flag;
                        i.Tag = acf.Command;
                        i.SubItems[1].Text = acf.Command.Data.Type;
                        if (acf.Command.FlagIsRegex)
                            i.SubItems[1].Text += " [R]";
                        if (acf.Command.FlagCaseSensitive)
                            i.SubItems[1].Text += " [C]";
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text != string.Empty)
                {
                    _bot.SayAsync(textBox1.Text);
                    textBox1.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to clear the usernames in the current giveaway list?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                giveawayEntries.Items.Clear();
                currentGiveawayEntrieCount.Text = giveawayEntries.Items.Count.ToString();
                GiveawayWinner.Text = "-BahNahNah-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceptGiveawayEntries.Checked = false;
            if (giveawayEntries.Items.Count < 1)
            {
                GiveawayWinner.Text = "Nobody wins.";
                return;
            }
            string winner = (string)giveawayEntries.Items[r.Next(0, giveawayEntries.Items.Count - 1)];
            GiveawayWinner.Text = winner;
            _bot.SayAsync("{0} has won the giveaway!", winner);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> giveawayCommands = new List<string>();
            foreach(ListViewItem i in commandList.Items)
            {
                CommandData cd = (CommandData)i.Tag;
                if (cd.Type == TBotCommandType.AddToGiveaway)
                    giveawayCommands.Add(i.Text);
            }
            if(giveawayCommands.Count < 1)
            {
                MessageBox.Show("No giveaway commands, add in the commands tab.");
                return;
            }
            Bot.SayAsync("Type {0} to join the giveaway!", string.Join(", ", giveawayCommands.ToArray()));
        }

        private void removeSelectedCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (commandList.SelectedIndices.Count > 0)
            {
                ListViewItem i = commandList.SelectedItems[0];
                commandList.Items.Remove(i);
            }
        }

        private void addNewWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(PromptStringBox psb = new PromptStringBox("Enter a word to blacklist", "Blacklist"))
            {
                if(psb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    blacklistedWords.Items.Add(psb.InputText);
                }
            }
        }

        private void loadWordsFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text file|*.txt";
                if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //FileExists and import txt
                }
            }
        }
    }
}
