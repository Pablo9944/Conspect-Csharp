using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1.Mission
{
    internal class Program
    {
        //delegate int Add(int x, int y);
        //delegate int Sub(int x, int y);
        //delegate int Mul(int x, int y);
        //delegate int Div(int x, int y);

        delegate int Mydelegate(Mydelegate2[] md2);
        delegate int Mydelegate2();
        
        static void Main(string[] args)
        {
            //Add add = (x,y) => x+y;
            //Sub sub = (x,y) => x-y;
            //Mul mul = (x,y) => x*y;
            //Div div = (x,y) => x/y;


            //Console.WriteLine("Сложение");
            //Console.WriteLine(add.Invoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine(new string(('-'), 20));

            //Console.WriteLine("Вычитание");
            //Console.WriteLine(sub.Invoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine(new string(('-'), 20));

            //Console.WriteLine("Умножение");
            //Console.WriteLine(mul.Invoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine(new string(('-'), 20));

            //Console.WriteLine("Деление");
            //Console.WriteLine(div.Invoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
            //Console.WriteLine(new string(('-'), 20));


            //Console.WriteLine("Среднеарифметическое значение");
            //Func<int, int, int, int> f = (x, y, z) => (x + y + z) / 3;

            //Console.WriteLine(f.Invoke(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            Mydelegate2[] md = new Mydelegate2[5];
            

            Mydelegate mydelegate = delegate (Mydelegate2[] md2)
            {
                int temp = 0 ;
                for (int i = 0; i < md.Length; i++)
                {
                   temp += (md[i] = delegate
                    {
                       return GetRandomInt();
                    }).Invoke();
                 
                }
                return temp/ md.Length;
            };

            Console.WriteLine(mydelegate.Invoke(md));

        }

        static int GetRandomInt()
        {
            Random r = new Random();
            return r.Next(100);
        }
    }
}
