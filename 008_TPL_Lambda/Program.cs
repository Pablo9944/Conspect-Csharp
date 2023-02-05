using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _008_TPL_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            // Использование лямбда-оператора для определения задачи.
            Task task = Task.Factory.StartNew(new Action(() =>
            {
                for (int i = 0; i < 80; i++)
                {
                    Thread.Sleep(20);
                    Console.Write(".");
                }
            }));

            // Ожидание завершения задачи.
            task.Wait();

            // Освобождение задачи. 
            task.Dispose();

            Console.WriteLine("Основной поток завершен.");

            // Delay
            Console.ReadKey();
        }
    }
}
