using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Лямбда_выражения
{
    internal class Program
    {
        delegate int Operation(int x, int y);
        delegate int Square(int x);
        delegate void Hello();
        static void Main(string[] args)
        {
            #region Построение лямбды
            // 1)список параметров 2) лямбда оператор 3) действие которое должно выполняться
            //           () => .....
            //
            #endregion

            Operation operation = (x,y) => x + y;
            Square square = x => x * x;
            Hello hello = () => Console.WriteLine("Hello");
            Hello hello_2 = () => Console.WriteLine("Welcome");

            Console.WriteLine(operation(1,2));
            Console.WriteLine(square(5));
            hello();
            hello_2();


        }
    }
}
