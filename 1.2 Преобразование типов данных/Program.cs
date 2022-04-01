using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_Преобразование_типов_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Не явное преобразование
            
            int a = 300;
            double b = a;

            //Явное преобразование
            byte c = (byte)a; // ошибки не будет
            //byte f = checked((byte)a); // checked - сделает проверку,если будет переполнение то будет ошибка.

            double d = 1.2;
            byte e = (byte)d;
            int g = (byte)d;

            //Parse - позволяет конвертировать строковые в числовые

            string inputString = "2029";
         // int intValue = inputString; // ошибка
            int intValue = int.Parse(inputString); // 2029
            

            double doubleValue = double.Parse(inputString);
            ulong ulongValue = ulong.Parse(inputString);
            byte byteValue = byte.Parse(inputString); // ошибка
            
            //TryParse
            
            bool result = byte.TryParse(inputString, out byteValue);
            Console.WriteLine(result);

            // Convert - позволяет конвертировать данные любого типа в данные любого типа
            long m = Convert.ToInt64(inputString);
            Console.WriteLine(m);

        }
    }
}
