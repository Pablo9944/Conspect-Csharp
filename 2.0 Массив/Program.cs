using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_Массив
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = { 1, 2, 4 };
            myArray.GetLength(0);
            
            int[] Arrays = { 1, 2, 4,4,5,6,7 };

            //int[][] array = new int[3][];

            //Array.Clear(myArray, 3, 2); // удалит с 3 индекса 2 эелемента
            Array.ConstrainedCopy(myArray, 2, Arrays, 2, 2); // копирует из одного массива в другой
            Array.Sort(Arrays); // сортирует массим

        }
    }
}
