using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Пример_CultereInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 123.45;

            var american = new CultureInfo("en-US");
            var russian = new CultureInfo("ru-RU");

            string localMoney = money.ToString("C",american);
            Console.WriteLine(localMoney);

            localMoney = money.ToString("C", russian);
            Console.WriteLine(localMoney);

           
            
        }
    }
}
