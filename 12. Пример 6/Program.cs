using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Пример_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // | - символ для указания вариантов шаблона (ИЛИ). 
            string pattern = "test|str|aaaa";

            var array = new string[4];
            array[0] = "some text with test in it";
            array[1] = "some text with str in it";
            array[2] = "some text with aaaa in it";
            array[3] = "some text with nothing in it";

            var regex = new Regex(pattern);

            foreach (string element in array)
            {
                if (regex.IsMatch(element))
                    Console.WriteLine("Строка \"{0}\" соответствует шаблону \"{1}\"", element, pattern);
                else
                    Console.WriteLine("Строка \"{0}\" НЕ соответствует шаблону \"{1}\"", element, pattern);
            }


          


            // Delay.
            Console.ReadKey();
        }
    }
}
