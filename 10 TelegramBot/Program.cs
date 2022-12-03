using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _10_TelegramBot
{
    /// <summary>
    /// Program
    /// </summary>
    internal class Program
    {
        static ITelegramBotClient botClient;
      
        static void Main(string[] args)
        {

            botClient = new TelegramBotClient(BotCredentials.BotToken);
            using var cts = new Cancel


        }
    }
    public static class BotCredentials
    {
        public static readonly string BotToken;
        static BotCredentials()
        {
            BotToken = "5309540282:AAH57bjNMi0OEjYLfg6FjY3BBrCYwhJJ2Fk";
        }
    }

}


