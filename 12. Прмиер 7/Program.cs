using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Прмиер_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4}");

            MatchCollection collection = regex.Matches("русский edu@cbsystematics.com текст123ещерусскийsupport@cbsystematics.comтекст");

            foreach (Match element in collection)
            {
                Console.WriteLine("{0,-25}  на {1,-3} позиции.", element.Value, element.Index);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
