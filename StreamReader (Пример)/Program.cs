using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader__Пример_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileStream fs = new FileStream("sr.txt", FileMode.OpenOrCreate);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine($"Строка - {i}");
                }
            }

            fs = new FileStream("sr.txt", FileMode.OpenOrCreate);


            using (StreamReader sr = new StreamReader(fs))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Console.Write(" " + line);
                }
            }


            //// Другой вариант считывать
            //StreamReader sr_2 = new StreamReader("sr.txt");
            // читаем до конца
            //Console.WriteLine(sr_2.ReadToEnd());
            //sr_2.Close();
        }
    }
}
