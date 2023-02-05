using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Возвращение значения из задачи.

namespace _009_TPL_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основной поток запущен.");

            Context context;
            context.a = 2;
            context.b = 3;

            Task<int> task;

            // 1 вариант
            task = new Task<int>(Sum, context);
            task.Start();

            // 2 вариант
            //TaskFactory<int> factory = new TaskFactory<int>();
            //task = factory.StartNew(Sum, context);

            // 3 вариант
            //task = Task<int>.Factory.StartNew(Sum, context);

            Console.WriteLine("Результат выполнения задачи Sum = " + task.Result);

            Console.WriteLine("Основной поток завершен.");

            // Delay
            Console.ReadKey();
        }
        // Метод который будет возвращать результат.
        static int Sum(object arg)
        {
            int a = ((Context)arg).a;
            int b = ((Context)arg).b;

            Thread.Sleep(2000);

            return a + b;
        }
    }
    struct Context
    {
        public int a;
        public int b;
    }
}
