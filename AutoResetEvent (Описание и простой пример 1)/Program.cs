using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEvent__Описание_и_простой_пример_1_
{
    internal class Program
    {
        // Аргумент:
        // false - установка в несигнальное состояние.
        static AutoResetEvent auto = new AutoResetEvent(false);
        static void Main(string[] args)
        {

            Thread thread = new Thread(Function);
            thread.Start();
            Thread.Sleep(500); // Дадим время запуститься вторичному потоку.

            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");
            Console.ReadKey();
            auto.Set(); // Продолжение выполнения вторичного потока.

            Console.WriteLine("Нажмите на любую клавишу для перевода AutoResetEvent в сигнальное состояние.\n");
            Console.ReadKey();
            auto.Set(); // Продолжение выполнения вторичного потока.

            // Delay
            Console.ReadKey();
        }
        static void Function()
        {
            Console.WriteLine("Красный свет");
            auto.WaitOne(); // Остановка выполнения вторичного потока.

            Console.WriteLine("Желтый");
            auto.WaitOne(); // Остановка выполнения вторичного потока.

            Console.WriteLine("Зеленый");

            // СПРАВКА:
            // После завершения метода WaitOne() - AutoResetEvent автоматически переходит в несигнальное состояние.
        }
    }
}
