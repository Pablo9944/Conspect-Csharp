using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 7, 5, 0 };
            array.Sort();

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        
    }
     static class Test
    {
       public static int[] Sort(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length-1; j > i; j--)
                {
                    if (array[i] < array[j])
                    {
                        int x = array[j];
                        array[j] = array[i];
                        array[i] = x;
                    }
                }
            }
            return array;
        }
    }
}
