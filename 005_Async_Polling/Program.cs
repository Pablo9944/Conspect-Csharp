using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005_Async_Polling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Асинхронный метод запущен. Метод Main продолжает работать.");

            // Выполнение цикла до тех пор, пока работает асинхронная операция.
            while (!asyncResult.IsCompleted)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }

            // Получение результата асинхронной операции.
            int result = myDelegate.EndInvoke(asyncResult);

            Console.WriteLine("\nРезультат = " + result);

            // Delay
            Console.ReadKey();
        }
        // Метод для выполнения в отдельном потоке.
        static int Sum(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }
    }
}
