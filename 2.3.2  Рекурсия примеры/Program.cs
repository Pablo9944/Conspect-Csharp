using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._2__Рекурсия_примеры
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Вывод массива через рекурсию

            int[] myArray = { 1, 2, 3 };
            Print(myArray);
            Console.WriteLine();

            #endregion

            #region Посчитать сумму чисел в массиве

            int[] arraySum = { 1, 2, 3 };
            int result = Sum(arraySum);
            Console.WriteLine(result);
            Console.WriteLine();

            #endregion

            #region Найти сумму числа спомошью рекурсии

            int myValue = 561;
            result = Foo(myValue);
           

            #endregion
        }


        #region Вывод массива через рекурсию

        static void Print(int[]array, int i = 0)
        {
            if (i< array.Length)
            {
                Console.WriteLine(array[i]);
                Print(array, i + 1);
            }
        }
        #endregion

        #region Посчитать сумму чисел в массиве

        static int Sum(int[] array,int i=0)
        {
            if (i>= array.Length)
            return 0;
                
            int result = Sum(array, i + 1);
            return array[i] + result;
        }

        #endregion

        #region Найти сумму числа спомошью рекурсии

        static int Foo(int value)
        {
            if (value < 10)
                return value;

            int digit = value % 10;
            int nextValue = value / 10;
            return digit + Foo(nextValue);
        }


        #endregion
    }

}
