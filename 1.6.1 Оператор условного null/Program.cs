using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1_Оператор_условного_null
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ?.

            int[] myArray = GetArray();
            Console.WriteLine("Cумма элементов в массиве = " +  (myArray?.Sum() ?? TrueArray().Sum()));

            Console.WriteLine();

        

            #endregion
        }
        static int[] GetArray()
        {
            int[] myArray = null; 
            //int[] myArray = { 1, 2, 3 };
            
            return myArray;
        }

        static int[] TrueArray()
        {
            int[] myArray = { 1, 2, 3 };
            return myArray;
        }
       
     
    }

}
