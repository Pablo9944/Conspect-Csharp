using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Пример_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру: ");
            string path = @"\D";
            Regex r = new Regex(path);

            while (true)
            {
                if (r.IsMatch(Console.ReadKey().KeyChar.ToString()))
                {
                    Console.Clear();
                    
                }
            }
           
        }
    }
}
