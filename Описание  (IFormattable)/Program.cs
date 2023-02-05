using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Описание___IFormattable_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Temperature t = new Temperature(10.5m);
            Console.WriteLine(t.ToString());

            Console.WriteLine("Temperature - {0:C}",t);
            Console.WriteLine("Temperature - {0:K}",t);
            Console.WriteLine("Temperature - {0:F}",t);

            // вариант 1
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Console.WriteLine(t.ToString("C", cultureInfo)); 

            // вариант 2
            Console.WriteLine(t.ToString("G", CultureInfo.CreateSpecificCulture("eu-US")));
            Console.WriteLine(t.ToString("G", CultureInfo.CreateSpecificCulture("ru-RU")));


        }
    }
    public class Temperature :IFormattable
    {
        private decimal temperature;
        public Temperature(decimal temperature)
        {
            if (temperature < -273.15m)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} не может быть ниже самой низкой температуры", temperature));
            }
            this.temperature = temperature; 
        }
        public decimal Celsius
        {
            get => temperature;
        }
            

        public decimal Fahrenheit
        {
            get => temperature * 9 / 5 + 32;
        }

        public decimal Kelvin => temperature + 273.15m;


        public override string ToString()
        {                                          // локальная культура ОС система
            return this.ToString("G",CultureInfo.CurrentCulture);
        }

        // Реализация IFormattable
        public string ToString(string format, IFormatProvider provider)
        {
            if (string.IsNullOrEmpty(format))
                format = "G";

            if (provider == null)
                provider = CultureInfo.CurrentCulture;


            switch (format.ToUpperInvariant())
            {
                case "G":
                case "C":
                    // F2 - формат вывода вещественного числа (2 знака после запятой)
                    return temperature.ToString("F2", provider) + "C";
                case "F":
                    return Fahrenheit.ToString("F2",provider) + "F";
                case "K":
                    return Kelvin.ToString("F2", provider) + "K";
                default: throw new FormatException(format);
                    
            }
            

        }
    }
 
    
}
