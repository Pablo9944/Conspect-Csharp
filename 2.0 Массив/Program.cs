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
            
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            bool result = RemoveAt(ref arr, 3);


        

        

        //int[] myArray = { 1, 2, 4 };
        //myArray.GetLength(0);

        //int[] Arrays = { 1, 2, 4,4,5,6,7 };

        ////int[][] array = new int[3][];

        ////Array.Clear(myArray, 3, 2); // удалит с 3 индекса 2 эелемента
        //Array.ConstrainedCopy(myArray, 2, Arrays, 2, 2); // копирует из одного массива в другой
        //Array.Sort(Arrays); // сортирует массим


        //int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //int[,] array2 = new int[3, 3];
        //int count = 0;

        //for (int i = 0; i < array2.GetLength(0); i++)
        //{
        //    for (int j = 0; j < array2.GetLength(1); j++)
        //    {
        //        array2[i, j] = array1[count++];
        //        Console.Write($"\t{array2[i, j]} ");
        //    }
        //    Console.WriteLine();

        //}


        // массив массивов

        //int[][] myarray = new int[3][];
        //myarray[0] = new int[2];
        //myarray[0][0] = 1;
        //myarray[0][1] = 2;

        //myarray[1] = new int[3];
        //myarray[1][0] = 3;
        //myarray[1][1] = 4;
        //myarray[1][2] = 5;

        //myarray[2] = new int[4];
        //myarray[2][0] = 6;
        //myarray[2][1] = 7;
        //myarray[2][2] = 8;
        //myarray[2][3] = 9;

        //for (int i = 0; i < myarray.Length; i++)
        //{
        //    for (int j = 0; j < myarray[i].Length; j++)
        //    {
        //        Console.Write($"{myarray[i][j],5} ");
        //    }
        //    Console.WriteLine();
        //}

        Random r = new Random();
            
            int[][] arrayValue = new int[24][];

            for (int i = 0; i < arrayValue.Length; i++)
            {
                arrayValue[i] = (i >= 9 && i < 21) ? new int[12] : new int[4];
            }

            for (int i = 0; i < arrayValue.Length; i++)
            {
                Console.Write(i + "ч: ");
                for (int j = 0; j < arrayValue[i].Length; j++)
                {
                    arrayValue[i][j] = r.Next(1, 20);
                    Console.Write($"{arrayValue[i][j],5}");
                    
                }
                Console.WriteLine();
            }


            foreach (int [] item in arrayValue)
            {
                foreach (int  element in item)
                {
                    Console.Write(element );
                
                }
                Console.WriteLine();
            }

            char[] c = { '1', 'c', 'w', 'r', 's', 't' };

            string s = new string(c);

            Console.WriteLine(s);
        }
        #region Хороший пример
        static bool RemoveAt(ref int[] Col, int position)
        {
            bool result = false;
            if (position >= 0 && position <= Col.Length)
            {
                for (int i = position; i < Col.Length - 1; i++)
                {
                    Col[i] = Col[i + 1];
                }
                Array.Resize(ref Col, Col.Length - 1);
                result = true;

            }

            else
            {
                result = false;
            }

            return true;
        }
        #endregion

    }
}
