using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _4._1_Пример_использования_dll
{
    internal class Program
    {
        const string ASSEMBLY = "MyLibrary";
        const string ERROR_ASSEMBLY_EXIST = "Не получилось подключить сборку";
        const string FULL_NAME_OF_TYPE = "MyLibrary.MyClass";
        const string ERROR_TYPE_EXIST = FULL_NAME_OF_TYPE + " не найден";

        static void Main(string[] args)
        {
            Assembly ass;
            try
            { 
            // сборка (Загрузка библиотеки)
            ass = Assembly.Load(ASSEMBLY);
            }
            catch 
            {
                Console.WriteLine(ERROR_ASSEMBLY_EXIST);
                return;
            }


            Type myClass;
            try
            {
                // вытягивание информации о типе
                myClass= ass.GetType(FULL_NAME_OF_TYPE);
                if (myClass == null)
                {
                    throw new Exception(ERROR_TYPE_EXIST);    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            // Создание обьекта нового класса
            object instance = Activator.CreateInstance(myClass);

            MethodInfo[] m = myClass.GetMethods();
            foreach (var item in m)
            {
                Console.WriteLine(item.Name);
            }

            // получение метаданных по интересующим нас методе
            MethodInfo mi = myClass.GetMethod("Show");

            //пытаться вызвать метод
            object[] parametrs = { "Привет", 5 };
                              // если метод не принимает значение то указываем null
            mi.Invoke(instance, parametrs);

            
        }
    }
}
