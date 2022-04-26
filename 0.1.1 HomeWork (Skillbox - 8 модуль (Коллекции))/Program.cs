using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1._1_HomeWork__Skillbox___8_модуль__Коллекции__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1. Работа с листом 

            /* Создайте лист целых чисел. 
           Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
           Выведите коллекцию чисел на экран. 
           Удалите из листа числа, которые больше 25, но меньше 50. 
           Снова выведите числа на экран.*/


            List l = new List();
            l.Print();
            Console.WriteLine($"Остаток = {l.Count}");
            Console.ReadKey();
            Console.WriteLine();

            Console.Clear();
            l.Remove();
            l.Print(); 
            Console.WriteLine($"Остаток = {l.Count}");
            Console.ReadKey();




            #endregion
        }
    }
}
