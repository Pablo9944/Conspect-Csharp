using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary__Mission_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myD = new MyDictionary<int, string>();
            myD.Add(1, "один");
            myD.Add(2, "два");
            myD.Add(3, "три");

            for (int i = 0; i < myD.Length; i++)
            {
                Console.WriteLine(myD[i]);
            }
            Console.WriteLine(new string('-',20));
            //Console.WriteLine(myD.GetValue(1));
            myD.Add(34, "тритри");

            for (int i = 0; i < myD.Length; i++)
            {
                Console.WriteLine(myD[i]);
            }
        }

    }
}
