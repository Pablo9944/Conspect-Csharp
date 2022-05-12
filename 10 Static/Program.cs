using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine(str.GetLastChar());

            Console.WriteLine("Строка".GetLastChar());
        }
    }

    /*Статические конструкторы не могут иметь модификатора доступа.
    Статические конструкторы не могут принимать параметры.
    Статические конструкторы не могут использовать нестатические поля (и не могут использовать и ключевое слово this).
    Статический конструктор невозможно вызвать в коде.
    Статический конструктор выполняется при первом создании экземпляра данного класса, либо при первом обращении к статическим членам класса.*/


    //Методы расширения (extension methods) позволяют добавлять новые методы в уже существующие типы без создания нового производного класса.
    //Метод расширения должен объявляться в статическом классе, обычно их называют по типу, которому будет относиться расширение, добавляя Extensions. Например, для расширения функциональностм типа int это может быть класс IntExtensions.
    static class StringExtensions
    {
        public static char GetLastChar(this string source)
        {
            return source[source.Length - 1];
        }
    }
}
