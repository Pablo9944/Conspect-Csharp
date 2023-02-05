using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Описание
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    struct MyStruct
    {
        // В структурах недопустимо создавать деструкторы.
        //~ MyStruct()
        //{

        //}
    }

    class MyClass
    {
        // Деструкторы не могут иметь аргументов.

        //~ MyClass(int arg)
        //{

        //}

        // Деструкторы не могут быть статичесикими.
        //static ~ MyClass()
        //{

        //}

        // Деструкторы не могут иметь модификаторов доступа.

        //public ~ MyClass()
        //{

        //}
    }
}
