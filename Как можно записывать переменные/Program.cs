using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Как_можно_записывать_переменные
{
    class Program
    {
        static void Main(string[] args)
        {
            int hexNumber = 0x7c6; // это 1990 в десятичной форме записи
            int binNumber = 0b11100; // это 28 в десятичной форме записи
            
            int number = 1_000_000_000;

            float floatVarible = 3.14f; // f - обязательно
            double doubleVarible = 3.14D; // D - не обязательно
            decimal decimalVarible = 3.14M; // M - обязательно
            Console.WriteLine(doubleVarible);

        }
    }
}
