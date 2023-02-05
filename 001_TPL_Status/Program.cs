using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_TPL_Status
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task task = new Task(MyTask);
            Console.WriteLine("1. " + task.Status); // Задача не запущена.

            task.Start();
            Console.WriteLine("2. " + task.Status); // Задача в процессе запуска.

            Thread.Sleep(1000);
            Console.WriteLine("3. " + task.Status); // Задача выполняется.

            Thread.Sleep(3000);
            Console.WriteLine("4. " + task.Status); // Задача завершилась.

            // Delay
            Console.ReadKey();
        }
        static void MyTask()
        {
            Thread.Sleep(3000);
        }
    }
}
