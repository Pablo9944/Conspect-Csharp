using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LiveTime
{
    internal class Program
    {
        static object block = new object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                new Thread(new ThreadStart(Print)).Start();
            }
        }

        static void Print()
        {
            int threadfield = Thread.CurrentThread.GetHashCode();
            lock (block)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Поток # {threadfield} шаг {i}");
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-',15));
            }
         
        }
    }
}
