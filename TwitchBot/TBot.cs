using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TwitchBot
{
    public delegate void MessageReadCallback(TBot sender, TBotMessage message, string raw);
    public delegate void DisconnectedCallback(TBot sender, Exception ex);
    public delegate void ConnectCallback(TBot sender, bool success);
    public class TBot
    {
        private string _username, _oauth, _channel;
        private TcpClient _client;
        StreamReader reader = null;
        StreamWriter writer = null;

        public event MessageReadCallback OnMessageRead;
        public event DisconnectedCallback OnDisconnect;
        public event ConnectCallback OnConnect;

        public TBot(string u, string oa, string ch)
        {
            _username = u;
            _oauth = oa;
            _channel = ch.ToLower();
            if (!_channel.StartsWith("#"))
                _channel = "#" + _channel;
        }

        #region " Properties "

        public string Username
        {
            get { return _username; }
        }

        public string Channel
        {
            get { return _channel; }
        }

        private string Oauth
        {
            get { return _oauth; }
        }

        #endregion

        #region " Functions "

        public void Start()
        {
            try
            {
                _client = new TcpClient("irc.twitch.tv", 6667);
                reader = new StreamReader(_client.GetStream());
                writer = new StreamWriter(_client.GetStream());
                HandleStreamReading();
            }
            catch
            {
                Cleanup();
                if (OnDisconnect != null)
                    OnDisconnect(this, new Exception("Failed to connect to server"));
            }
            
        }

        private async void HandleStreamReading()
        {
            try
            {
                #region " Connection "

                writer.WriteLine("PASS {0}", Oauth);
                writer.WriteLine("NICK {0}", Username);
                await writer.FlushAsync();
                string responce = await reader.ReadLineAsync();
                if(responce.ToLower().Contains("welcome"))
                {
                    if (OnConnect != null)
                        OnConnect(this, true);
                }
                else
                {
                    if (OnConnect != null)
                        OnConnect(this, false);
                    return;
                }

                writer.WriteLine("JOIN {0}", Channel);
                await writer.FlushAsync();

                #endregion

                string line = string.Empty;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    string[] lineSegments = line.Split(new char[] {' '}, 4);

                    if(lineSegments[0] == "PING")
                    {
                        SayAsync("PONG {0}", lineSegments[1]);
                        continue;
                    }

                    string sender = lineSegments[0].Split('!')[0].Replace(":", "");

                    if (sender.ToLower() == Username.ToLower())
                        continue;

                    string message = lineSegments[3].Substring(1, lineSegments[3].Length - 1);

                    try
                    {
                        if (OnMessageRead != null)
                            OnMessageRead(this, new TBotMessage(sender, message), line);
                    }
                    catch { }
                }
                Cleanup();
                if (OnDisconnect != null)
                    OnDisconnect(this, new Exception("Stream returned null"));
            }
            catch(Exception ex)
            {
                Cleanup();
                if (OnDisconnect != null)
                    OnDisconnect(this, ex);
            }
        }

        private void Cleanup()
        {
            if (reader != null)
                reader.Dispose();
            if (writer != null)
                writer.Dispose();
            if (_client != null)
                _client.Close();
        }

        public void Say(string msg, params string[] arg)
        {
            string Message = msg;
            if(arg.Length != 0)
            {
                for (int i = 0; i < arg.Length; i++)
                    Message = Message.Replace("{" + i.ToString() + "}", arg[i]);
            }
            if(writer != null)
            {
                writer.WriteLine("PRIVMSG {0} :{1}", Channel, Message);
                writer.Flush();
            }
        }

        public async void SayAsync(string msg, params string[] arg)
        {
            string Message = msg;
            if (arg.Length != 0)
            {
                for (int i = 0; i < arg.Length; i++)
                    Message = Message.Replace("{" + i.ToString() + "}", arg[i]);
            }
            if (writer != null)
            {
                writer.WriteLine("PRIVMSG {0} :{1}", Channel, Message);
                await writer.FlushAsync();
            }
        }

        #endregion

      
    }

    public class TBotMessage
    {
        private string _username, _text;
        public TBotMessage(string username, string Text)
        {
            _username = username;
            _text = Text;
        }
        public string Username
        {
            get { return _username; }
        }
        public string Text
        {
            get { return _text; }
        }
    }
}
