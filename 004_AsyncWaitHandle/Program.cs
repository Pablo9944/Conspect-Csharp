using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_AsyncWaitHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> myDelegate = new Func<int, int, int>(Sum);

            IAsyncResult asyncResult = myDelegate.BeginInvoke(1, 2, null, null);

            Console.WriteLine("Асинхронный метод запущен. Метод Main продолжает работать.");
            Console.WriteLine("Метод Main ожидает завершения асинхронной задачи.");

            Console.WriteLine(asyncResult.AsyncWaitHandle.GetType()); // Какого типа объект синхронизации?            
            asyncResult.AsyncWaitHandle.WaitOne(); // Приостановка первичного потока.

            Console.WriteLine("Асинхронный метод завершен. Метод Main продолжает работать.");

            // Получение результата асинхронной операции.
            int result = myDelegate.EndInvoke(asyncResult);
            Console.WriteLine("Результат = " + result);

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
