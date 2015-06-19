using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot.CommandTypeForms
{
    public delegate void CommandCallback(CommandData cmd, bool hasParamiters);
    public class CommandData
    {
        private object[] _TagData;
        private string _type;
        public object[] TagData
        {
            get { return _TagData; }
        }
        public string Type
        {
            get { return _type; }
        }
        public CommandData(string t, params object[] tagDataParams)
        {
            _type = t;
            _TagData = tagDataParams;
        }
    }
    public struct TBotCommandType
    {
        public const string SayText = "Say Text";
        public const string AddToGiveaway = "Add to giveaway";
        public const string BanUser = "Ban user";
        public const string TimeoutUser = "Timeout User";
        public const string AntiBot = "AntiBot On/Off";
        //public const string WisperText = "Wisper Text";
    }
}
