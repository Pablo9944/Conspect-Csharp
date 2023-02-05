using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSample
{
    internal class Program
    {
        static void Main(string[] args) // Метод Main - выполняется в первичном потоке.
        {
            Console.WriteLine("ID Первичного потока: {0}", Thread.CurrentThread.GetHashCode());

            // Создание нового потока
            Thread thread = new Thread(new ThreadStart(Function));
            thread.Start();

            Console.WriteLine("ID Первичного потока: {0}", Thread.CurrentThread.GetHashCode());
            Thread thread_3 = new Thread(new ThreadStart(Function));
            thread_3.Start();


            // Ожидание первичным потоком, завершения работы вторичного потока.
            // thread.Join(); Останавливает текущий поток и ждет пока не выполнится следующий
        

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write("-");
             }

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("\nПервичный поток завершился.");

            // Delay
            Console.ReadKey();
            
        }
        // Метод выполяняющийся во Вторичном потоке.
        static void Function()
        {
            Console.WriteLine("ID Вторичного потока: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 160; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вторичный поток завершился.");
        }
    }
        
}
