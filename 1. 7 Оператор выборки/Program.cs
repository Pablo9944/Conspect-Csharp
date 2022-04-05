using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7_Оператор_выборки
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели: ");
            int day = int.Parse(Console.ReadLine());
            Random r = new Random(0);
            int value = r.Next(10);
            switch ((DayOfWeek)day)
            {
                case DayOfWeek.Sunday:

                    break;
                case DayOfWeek.Monday:

                    break;
                case DayOfWeek.Tuesday:

                    break;
                case DayOfWeek.Wednesday:

                    break;
                case DayOfWeek.Thursday:

                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine(DayOfWeek.Friday);

                    break;
                case DayOfWeek.Saturday:

                    break;
                default:
                    Console.WriteLine("В неделе 7 дней,а вы указали хуйню");
                    break;
            }

            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4: Console.WriteLine(value);break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9: Console.WriteLine(value);break;
                
                    
            }
        }
    }
}
