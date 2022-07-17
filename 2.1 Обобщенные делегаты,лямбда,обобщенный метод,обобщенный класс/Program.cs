using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1_Обобщенные_делегаты_лямбда_обобщенный_метод_обобщенный_класс
{
    delegate R myDelegate<T, R>(T parametr);
    internal class Program
    {
       
        static void Main(string[] args)
        {
            myDelegate<string,string> mydelegate = (x) => x;
            Console.WriteLine(mydelegate("Hello"));

            All<string> all = new All<string>();
            int result = all.SHow(5);
            Console.WriteLine(result);

            All<int> allInt = new All<int>();
            allInt.Svoistvo = 5;
        }
    }

    class All <T>
    {
        public T Svoistvo { get; set; }

        public T SHow <T>(T value)
        {
            return value;
        }
    }
}
