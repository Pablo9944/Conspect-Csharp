using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._1_Методы__ref__in_
{
    internal class Program
    {
        // Параметр out обязательно необходимо вернуть из метода, то есть параметру обязательно нужно присвоить какое-либо значение.


        //Напишите объявление метода SumNumbers для суммирования четырех чисел, где: первое значение передается по ссылке и меняется,
        //второе значение передается по ссылке и не меняется,
        //третье значение является результатом суммирования двух первых и возвращается методом,
        //а четвертое значение является обычным параметром, и на него умножается результат метода.
        // int SumNumbers (ref int num1,in int num2,out int num3,int num4)



        static void Main(string[] args)
        {
            #region in (позволяет сделать так чтобы данные ссылочного типа ны выходе из  метода не изменялись)

            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(in arr);

            Console.WriteLine(arr[0]);

            #endregion


            #region Ссылочные локальные переменные
            int[] myArray = { 1, 2, 3, 4, 5 };
            ref int a = ref myArray[0];
            a = 666;

        #endregion
        }

        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }


        

       

    }





}
