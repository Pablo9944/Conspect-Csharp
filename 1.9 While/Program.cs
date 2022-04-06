using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



namespace _1._9_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool condition = false;
            //int i = -5;
            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                
                    Debug.Write(">>> ");
                    Debug.Write($"{i}");

                
            }
        }
    }
}
