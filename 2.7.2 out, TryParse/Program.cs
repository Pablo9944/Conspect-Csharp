using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._2_out__TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Try.Parse

            Console.Write("Введите число: ");

            string input = Console.ReadLine();

            int.TryParse(input, out int result);

            Console.WriteLine(result + "\n");


            // out, Try.Parse and ?

            Console.Write("Введите число: ");

            bool checkInput = int.TryParse(Console.ReadLine(),out int resultCheck);

            Console.WriteLine(checkInput == false ? "Ввели не число" : resultCheck.ToString());







        }
    }
}
