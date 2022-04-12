using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Работа_с_файлами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = new DateTime(2022, 09, 28, 01, 30, 00);
            //Console.WriteLine(date);

            //Console.WriteLine(date.ToShortTimeString()); // получение только времени
            //Console.WriteLine(date.ToShortDateString()); // получение только даты

            //DateTime newDate = date.AddDays(10);         // прибавляет дни к текущему времени
            //Console.WriteLine(newDate);

            //TimeSpan span = newDate - date;              // получим результат разницы в датах
            //Console.WriteLine(span);
            //Console.WriteLine(span.TotalHours);          // получим разницу в часах


            #region string IndexOf
            string row = null;
            int result = 0;
            Console.WriteLine(row = ":, , ");
            result = row.IndexOf('П');
            Console.WriteLine(result);

            #endregion

            #region string Insert
            //Console.WriteLine(row.Insert(0, "C# "));


            #endregion

            Console.WriteLine(string.IsNullOrEmpty(row));
            Console.WriteLine(string.IsNullOrWhiteSpace(row));

            string[] myarray = "1 2 3 4,5 6;7 8 9 10".Split(' ',',',';');
            foreach (var item in myarray)
            {
                Console.Write(item);
            }
            string test = "sdcsdcsa";
            char[] array = test.ToCharArray();
            foreach (var item in array)
            {
                Console.WriteLine(char.IsLetter(item));
                Console.WriteLine(item);
            }

            string s = new string(array);
            Console.WriteLine(s);
            
        }



    }
}
