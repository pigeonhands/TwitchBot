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
    public partial class AddCommandForm : Form
    {
        private CommandData _data;
        private string _commandFlag;
        public CommandData Command
        {
            get { return _data; }
        }
        public string CommandFlag
        {
            get { return _commandFlag; }
        }
        public AddCommandForm()
        {
            InitializeComponent();
            foreach (var cmdName in typeof(TBotCommandType).GetFields())
                commandTypeList.Items.Add(cmdName.GetValue(cmdName));
            if (commandTypeList.Items.Count > 0)
                commandTypeList.SelectedIndex = 0;
            SetComponent(null, "");
        }
        public AddCommandForm(CommandData cd, string flag)
        {
            InitializeComponent();
            foreach (var cmdName in typeof(TBotCommandType).GetFields())
                commandTypeList.Items.Add(cmdName.GetValue(cmdName));
            commandTypeList.Text = cd.Type;
            SetComponent(cd, flag);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddCommandForm_Load(object sender, EventArgs e)
        {

        }

        void SetComponent(CommandData cd, string flag)
        {
            commandOptionPanel.Controls.Clear();
            if (flag != "")
                textBox1.Text = flag;
            switch (commandTypeList.Text)
            {
                case TBotCommandType.SayText:
                    Command_sayText f = new Command_sayText(CommandChosen);
                    if (cd != null)
                        f.SetValues((string)cd.TagData[0]);
                    commandOptionPanel.Controls.Add(f);
                    break;
                default:
                    commandOptionPanel.Controls.Add(new Command_notCompleted());
                    break;
            }
        }

        void CommandChosen(CommandData cmd)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter a flag");
                return;
            }
            _commandFlag = textBox1.Text;
            _data = cmd;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void commandTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetComponent(null, "");
        }
    }
}
