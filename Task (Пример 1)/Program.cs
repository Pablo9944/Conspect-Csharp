using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task__Пример_1_
{
    internal class Program
    {
        static void Method()
        {
            Console.WriteLine($"Method() CurrentId {Task.CurrentId} запущен.");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);

                Console.WriteLine($"Method() # {Task.CurrentId} i = {i}");
            }

            Console.WriteLine($"Method() CurrentId {Task.CurrentId} окончен.");
        }

        static void Main()
        {
            Console.WriteLine("Main запущен.");

            Task t1 = new Task(Method);
            Task t2 = new Task(Method);

            // Выполнение задач.
            t1.Start();
            t2.Start();

            Console.WriteLine($"Идентификатор задачи t1: {t1.Id}");
            Console.WriteLine($"Идентификатор задачи t2: {t2.Id}");

            // Метод Main() остается активным до завершения задачи Method(). 
            for (int i = 0; i < 10; i++)
            {
                Console.Write("- ");
                Thread.Sleep(50);
            }

            Console.WriteLine("Main окончен");
            Console.WriteLine($"\nId основного потока равен null : {Task.CurrentId == null}.");


        }
    }
}
