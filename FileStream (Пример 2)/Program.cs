using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream__Пример_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 0; i < 256; i++)
            {
                fs.WriteByte((byte)i);
            }

            Console.WriteLine(fs.Position);
            // Переставляем позицию потока на 0
            fs.Position = 0;

            for (int i = 0; i < fs.Length; i++)
            {
                Console.Write(" " + fs.ReadByte());
            }

            fs.Close();
        }
    }
}
