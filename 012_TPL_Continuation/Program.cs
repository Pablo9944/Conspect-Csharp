using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _012_TPL_Continuation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Создание задачи.
            Action action = new Action(MyTask);
            Task task = new Task(action);

            // Создание продолжения задачи.
            Action<Task> continuation = new Action<Task>(ContinuationTask);
            Task taskContinuation = task.ContinueWith(continuation);
            
            
            // Выполнение последовательности задач.
            task.Start();

            // Delay.
            Console.ReadKey();
        }

        // Метод который будет выполнен как задача.
        static void MyTask()
        {
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("+");
            }
        }
        // Метод исполняемый как продолжение задачи.
        static void ContinuationTask(Task task)
        {
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("-");
                
            }
        }
        static void ContinuationTask_2(Task task)
        {
            for (int count = 0; count < 10; count++)
            {
                Thread.Sleep(200);
                Console.Write("*");

            }
        }

    }
}
