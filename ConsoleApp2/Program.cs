using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        delegate void MyDelegate(string @string);

        static void Main(string[] args)
        {
            #region Анонимные типы

            //var instance = new { Name = "Alex", Age = 27 };
            //Type type = instance.GetType();
            //Console.WriteLine(type.Name);


            //var instance2 = new { My = new MyClass() { field = 1 } };
            //instance2.My.field = 666;
            //instance2.My.Show();


            #endregion

            #region Анонимные типы по слабой ссылке

            //new { My = new MyClass { field = 777 } }.My.Show();

            #endregion

            #region  Анонимный тип с делегатом
            //var instance3 = new {MyDel = new MyDelegate((string str) => Console.WriteLine(str)) };
            //var instance4 = new { MyDel = new MyDelegate(x => Console.WriteLine(x))};
            //instance4.MyDel.Invoke("sss");
            #endregion

        }
 
    }
    class MyClass
    {
        public int field;
        public void Show()
        {
            Console.WriteLine(field);
        }
      
    }
}
