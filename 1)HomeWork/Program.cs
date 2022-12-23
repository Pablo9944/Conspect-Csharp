using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserSpath = @"D:\Users.csv";

            
            using (StreamWriter sw = new StreamWriter(UserSpath, true, Encoding.Unicode))
            {
                int id = 1;
                
                char key = 'д';
                do
                {

                    string temp = String.Empty;
                    temp += $"{Convert.ToString(id)}\t";    // ID
                    id++;

                    temp += $"{DateTime.Now}\t";            // Date and Time
                   

                    Console.Write("Укажите фамилию: ");
                    temp += $"{Console.ReadLine()}";
                   
                    Console.Write("Укажите имя: ");
                    temp += $"{Console.ReadLine()}";
                    
                    Console.Write("Укажите отчество: ");
                    temp += $"{Console.ReadLine()}\t";

                    Console.Write("Укажите возраст: ");
                    temp += $"{Console.ReadLine()}\t";

                    Console.Write("Укажите рост: ");
                    temp += $"{Console.ReadLine()}\t";

                    Console.Write("Укажите дату рождения в формате dd.mm.yyyy: ");
                    temp += $"{Console.ReadLine()}\t";

                    Console.Write("Укажите место рождения: ");
                    temp += $"{Console.ReadLine()}\t";

                    sw.WriteLine(temp);
                    Console.Write("Для продолжения заполнения нажмите 'н' или 'д': " + Environment.NewLine);
                    key = Console.ReadKey(true).KeyChar;
                  

                } 
                while (char.ToLower(key) == 'д');
              
            }
        }
    }
}
