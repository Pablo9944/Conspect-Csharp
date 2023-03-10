using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/* Свойства Id и CurrentId.
 * Id - Уникальный идентификатор определенного экземпляра Task
 * CurrentId - Уникальный идентификатор выполнящейся задачи
 */

namespace Task__Описание_
{

    internal class Program
    {
        static void Method()
        {
            Console.WriteLine($@"Thread.CurrentThread.ManagedThread - {Thread.CurrentThread.ManagedThreadId}
                                 Task.CurrentId - {Task.CurrentId}"); 
                 
            Console.WriteLine("Method начал работу.");

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Method: i = {i}");
            }

            Console.WriteLine("Method закончил работу.");
        }

        static void Main()
        {
            Console.WriteLine("Main начал работу.");

            var a = new Action(Method);

            var task = new Task(a);

            task.Start();
            Console.WriteLine($"task.Id - {task.Id}");

            for (int i = 0; i < 100; i++)
            {
                Console.Write("- ");
                Thread.Sleep(50);
            }

            Console.WriteLine("Main закончил работу.");
        }
    }
}
