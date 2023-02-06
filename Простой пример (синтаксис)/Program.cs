using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Простой_пример__синтаксис_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Метод Main начал свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");

            WriteCharAsync('#'); // Запуск метода асинхронно
            WriteChar('*'); // Запуск метода синхронно

            Console.WriteLine($"Метод Main закончил свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
            Console.ReadKey();
        }
        private static async Task WriteCharAsync(char symbol)
        {
            Console.WriteLine($"Метод WriteCharAsync начал свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");

            Task task = Task.Run(() => WriteChar(symbol));

            await task;
            Console.WriteLine($"Метод WriteCharAsync закончил свою работу в потоке {Thread.CurrentThread.ManagedThreadId}.");
        }

        private static void WriteChar(char symbol)
        {
            Console.WriteLine($"Id потока - [{Thread.CurrentThread.ManagedThreadId}]. Id задачи - [{Task.CurrentId}]");
            Thread.Sleep(500);

            for (int i = 0; i < 80; i++)
            {
                Console.Write(symbol);
                Thread.Sleep(100);
            }
        }
    }
    internal static class MyAsyncExtensions
    {
        public static void DisableAsyncWarning(this Task t)
        {

        }
    }
}
