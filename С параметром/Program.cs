using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace С_параметром
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart writesecond = new ParameterizedThreadStart(Writesecond);
            Thread thread = new Thread(writesecond);
            
            Box box = new Box() { value_1 = 1,value_2 = 2};
            thread.Start(box);
            Thread.Sleep(500);

            Console.WriteLine(box.sum_value);

            
           

        }
        static void Writesecond(object argument)
        {
            if (argument is Box box)
            {
                box.sum_value = box.value_1 + box.value_2;
                for (int i = 0; i < 1; i++)
                {
                    Console.Write($"\n{box.value_1} + {box.value_2} = ");
                    Thread.Sleep(1000);
                }
            }

         
        }
    }
    class Box
    {
        public int value_1;
        public int value_2;
        public int sum_value;
    }
}
