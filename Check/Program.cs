using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "Имя\t;Фамилия\t;Должность\t;Зарплата\t;Отдел\t";
            string path = @"D:\data.csv";


            Repository rp = new Repository(path);
            rp.AddTitle(title, new Worker("scsd", "sdfsdsd", "sdfsd", 0, "sacascas"));
            








        }
    }
}
