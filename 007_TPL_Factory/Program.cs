using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _007_TPL_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Вариант 1.
            Task task = Task.Factory.StartNew(MyTask);
            // При запуске задачи через TaskFactory, вызов метода Start() не требуется.
            //task.Start();

            // Вариант 2.
            //TaskFactory factory = new TaskFactory();
            //Task task = factory.StartNew(MyTask);

            // Delay
            Console.ReadKey();
        }
        static void MyTask()
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }
        }
    }
}
