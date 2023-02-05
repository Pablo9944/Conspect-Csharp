using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream__Описание_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"1.txt";
            FileInfo file = new FileInfo(path);

            FileStream fs = file.Create();
           // FileStream fs = new FileStream(path,FileMode.OpenOrCreate);
        }
    }
}
