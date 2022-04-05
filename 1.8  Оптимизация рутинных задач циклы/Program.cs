using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8__Оптимизация_рутинных_задач_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.Write("Укажите сколько сгенерировать случайных чисел: ");
            int count = int.Parse(Console.ReadLine());


            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine("{0} - случйное число {1}",i,r.Next(-8,10));
            }
            //for(;;) выполняет бесконечное кол-во раз
            for (; ; )
            {
                // чтобы выйти нужно break;
            }
            int a = 5, b = 7;
            for (;a!=b;)
            {

            }
           
        }
    }
}
