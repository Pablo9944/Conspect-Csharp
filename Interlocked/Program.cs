using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Interlocked - Предоставляет атомарные операции для переменных, общедоступных нескольким потокам.

namespace InterLocked
{

    internal class Program
    {

        // Счетчик запущеных потоков
        static long counter;
        //static object block = new object();


        static void Main(string[] args)
        {
            Console.WriteLine("Ожидаемое значение счетчика = 10000000");

            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; ++i)
                (threads[i] = new Thread(Procedure)).Start();

            for (int i = 0; i < 10; ++i)
                threads[i].Join();

            Console.WriteLine("Реальное значение счетчика  = {0}", counter);

            // Delay
            Console.ReadKey();
        }
        static void Procedure()
        {
            // Увеличение счетчика

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref counter);

                //lock (block)
                //{
                //  counter++;
                //}
            }
        }

    }
}
