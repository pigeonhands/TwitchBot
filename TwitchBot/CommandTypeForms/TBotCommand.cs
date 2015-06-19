using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.CommandTypeForms
{
    public class TBotCommand
    {
        private CommandData _data;
        private string _flag;
        private bool _flagisregex = false;
        private bool _flagcasesensitive = false;
        private bool _requiresModerator = false;

        public TBotCommand(CommandData cd, string flag)
        {
            _data = cd;
            _flag = flag;
        }

        public CommandData Data
        {
            get { return _data; }
        }
        public string Flag
        {
            get { return _flag; }
        }
        public bool FlagIsRegex
        {
            get { return _flagisregex; }
            set { _flagisregex = value; }
        }
        public bool FlagCaseSensitive
        {
            get { return _flagcasesensitive; }
            set { _flagcasesensitive = value; }
        }
        public bool RequiresModerator
        {
            get { return _requiresModerator; }
            set { _requiresModerator = value; }
        }
    }
}
