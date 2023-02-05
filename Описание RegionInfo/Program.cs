using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Описание_RegionInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получаем информацию о текущем регионе
            RegionInfo regionInfo = RegionInfo.CurrentRegion;
            Console.WriteLine(regionInfo.EnglishName);
            Console.WriteLine(regionInfo.NativeName);

            Console.WriteLine(new string('-',20));

            Console.WriteLine(regionInfo.CurrencySymbol);
            Console.WriteLine(regionInfo.CurrencyEnglishName);
            Console.WriteLine(regionInfo.CurrencyNativeName);

            Console.WriteLine(new string('-', 20));


            string[] days = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;
            
            Console.WriteLine("Дни недели: ");

            foreach (string s in days)
            {
                Console.WriteLine("-> " + s);
            }

            Console.WriteLine(new string('-', 20));

            string[] euDays = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.DayNames;
            Console.WriteLine("Дни недели: ");

            foreach (string s in euDays)
            {
                Console.WriteLine("-> " + s);
            }

            



        }
    }
}
