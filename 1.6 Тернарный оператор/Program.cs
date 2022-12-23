using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6_Тернарный_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ? тернарный оператор

            //Random r = new Random();
            //int value = r.Next();

            //int result = (value > 1) ? 0 : -1;
            //Console.WriteLine(result);

            //Console.WriteLine(value > 1 ? value : -1);
            //int a = 5, b = 2;
            //bool flag = a > b;
            //Console.WriteLine(flag ? "Да" : "Нет");

            #endregion

            #region ?? Оператор присваивания

            //string test = null;
            //string result = "Строка null";

            //Console.WriteLine(test ?? result);

            //MyClass myclass = new MyClass();

            //myclass.NameClass = "test";
            //Console.WriteLine(myclass.NameClass ?? (myclass.NameClass = "Какое-то имя"));


            #endregion

            #region ??= Оператор присваивания обьединения

            string test = null;
            test ??= "Отработал null";

            Console.WriteLine(test);

            #endregion


        }
    }
    class MyClass
    {
        public string NameClass;

    }
}
