using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_Методы__params_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(777,6,4,3,2,1,2,3,4,5);
            Console.WriteLine(result);
           
        }
    
    


        static int Sum (params int[] array)
        {
            int result = 0;

            foreach (var item in array)
            {
                result += item;
            }
            return result;
        }
    }
}
