using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Пример_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            // Деструктор невозможно вызвать вручную.
            // Вызывается автоматически сборщиком мусора.
            // my.~MyClass();
        }
    }
    class MyClass
    {
        // Destructor (Метод Finalize)
        ~MyClass()
        {
            Console.WriteLine("Hello from Destructor!");

            // Например: Закрыть соединение с Базой Данных.
        }
    }
}
