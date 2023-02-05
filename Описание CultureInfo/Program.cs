using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Описание_CultureInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Получаем все культуры
            CultureInfo[] cultureinfo = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (var c in cultureinfo)
            {
                Console.WriteLine(c.EnglishName + " | " + c );
            }

            Console.WriteLine(new string('-',20));

            // Получаем все культуры созданные пользователем
            cultureinfo = CultureInfo.GetCultures(CultureTypes.UserCustomCulture);
            foreach (var c in cultureinfo)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(new string('-', 20));

         
            
            

        }
    
    }
}
