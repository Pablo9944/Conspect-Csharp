using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Первичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            Action myDelegate = new Action(Method);

            // Асинхронный вызов метода - Method (с использованием пула потоков).
            myDelegate.BeginInvoke(null, null); // Invoke() - синхронный вызов. 

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write("1 ");
            }

            // Delay
            Console.ReadKey();
        }
        // Метод для выполнения в отдельном потоке.
        static void Method()
        {
            Console.WriteLine("Вторичный поток: Id {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write("2 ");
            }
        }
    }
}
