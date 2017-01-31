using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syn.Bot;
using System.IO;

namespace ccNN
{
    class CommandLine
    {
        public static Syn.Bot.Siml.SimlBot Chatbot;

        public static void init()
        {
            Chatbot = new Syn.Bot.Siml.SimlBot();
            Chatbot.PackageManager.LoadFromString(File.ReadAllText( @"C:\Users\carr4\Documents\Visual Studio 2015\Projects\ccNN\ccNN\Resources\siml-english-base-master\epy.simlpk"));
        }
        public static string ReadLine(String text)
        {
            string response = "";
            text = text.ToLower();
            text = text.Replace("\n", "");
            if(text.Equals("exit"))
            {
                Application.Exit();
            }else
            if (text.Contains("nmap"))
            {
                new BasicTextForm(BuiltInCommands.nmap());
            }else
            response = Chatbot.Chat(text).BotMessage;
            return response;
        }

    }
}
