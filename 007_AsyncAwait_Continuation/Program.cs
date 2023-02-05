using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _007_AsyncAwait_Continuation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass my = new MyClass();
            Task task = my.OperationAsync();

            task.ContinueWith(t => Console.WriteLine("\nПродолжение задачи."));



            // Delay
            Console.ReadKey();


        }
    }
    class MyClass
    {
        public void Operation()
        {
           // Thread.Sleep(2000);
            Console.WriteLine("Основная задача");
        }


        public async Task OperationAsync()
        {
            // return указывать не нужно, т.к. await сформирует return (неявно) самостоятельно.
            await Task.Factory.StartNew(Operation);
          


        }
    }
}
