using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitHandle__Примиер_
{
    internal class Program
    {
        static WaitHandle[] events = new WaitHandle[]
       {
            new AutoResetEvent(false), // 0
            new AutoResetEvent(false)  // 1
       };
        static void Main(string[] args)
        {
            // Помещение двух задач в пул потоков. 
            ThreadPool.QueueUserWorkItem(Task1, events[0]);
            ThreadPool.QueueUserWorkItem(Task2, events[1]);

            Console.WriteLine("Ожидание завершения обеих задач.");
            WaitHandle.WaitAll(events); // ожидание завершения всех задач

            // Помещение двух задач в пул потоков. 
            ThreadPool.QueueUserWorkItem(Task1, events[0]);
            ThreadPool.QueueUserWorkItem(Task2, events[1]);

            Console.WriteLine("\nОжидание завершения одной из задач.");
            // [вторая задача Task2 продолжит выполнение параллельно с первичнм потоком]
            int index = WaitHandle.WaitAny(events); // ожидание завершения одной из задач
            Console.WriteLine("\nЗадача Task{0} завершилась первой.", index + 1);
            

            // Delay
            Console.ReadKey();
            Console.ReadKey();
        }
        static void Task1(Object state)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("1 ");
                Thread.Sleep(500);
            }
            (state as AutoResetEvent).Set();
        }

        static void Task2(Object state)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("2 ");
                Thread.Sleep(500);
            }
            (state as AutoResetEvent).Set();
        }
    }
}
