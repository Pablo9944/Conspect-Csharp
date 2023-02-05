using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Применение метода Parallel.Invoke() для параллельного выполнения двух методов.

namespace _001_Parallel.Invoke
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Основной поток запущен.");

            ParallelOptions options = new ParallelOptions();

            // Выделить определенное количество процессорных ядер.
            //options.MaxDegreeOfParallelism = Environment.ProcessorCount > 2
            //                          ? Environment.ProcessorCount - 1 : 1;

            options.MaxDegreeOfParallelism = 2; // Попробовать 1 и 2
                                                                  // колличество процессоров на ПК
            Console.WriteLine("Количество логических ядер CPU:" + Environment.ProcessorCount);

            Console.ReadKey();

            // Выполнить параллельно два метода.
            Parallel.Invoke(options, MyTask1, MyTask2);

            // Выполнить параллельно четыре метода.
            //Parallel.Invoke(options, MyTask1, MyTask2, MyTask1, MyTask2);

            // ВНИМАНИЕ!
            // Выполнение метода Main() приостанавливается, 
            // пока не произойдет завершение задач.

            Console.WriteLine("Основной поток завершен.");

            // Delay
            Console.ReadKey();
        }
        static void MyTask1()
        {
            Console.WriteLine("MyTask1: запущен.");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("+");
            }
            Console.WriteLine("MyTask1: завершен.");
        }

        static void MyTask2()
        {
            Console.WriteLine("MyTask2: запущен.");
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(10);
                Console.Write("-");
            }
            Console.WriteLine("MyTask2: завершен.");
        }
    }
}
