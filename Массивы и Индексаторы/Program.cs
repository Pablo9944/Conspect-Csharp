using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Массивы_и_Индексаторы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите размер массива: ");
            uint sizeMassive = uint.Parse(Console.ReadLine());

            int[] array = enterMassive(sizeMassive);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 20));

            int maxValue = MaxValue(array);
            Console.WriteLine($"Максимальное значение в массиве {maxValue}");

            Console.WriteLine(new string('-', 20));


            int minValue = MinValue(array);
            Console.WriteLine($"Минимальное значение в массиве {minValue}");

            Console.WriteLine(new string('-', 20));

            int sumElements = SumElements(array);
            Console.WriteLine($"Сумма элементов в массиве {sumElements}");
            
            Console.WriteLine(new string('-', 20));

            int ariphmetic = Ariphmetic(array);
            Console.WriteLine($"Среднее ариметическое значение {ariphmetic}");

            Console.WriteLine(new string('-', 20));

            OddNumbers(array);


           
        }

        /// <summary>
        ///  Заполняем массив
        /// </summary>
        /// <param name="sizeMassive"></param>
        /// <returns></returns>
        static int[] enterMassive(uint sizeMassive)
        {
            Random r = new Random();
            int[] array = new int [sizeMassive];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 10);
            }
            return array;
        }


        /// <summary>
        /// Максимальное значение в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int MaxValue(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }

        /// <summary>
        /// Минамальное значение в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int MinValue(int[] array) 
        {
            int minValue = array[0];
            int temp ;
           

            for (int i = 1; i < array.Length; i++)
            {

                if (minValue < array[i] || minValue > array[i])
                {
                    temp = array[i];
                    if (minValue > temp)
                    {
                        minValue = temp; 
                    }
                }
            }
            return minValue;


        }

        /// <summary>
        /// Сумма элементов в массиве
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int SumElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        /// <summary>
        /// Средне арифметическое значение
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int Ariphmetic(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }
          return  result = result / array.Length;
        }
       
        /// <summary>
        /// Нечётное значение
        /// </summary>
        /// <param name="arr"></param>
        static void OddNumbers(int [] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count++;
                }

            }
            int[] tempArray = new int[count];
            count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    tempArray[count++] = arr[i];
                }
            }

            foreach (var item in tempArray)
            {
                Console.WriteLine($"Нечётное значение {item}");
            }
        }

        

    }
}
