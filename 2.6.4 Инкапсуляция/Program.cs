using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._4_Инкапсуляция
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer1 c = new Computer1();
            
            for (int i = 0; i < 3; i++)
            {
                c.Power();
                Console.WriteLine(c.Indicator);
            }
        }

    }
}
