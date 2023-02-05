using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// AutoResetEvent - Уведомляет ожидающий поток о том, что произошло событие. 

namespace _3.AutoResetEvent__Описание_
{
    internal class Program
    {
        // Аргумент:
        // false - установка в несигнальное состояние.
        static AutoResetEvent auto = new AutoResetEvent(false);
        static void Main(string[] args)
        {
         
          
            new Thread(Function1).Start();
            new Thread(Function2).Start();
           
            Thread.Sleep(500);  // Дадим время запуститься вторичным потокам.
  
            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");
            Console.ReadKey();
            auto.Set(); // Посылает сигнал одному потоку.
            auto.Set(); // Посылает сигнал другому потоку.
            
            
         

            // Delay
            Console.ReadKey();
        }
        static void Function1()
        {
            Console.WriteLine("Поток 1 запущен и ожидает сигнала.");
            auto.WaitOne(); // Остановка выполнения вторичного потока 1.
            Console.WriteLine("Поток 1 завершается.");
        }

        static void Function2()
        {
            Console.WriteLine("Поток 2 запущен и ожидает сигнала.");
            auto.WaitOne(); // Остановка выполнения вторичного потока 2.
            Console.WriteLine("Поток 2 завершается.");
        }
    }
}
