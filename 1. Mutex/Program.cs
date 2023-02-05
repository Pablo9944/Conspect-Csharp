using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Использование Mutex для синхронизации доступа к защищенным ресурсам.

// Mutex - Примитив синхронизации, который также может использоваться 
// в межпроцессной и междоменной синхронизации.
// MutEx - Mutual Exclusion (Взаимное Исключение).

namespace _1.Mutex_Описание
{

    internal class Program
    {
        // Mutex - Примитив синхронизации, который также может использоваться в межпроцессорной синхронизации.
        // функционирует аналогично AutoResetEvent но снабжен дополнительной логикой:
        // 1. Запоминает какой поток им владеет. ReleaseMutex не может вызвать поток, который не владеет мьютексом.
        // 2. Управляет рекурсивным счетчиком, указывающим, сколько раз поток-владелец уже владел объектом.
        
        
        //static Mutex mutex = new Mutex(); // Отсутствует межпроцессная синхронизация. // 20 слайд. "У каждого процесса свой "турникет" без имени"
        static Mutex mutex = new Mutex(false, "MyMutex"); // 19 слайд. Каждый процесс обращается к 1 "Турникету по "имени""
        
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];

            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Function);
                threads[i].Name = i.ToString();
                Thread.Sleep(500); // Потоки из разных процессов успеют стать в очередь вперемешку.
                threads[i].Start();
            }

            // Delay
            Console.ReadKey();
        }

        // Описание: Если запустить к примеру  3 exe файла данного кода программу, то будет выполнятся всё равно по очереди в 1 поток
        // каждый процесс будет ждать завершения другого процесса.Запусти 3 exe и посмотри
        static void Function()
        {
            // Выполняется в 1 поток, остальные потоки все ждут. ВЫПОЛНЕНИЕ В 1 ПОТОК
            mutex.WaitOne(); // "Зашли на турникет +1 и закрыли мост"

            Console.WriteLine("Поток {0} зашел в защищенную область.", Thread.CurrentThread.Name);
            Thread.Sleep(2000);
            Console.WriteLine("Поток {0}  покинул защищенную область.\n", Thread.CurrentThread.Name);

            mutex.ReleaseMutex(); //"Человек прошёл, открываем турникет  "
        }
    }
}
