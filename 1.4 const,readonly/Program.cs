using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_const_readonly
{
    class Program
    {
        static void Main(string[] args)
        {
            // const - 1) является неявным статическим  
            //         2) при обьявлении нужно сразу вносить значение,которое потом не получится изменить


            // readonly - 1) не я вляется неявно статическим, но можно сделать явно статическим 
            //            2) можно обьявлять без значения
            //            3) значение заносится или в момент создания или в конструкторе  
            //            4) изменить не получится
                         
            MyClass myclass = new MyClass(666);
            myclass.Foo();
            Console.WriteLine(DateTime.Now);

        }

        class MyClass
        {
            public const string MY_ERROR = "some error";
            public readonly int _a;
            public static readonly int _b;
            
            public MyClass(int a)
            {
                _a = a;
            }

            static MyClass() 
            {
                _b = 888;
            }
            public void Foo ()
            {
                
                Console.WriteLine(MY_ERROR);
                Console.WriteLine(_a);
                Console.WriteLine(_b);
                
            }
        }
    }
}
