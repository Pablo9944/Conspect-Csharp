using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AttributeWork__Описание_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
           // MyClass.Method();

            Type t = my.GetType();

            Console.WriteLine("Получаем attribute classes");
            var attr = t.GetCustomAttributes();
            foreach ( MyAttribute a in attr) 
            {
                Console.WriteLine(a.Date + " " + a.Number );
            }

            Console.WriteLine(new string('-',20));
            Console.WriteLine("Получаем метод класса");

            MethodInfo methods = t.GetMethod("Method",BindingFlags.Static | BindingFlags.Public);
            Console.WriteLine(methods.Name);

            Console.WriteLine(new string('-', 20));
            
            var attributes = methods.GetCustomAttributes(typeof(MyAttribute),false);
            Console.WriteLine("Получаем attribute Methods");
            
            foreach ( MyAttribute a in attributes)
            {
                Console.WriteLine(a.Date + " " + a.Number);
            }

            // Delay.
            Console.ReadKey();
        }
    }
    [My("1/31/2008", Number = 1)]
    public class MyClass
    {
        [MyAttribute("2/31/2007", Number = 2)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()\n");
        }
    }
}
