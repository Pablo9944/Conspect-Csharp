﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Requests;
using Telegram.Bot.Requests.Abstractions;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Payments;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot;


namespace _6._0._2_Библиотека_Telegram.Bot.Файловое_облако_на_основе_телеграм_бота
{
    internal class Program
    {
        static TelegramBotClient bot;
        static async void Main(string[] args)
        {
            string token = "5309540282:AAH57bjNMi0OEjYLfg6FjY3BBrCYwhJJ2Fk";


            #region exc

            //// https://hidemyna.me/ru/proxy-list/?maxtime=250#list

            // Содержит параметры HTTP-прокси для System.Net.WebRequest класса.
            var proxy = new WebProxy()
            {
                Address = new Uri($"http://31.173.140.183:3629"),
                UseDefaultCredentials = false,
                //Credentials = new NetworkCredential(userName: "login", password: "password")
            };

            // Создает экземпляр класса System.Net.Http.HttpClientHandler.
            var httpClientHandler = new HttpClientHandler() { Proxy = proxy };

            // Предоставляет базовый класс для отправки HTTP-запросов и получения HTTP-ответов 
            // от ресурса с заданным URI.
            HttpClient hc = new HttpClient(httpClientHandler);

            bot = new TelegramBotClient(token, hc);

            

            #endregion

            //bot = new TelegramBotClient(token);
            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            Console.ReadKey();
        }

        private static void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e)
            {
                string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";

                Console.WriteLine($"{text} TypeMessage: {e.Message.Type.ToString()}");


                if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
                {
                    Console.WriteLine(e.Message.Document.FileId);
                    Console.WriteLine(e.Message.Document.FileName);
                    Console.WriteLine(e.Message.Document.FileSize);

                    DownLoad(e.Message.Document.FileId, e.Message.Document.FileName);
                }

                if (e.Message.Text == null) return;

                var messageText = e.Message.Text;


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
        }


    }
