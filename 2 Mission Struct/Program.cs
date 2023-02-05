using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Mission_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Train train = new Train();

            for (int i = 0; i < 3; i++ )
            {
                train[i] = new Train() 
                {
                    IDTrain = EnterIdTrain(),
                    NameStop = EnterNameStop(),
                    TimeGo = DateTime.Now};
                }

            for (int i = 0; i < train.Length(); i++)
            {
                Console.WriteLine(train[i, " "]);
            }
        }
        static string EnterNameStop()
        {
            Console.Write("Введите название остановки: ");   
            string str = Console.ReadLine();
            return str;
        }
        static int EnterIdTrain()
        {
            Console.Write("Введите название поезда: ");
            return int.Parse(Console.ReadLine());
        }

     
    }
}
