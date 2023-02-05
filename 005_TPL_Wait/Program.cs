using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _005_TPL_Wait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(MyTask);
            task.Start();

            Thread.Sleep(500);

            Console.WriteLine("\ntask.IsCompleted = " + task.IsCompleted);

            // Ожидание завершения асинхронной задачи.

            // Вариант 1:
            task.Wait();

            // Вариант 2:
            //while (!task.IsCompleted)
            //    Thread.Sleep(100);

            // Вариант 3: 
            //IAsyncResult asynkResult = task as IAsyncResult;
            //ManualResetEvent waitHandle = asynkResult.AsyncWaitHandle as ManualResetEvent;
            //waitHandle.WaitOne();

            Console.WriteLine("\ntask.IsCompleted = " + task.IsCompleted);

            // Delay
            Console.ReadKey();
        }
        static void MyTask()
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(25);
                Console.Write(".");
            }
        }
    }
}
