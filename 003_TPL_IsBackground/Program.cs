using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _003_TPL_IsBackground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(MyTask);
            task.Start();

            Thread.Sleep(500); // Время на запуск задачи.

            Console.WriteLine("\nMain завершен.");

            // Delay
           // Console.ReadKey();
        }
        static void MyTask()
        {
           Thread.CurrentThread.IsBackground = false; // Снять комментарий.

            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(100);
                Console.Write(".");
            }
        }
    }
}
