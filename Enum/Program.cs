
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Enum
{
    class Program
    {
        // Enum - это некий список констант,под капотом которго целые числа
        enum DayofWeek // :byte  - изменели тип данных на byte (по умолчанию int)
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }

        static void Main(string[] args)
        {
            //var today = DateTime.Now.DayOfWeek;

            //while (true)
            //{
            //    ConsoleKey key = Console.ReadKey().Key;
            //    int keyCode = (int)key;

            //    Console.WriteLine($"\tEnum {key}\tKey Code {keyCode}");

            //    if (key == ConsoleKey.Q)
            //    {
            //        Console.WriteLine("Вы нажали 'Q'");
            //        break;
            //    }

            //}

            DayofWeek dayofweek = DayofWeek.Monday;
            Console.WriteLine(System.Enum.GetUnderlyingType(typeof(DayofWeek))); // тип данных у Enum

            Console.WriteLine(dayofweek);

            Console.WriteLine((int)dayofweek);// приводим dayofweek к int

            Console.WriteLine((DayofWeek)1); // приводим int к DayofWeek

            DayofWeek nextDay = GetnextDay(DayofWeek.Saturday);
            Console.WriteLine(nextDay);


            // isDefined - проверка наличии константы с указанном занчении в данном перечислении

            int value = 5;

            if (System.Enum.IsDefined(typeof(DayofWeek), value))  
                                                                   
            {
                dayofweek = (DayofWeek)value;
            }

            else
            {
                throw new Exception("Отсутсвует значение");
            }

            Console.WriteLine($"\n{dayofweek}");
            

           // GetValues - получение всех доступных значение в перечислении

           var values = System.Enum.GetValues(typeof(DayofWeek)); 
            foreach (var items in values)
            {
                Console.WriteLine(items); 
            }

            // Enum.Parse - enum можно парсить (ignoreCase: true - игнорировать регистр)

            string str = Console.ReadLine();
            //dayofweek = (DayofWeek)System.Enum.Parse(typeof(DayofWeek), str, ignoreCase: true);
            //Console.WriteLine(dayofweek);


            // Enum.TryParse
            bool result;

            result = System.Enum.TryParse(str, ignoreCase: true, out dayofweek);
            Console.WriteLine(dayofweek);

            // Быстрый доступ. Нажимаем s tab tab => вставляем переменную типа Enum => мышку в сторону клац-клац

            switch (dayofweek)
            {
                case DayofWeek.Monday:
                    break;
                case DayofWeek.Tuesday:
                    break;
                case DayofWeek.Wednesday:
                    break;
                case DayofWeek.Thursday:
                    break;
                case DayofWeek.Friday:
                    break;
                case DayofWeek.Saturday:
                    break;
                case DayofWeek.Sunday:
                    break;
                default:
                    break;
            }



        }

        static DayofWeek GetnextDay(DayofWeek day)
        {
            if (day < DayofWeek.Sunday)
                return day + 1;

            return DayofWeek.Monday;
        }

        
        
      
     
    
    }
}
