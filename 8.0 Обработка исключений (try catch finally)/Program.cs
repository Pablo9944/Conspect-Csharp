using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._0_Обработка_исключений__try_catch_finally_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OverflowException ovex = new OverflowException("Помните что вы можете использоваться числа до 255");
            ovex.HelpLink = "https://go.skillbox.ru/education/course/weblayout";
            int x = 0;
            metka:
            try
            {
                Console.Write("Введите число: ");
                x = int.Parse(Console.ReadLine());
                if (x > 255)
                {
                  throw ovex;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Вы указали неверное значение,введите цифры FormatException");
                Console.WriteLine(e.TargetSite);
                goto metka;
                
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(" Оно не должно первышать 255 OverflowException помощь на" + e.HelpLink);
                Console.WriteLine(e.StackTrace);
            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("finally выполняется всегда");
            }
        }
    }
}
