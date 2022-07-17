using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3.Анонимные_методы_и_Лямбда_выражения
{
     delegate void Delstring(string data);
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var data = ApiService.GetData();

            // => - читает как "такое что"
            // анонимный метод 
            MyClass mc = new MyClass(data);
            mc.SetProcess(Show_1);
            mc.ActionProcess();

            //Delstring delstring = delegate (string message)
            //{
            //    Console.WriteLine(message);
            //};
            //delstring("Hello");

            //Show("Hello2", delstring);

            //Delstring delstring_2 = ((string message) =>
            //{
            //    Console.WriteLine(message);
            //});
            //Show("Hello2", delstring_2);

            //Delstring delstring_2 = (e =>
            //{
            //    Console.WriteLine(e);
            //});
            //Show("Hello2", delstring_2);


            Delstring delstring_2 = (e => Console.WriteLine(e));
            Show("Hello2", delstring_2);

            

        }
        static void Show_1(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Show(string Msg, Delstring de)
        {
            de(Msg);
            
        }
    }
    class MyClass
    {
       public string data;
       private Delstring del;
        public void SetProcess(Delstring delstring)
        {
            this.del = delstring;
        }

        public MyClass(string data)
        {
            this.data = data;
        }

        public void ActionProcess ()
        {
            del(data);
        }
       
    }

    class ApiService
    {
        public static string GetData()
        {
            string t = String.Empty;
            for (int i = 0; i < 10; i++)
            {
                t += Guid.NewGuid().ToString();
            }
            return t;
        }
    }
}
