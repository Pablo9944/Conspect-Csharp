using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel.For
{
    internal class Program
    {
        static int[] arr;

        static void Fill(int i)
        {
            arr[i] = i / 1000;
        }

        static void Main(string[] args)
        {
            arr = new int[500_000_000];

            var t = DateTime.Now;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i / 1000;
            }

            Console.WriteLine((DateTime.Now - t).TotalMilliseconds);


            Console.ReadLine();

            t = DateTime.Now;

            System.Threading.Tasks.Parallel.For(0, arr.Length, Fill);

            Console.WriteLine((DateTime.Now - t).TotalMilliseconds);

            
        }
    }
}
