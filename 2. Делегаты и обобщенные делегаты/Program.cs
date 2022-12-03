using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace _2.Делегаты_и_обобщенные_делегаты
{
    
    
    internal class Program
    {
        delegate void Del();
        delegate void Delegates<T>(T args);
        delegate R myDelegate<T, R>(T parametr);
        static void Main(string[] args)
        {
            myDelegate<string> myDelegate = (x) => x;
            Console.WriteLine(myDelegate("Hello"));

            Del del = Print_1;
            del?.Invoke();

            Delegates <string>delegates = Print_2;
            delegates?.Invoke("Hello");

            // Action только для void делегатов
            Action<string> action = Print_2;
            action?.Invoke("sdfsd");

            // Func для возвращаемых типов
            Func<string,string> func = Return3;
            func?.Invoke("Hello");


            //Predicate для bool
            Predicate<int> predicate = Return4;
            predicate.Invoke(3);
            

        }
    
        static void Print_1()
        {
            Console.WriteLine("Вызвал метод через делегат");
        }
        static void Print_2(string text)
        {
            Console.WriteLine("Вызвал метод через обобщенный делегат");
        }

        static string Return3(string message) 
        {
            Console.WriteLine(message);
            return message; 
        }

        static bool Return4(int number)
        {
            Console.WriteLine("Обобщенный делегат Predicate");
            return number > 0;
        }
    }
}
