using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = MyClass<int>.FactoryMethod();
            Console.WriteLine(i.GetType().Name);

            TestClass tc = MyClass<TestClass>.FactoryMethod();
            Console.WriteLine(tc.GetType().Name);
        }
    }
    class TestClass
    {

    }
}
