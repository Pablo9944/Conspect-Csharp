using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DestructorRunTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            GC.Collect();
            Console.ReadKey();
        }
    }
    class MyClass
    {
        // Время жизни деструктора ограничено 
        // (индивидуально для разных конфигураций систем).
        ~MyClass()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
