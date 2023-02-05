using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Semaphore__Описание_
{
    // SemaphoreSlim - легковесный семафор
    // [не использует средства операционной системы].
    // В КОНТЕКСТЕ 1 ПРОЦЕССА
    internal class Program
    {
        /*
               Аргументы:
               1. [сколько человек пускать на мост]
                  Задаем количество слотов для использования в данный момент 
                  (не более максимального клоличества задаваемого вторым аргументом).
               2. [сколько человек выдержит мост - запас прочности]
                  Задаем максимальное количество слотов для данного семафора.
            */
        static SemaphoreSlim pool;
        static void Main(string[] args)
        {
            pool = new SemaphoreSlim(2, 4);


            for (int i = 1; i <= 8; i++)
            {
                new Thread(Function).Start(i);
            }
        }
        static void Function(object number)
        {
            pool.Wait();

            Console.WriteLine("Поток {0} занял слот семафора.", number);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0} -----> освободил слот.", number);

            pool.Release();
        }
    }
}
