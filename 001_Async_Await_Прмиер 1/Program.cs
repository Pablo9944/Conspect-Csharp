using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_Async_Await_Прмиер_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread - {0}",Thread.CurrentThread.ManagedThreadId);
            MyClass mc = new MyClass();
            mc.OperationAsync();

            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine(". - Main Thread");
            }
            Console.WriteLine("End");
        }
    }
}
class MyClass
{
    public void Operation()
    {
        Console.WriteLine("Operation Thread - {0}", Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("Begin");
       
        for (int i = 0; i < 20; i++)
        {
            Thread.Sleep(190);
            Console.Write("Method - Operation");
        }
      
        

    }
    public async void OperationAsync()
    {
        // Id потока совпадает с Id первичного потока. Это значит, что
        // данный метод начинает выполняться в контексте первичного потока.

        Console.WriteLine("OperationAsync (Part I) ThreadID - {0}", Thread.CurrentThread.ManagedThreadId);
        // Вариант №1
        Task task = new Task(Operation);
        task.Start();
        await task;

        // Id потока совпадает с Id вторичного потока. Это значит, что
        // данный метод заканчивает выполняться в контексте вторичного потока.

        Console.WriteLine("OperationAsync (Part II) ThreadID - {0}", Thread.CurrentThread.ManagedThreadId);
       
        // Вариант №2
        //await Task.Run(() =>
        //{
        //    Operation();
        //});


    }


}
