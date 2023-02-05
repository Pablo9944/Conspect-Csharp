using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _009_AsyncCallBack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            var func = new Func<int, int, int>(Sum);

            func.BeginInvoke(1, 2, CallBack, func);

            Console.WriteLine("Первичный поток завершил работу.");

            // Delay
            //Console.ReadKey();
        }
        // Метод для выполнения в отдельном потоке.
        static int Sum(int a, int b)
        {
            //Thread.CurrentThread.IsBackground = false;

            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return a + b;
        }

        // Метод обработки завершения асинхронной операции.
        static void CallBack(IAsyncResult asyncResult)
        {
            // Получение экземпляра делегата, на котором была вызвана асинхронная операция.
            Func<int, int, int> caller = (asyncResult.AsyncState as Func<int, int, int>);

            // Получение результатов асинхронной операции.
            int sum = caller.EndInvoke(asyncResult);

            Console.WriteLine("a + b = {0}", sum);
        }
    }
}
