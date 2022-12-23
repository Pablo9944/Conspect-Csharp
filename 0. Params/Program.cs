using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystruct ms = new Mystruct{ a = 1,b = 2, c = 3, d = 4 };

            Print(ref ms, ms.a, ms.b, ms.c, ms.d);
            Console.WriteLine();
            string test = PrinTwo(1, "текст", ms, '!', 2.6f);
            Console.WriteLine();
            Console.WriteLine(test);
            


        }

        static void Print( ref Mystruct ms, params int[] pr  )
        {
            int result = 0;
            foreach (var item in pr)
            {
                result += item;
            }
            Console.WriteLine(result);
        }

        static string PrinTwo (params object[] obj)
        {
            string test = string.Empty;

            foreach (var item in obj)
            {
                test += item;
                Console.WriteLine($" {item,10} | {item.GetType(),10}");
            }
            return test;


        }
    }

    struct Mystruct
    {
       public int a;
       public int b;
       public int c;
       public int d;
    }
}
