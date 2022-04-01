using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Форматированный_вывод
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Павел";
            string name1 = "Артем";
            string name2 = "Артур";
            
            string midlename = "Евгеньевич";
            string midlename1 = "Артемович";
            string midlename2 = "Артурович";

            string surname = "Юров";
            string surname1 = "Артемов";
            string surname2 = "Артуров";

            //конкатенация
            Console.WriteLine("конкатенация");
            Console.WriteLine(name + midlename + surname);
            Console.WriteLine("Имя: " + name + " Отчество: " + midlename + " Фамилия: " + surname);

            //форматированный вывод
            Console.WriteLine("\nформатированный вывод");
            Console.WriteLine("Имя: {0}, Отчество: {1}, Фамилия: {2}", name,midlename,surname);
            string pattern = "Имя: {0}, Отчество: {1}, Фамилия: {2}";
            Console.WriteLine(pattern,
                                name,
                                midlename,
                                surname);

            //интерполяция строк
            Console.WriteLine("\nинтерполяция строк");
            Console.WriteLine($"Имя: {name}, Отчество: {midlename}, Фамилия: {surname}");

            //вывод столбиком
            Console.WriteLine("\nвывод столбиком");
            Console.WriteLine($"{name,10} {midlename,10} {surname,10}");
            Console.WriteLine($"{name1,10} {midlename1,10} {surname1,10}");
            Console.WriteLine($"{name2,10} {midlename2,10} {surname2,10}");

            // сокращенный формат вывода

            Console.WriteLine("\nсокращенный формат вывода");
            double d = 1234546.654321;
            Console.WriteLine(d);

            string dFormated = d.ToString("#.###");
            Console.WriteLine(dFormated);
            Console.WriteLine("\n{0:0.000}");
            Console.WriteLine("{0:0.000}",d);

            Console.WriteLine("\n#.## ## ## ## ##");
            dFormated = d.ToString("#.## ## ## ## ## ");
            Console.WriteLine(dFormated);

            Console.WriteLine("\n### ####. ## ## ## ##");
            dFormated = d.ToString("### ###. ## ## ## ##");
            Console.WriteLine(dFormated);

            Console.WriteLine("\n{0:000 000 000.000 000 000}");
            Console.WriteLine("{0:000 000 000.000 000 000}",d);


        }
    }
}
