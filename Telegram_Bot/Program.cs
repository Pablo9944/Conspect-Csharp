using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Net;
using System.Net.Http;
using Telegram.Bot.Types.InputFiles;

namespace Telegram_Bot
{
    internal class Program
    {
        static TelegramBotClient bot;
        static void Main(string[] args)
        {
            #region exc

            ////// https://hidemyna.me/ru/proxy-list/?maxtime=250#list

            //// Содержит параметры HTTP-прокси для System.Net.WebRequest класса.
            //var proxy = new WebProxy()
            //{
            //    Address = new Uri($"http://77.87.240.74:3128"),
            //    UseDefaultCredentials = false,
            //    //Credentials = new NetworkCredential(userName: "login", password: "password")
            //};

            //// Создает экземпляр класса System.Net.Http.HttpClientHandler.
            //var httpClientHandler = new HttpClientHandler() { Proxy = proxy };

            //// Предоставляет базовый класс для отправки HTTP-запросов и получения HTTP-ответов 
            //// от ресурса с заданным URI.
            //HttpClient hc = new HttpClient(httpClientHandler);

            //bot = new TelegramBotClient(token, hc);

            #endregion

            string TokenPath = File.ReadAllText(@"F:\tokenTelegram.txt");
            Console.WriteLine(TokenPath);

            bot = new TelegramBotClient(TokenPath.Trim());
            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            Console.ReadKey();
        }
        private static void MessageListener (object sender, MessageEventArgs e)
        {
            string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";
            Console.WriteLine($"{text} TypeMessage: {e.Message.Type.ToString()}");
            

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Video)
            {
                //Console.WriteLine(e.Message.Document.FileId);
                //Console.WriteLine(e.Message.Document.FileName);
                //Console.WriteLine(e.Message.Document.FileSize);

                DownLoad(e.Message.Video.FileId, e.Message.Video.FileId);
                System.Threading.Thread.Sleep(10000);
                
            }
            
            if (e.Message.Text == null) return;
            var messageText = e.Message.Text;
            //var file = new InputOnlineFile(new FileStream("_" + e.Message.Video.FileId, FileMode.Open, FileAccess.Read, FileShare.Read));
            //bot.SendVideoAsync(e.Message.Chat.Id, file);

            bot.SendTextMessageAsync(e.Message.Chat.Id,
               $"{messageText}"
               );
        }
        static async void DownLoad(string fileId, string path)
        {
            var file = await bot.GetFileAsync(fileId);
            FileStream fs = new FileStream("_" + path, FileMode.Create);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();

            fs.Dispose();
        }
        static async void Upload(string fileId, string path,long Id)
        {
            var file = await bot.GetFileAsync(fileId);
            if (File.Exists(path))
            {
                Console.WriteLine("sds");
            }
            
            FileStream fs = new FileStream("_" + path, FileMode.Open,FileAccess.Read,FileShare.Read);
            await bot.GetUserProfilePhotosAsync(Id);
            fs.Close();

            fs.Dispose();
        }
    }
}
