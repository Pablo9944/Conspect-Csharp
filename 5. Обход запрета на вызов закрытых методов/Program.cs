using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _5.Обход_запрета_на_вызов_закрытых_методов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeCalss SC =new SomeCalss();
            Type t = SC.GetType();
            MethodInfo mI = t.GetMethod("Method",BindingFlags.Instance | BindingFlags.NonPublic);
            mI.Invoke(SC, null);
        }
    }

    class SomeCalss
    {
        void Method()
        {
            Console.WriteLine("Работакет закрытый метод");
        }
    }
}
