using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2._3_Рекурсия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NotInfinity(2);
            for (int i = 1; i < 25; i++)
            {

                //Console.WriteLine($"Fib({i,2}) = {Fib(i)} {Fib(i)}");
                

            }
            Console.WriteLine(Numbers(1234654));
        }
   
    
        public static string Numbers (int n)
        {
            return n < 10 ? n.ToString() :$"{Numbers(n / 10)} {n % 10}";
        }
        static int Fib (int N)
        {
            return (N == 1 || N == 2) ? 1 : Fib(N - 1) + Fib(N - 2);
        }

        static void Infinity ()
        {
            Console.WriteLine("O_- ");
            Thread.Sleep(100);
            Infinity();
            
        }

        static void NotInfinity(int Count)
        {
            Console.WriteLine("O_- ");
            Thread.Sleep(100);
            Count = Count - 1;
            if (Count > 0)
            {
                NotInfinity(Count);
            }
        }


    
    }
}
