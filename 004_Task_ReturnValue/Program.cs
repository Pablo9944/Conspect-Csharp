using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _004_Task_ReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.OperationAsync();

            Console.WriteLine("Первичный поток завершил работу. ThreadID {0}",
                Thread.CurrentThread.ManagedThreadId);

            // Delay
            Console.ReadKey();
        }
    }
    class MyClass
    {
        int Operation()
        {
            Console.WriteLine("Операция выполняется в потоке ThreadID {0}",
                Thread.CurrentThread.ManagedThreadId);

            Thread.Sleep(2000);
            return 2 + 2;
        }

        public void OperationAsync()
        {
            Task<int> task = Task<int>.Factory.StartNew(Operation);
            TaskAwaiter<int> awaiter = task.GetAwaiter();
            Action continuation = () => Console.WriteLine("\nРезультат: {0}\n", awaiter.GetResult());
            awaiter.OnCompleted(continuation);
        }
    }
}
