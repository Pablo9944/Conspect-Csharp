using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_TPL_AsyncState
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Второй аргумент конструктора Task - ".", 
            // попадет в качестве аргумента метода MyTask
            //Action<object> myTask = MyTask;
            Task task = new Task(MyTask, ".");
            task.Start();

            Thread.Sleep(500);

            // Для того чтобы AsyncState был равен не null, требуется использовть 
            // конструктор Task(Action<object> action, object state);
            // Второй аргумент конструктора Task - ".", 
            // попадет в качестве значения свойства AsyncState
            Console.WriteLine("\n[{0}]", task.AsyncState as string);

            // Delay
            Console.ReadKey();
        }
        static void MyTask(object arg)
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(25);
                Console.Write(arg as string);
            }
        }
    }
}
