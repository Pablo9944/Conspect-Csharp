using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_TPL_Id
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main: Task.CurrentId = {0}",  // Main - задача?
            Task.CurrentId == null ? "null" : Task.CurrentId.ToString());

            Task task1 = new Task(MyTask);
            Task task2 = new Task(MyTask);

            task1.Start();
            task2.Start();

            Console.WriteLine("Id задачи task1: " + task1.Id);
            Console.WriteLine("Id задачи task2: " + task2.Id);

            // Delay
            Console.ReadKey();
        }
        static void MyTask()
        {
            Console.WriteLine("MyTask: CurrentId {0} c ManagedThreadId {1} запущен.",
                Task.CurrentId, Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);

            Console.WriteLine("MyTask: CurrentId " + Task.CurrentId + " завершен.");
        }
    }
}
