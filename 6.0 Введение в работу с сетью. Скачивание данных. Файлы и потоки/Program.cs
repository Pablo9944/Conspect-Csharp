using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _6._0_Введение_в_работу_с_сетью.Скачивание_данных.Файлы_и_потоки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Подключаем using System.Net;

            string url = @"audio_api.mp3";
            WebClient webClient = new WebClient() { Encoding = Encoding.UTF8 };
           
            //от сюда будет происходить скачка
            webClient.BaseAddress = "http://ksergey.ru/sb/";

            // получиться http://ksergey.ru/sb/audio_api.mp3

            #region Скачаивание mp3
            webClient.DownloadFile(url, "audio_api.mp3");
            Console.WriteLine("Готово");
            #endregion
        }
    }
}
