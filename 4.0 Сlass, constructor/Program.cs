using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._0_Сlass__constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass { name = "Иван", age = 15 };
            Console.WriteLine(my.name +" "+  my.age);


            #region Условный оператор ?.
            //данный оператор нельзя применять со значимыми типами, поскольку они не могут хранить значение null.То есть такой код выдаст ошибку компиляции:
            MyClass my1 = null;
            Console.WriteLine(my1?.name);

            #endregion

            #region  оператор null-объединения ??
            // данный оператор нельзя применять со значимыми типами, поскольку они не могут хранить значение null. То есть такой код выдаст ошибку компиляции
            MyClass my2 = null;
            MyClass newmy2 = my2 ?? new MyClass { name = "Артем", age = 666 };
            Console.WriteLine(newmy2.name + " " + newmy2.age);


            int[] arr = null;
            int[] newArr = arr ?? new int[] { 1, 2, 3, 4, 5 };

            #endregion

            #region int? HasValue
            Bus bus = new Bus();
            bus.Load = 0;
            bus.PrintStatus();
            #endregion


        }
    }

    class MyClass
    {
       public string name;
       public int age;
    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue)
            {
                Console.WriteLine(Load.Value);
            }

            else
            {
                Console.WriteLine("Пассажиров нет");
            }
        }
    }
}
