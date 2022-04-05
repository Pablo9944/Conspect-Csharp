using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Мы узнаем о

// 1. Cчитывании данных с консоли.
// 2. Генераторе псевдослучайных чисел.
// 3. Практическом применение логического типа.
// 4. Условном операторе (сокращенная форма).
// 5. Условном операторе (полная форма).
// 6. Условном операторе (каскады условий).

namespace _1._5_Способы_получения_данных_в_приложении__Смотри_описание_внутри_
{
    class Program
   
    {
        static void Main(string[] args)
        {
            # region 2 Генератор псевдослучайных чисел.
            Random randomize = new Random();
            int randomIntResult = randomize.Next(10);
            Console.WriteLine(randomIntResult);

            double randomDoubleResult = randomize.NextDouble();

            string dFormated = randomDoubleResult.ToString("0.00");
            Console.WriteLine(dFormated);

            #endregion

            #region Логический оператор if else-if - else
           int x = randomIntResult;
            if (x<5)
            {
                Console.WriteLine("x<5");
            }
            else
            {
                if (x>5)
                {
                    Console.WriteLine("x>5");
                }
                else
                {
                    Console.WriteLine("x=5");
                }
            }

            #endregion

        }
    }
}

#endregion