using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Пример_как_самому_сделать_асинхронный_метод
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для запуска нажмите любую клавишу");
            Console.ReadKey();

            ThreadPoolWorker threadPoolWorker = new ThreadPoolWorker(new Action<object>(StarWriter));
            threadPoolWorker.Start('*');

            for (int i = 0; i < 40; i++)
            {
                Console.Write('-');
                Thread.Sleep(50);
            }

            threadPoolWorker.Wait();

            Console.WriteLine($"Метод Main закончил свою работу.");
        }

        private static void StarWriter(object arg)
        {
            char item = (char)arg;

            for (int i = 0; i < 120; i++)
            {
                Console.Write(item);
                Thread.Sleep(50);
            }
        }
    }
    }
}
