using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DestructorThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread ID: {0}",
               Thread.CurrentThread.ManagedThreadId);

            MyClass my = new MyClass();
           
        }
    }
    class MyClass
    {
        ~MyClass()
        {
            Console.WriteLine("Destructor thread ID: {0}",
                Thread.CurrentThread.ManagedThreadId);
        }
    }
}
