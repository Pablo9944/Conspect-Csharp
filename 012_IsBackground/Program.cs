using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _012_IsBackground
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Первичный поток начал работу.");

            Action work = new Action(Procedure);
            work.BeginInvoke(new AsyncCallback(CallBack), work);

            Thread.Sleep(1000);
            Console.WriteLine("\nПервичный поток завершил работу.\n");
        }
        static void Procedure()
        {
            //Thread.CurrentThread.IsBackground = false; // Закомментировать.

            Console.WriteLine("Вторичный поток начал работу.");

            for (int i = 0; i < 240; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.WriteLine("\nВторичный поток завершил работу.");
        }

        static void CallBack(IAsyncResult asyncResult)
        {
            Action work = asyncResult.AsyncState as Action;

            if (work != null)
                work.EndInvoke(asyncResult);
        }
    }
}
