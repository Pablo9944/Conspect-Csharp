using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;

namespace _3.Рефлексия
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region создаем ссылку на тип

            //// вариант №1
            //Type t = typeof(short);
            //Console.WriteLine(t);

            //// вариант №2
            //byte b = 10;
            //t = b.GetType();
            //Console.WriteLine(t);

            //// вариант №3
            //t = Type.GetType("System.Int32");
            //Console.WriteLine(t);

            #endregion


            Type t = typeof(SomeClass);
            ShowMetaData(t);

        }

        static void ShowMetaData (Type t)
        {
            SortedList classInfo = new SortedList();
            if (t.IsAbstract)
            {
                classInfo["isAbstract"] = "is Abstract";
            }

            else
            {
                classInfo["isAbstract"] = "is not Abstract";
            }

            if (t.IsValueType)
            {
                classInfo["IsValueType"] = "Is ValueType";
            }

            else
            {
                classInfo["IsValueType"] = "Is not ValueType - referance type";
            }

            classInfo["baseType"] = t.BaseType.Name;

            Console.WriteLine("class {0} {1} and {2} and Base class = {3} ", 
                                        t.Name, classInfo["isAbstract"],classInfo["IsValueType"],classInfo["baseType"]);

            FieldInfo[] f = t.GetFields();
            Console.WriteLine("\nПолучаем поля");
            foreach (FieldInfo fi in f)
            {
                Console.WriteLine(fi.Name);
            }

            PropertyInfo[]p = t.GetProperties();
            Console.WriteLine("\nПолучаем свойства");
            foreach (PropertyInfo pi in p)
            {
                Console.WriteLine(pi.Name);
            }

            MemberInfo[] m = t.GetMethods();
            Console.WriteLine("\nПолучаем методы");
            foreach (MemberInfo mi in m)
            {
                Console.WriteLine( mi.Name);
            }

            Type[] i = t.GetInterfaces();
            Console.WriteLine("\nПолучаем интерфейсы");
            foreach (var item in i)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    interface ISomeInterface
    {
        string SomeMethod(bool flag);
    }
    class BaseClass
    {
        public bool flag;
    }
    class SomeClass : BaseClass, ISomeInterface
    {
        public int i;

        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public string SomeMethod(bool flag)
        {
            return flag.ToString(); 
        }
    }
}
