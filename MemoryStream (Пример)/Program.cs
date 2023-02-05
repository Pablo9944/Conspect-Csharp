using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStream__Пример_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MemoryStream ms = new MemoryStream();
            
            // выделяем длину потока
            ms.Capacity = 256;

            for (int i = 0; i < 256; i++)
            {
                ms.WriteByte((byte)i);
            }
           
            ms.Position = 0;

            byte[] array = ms.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

            Console.WriteLine(new string('-',20));

            FileStream fs = new FileStream("MemoryTest.txt", FileMode.Create, FileAccess.ReadWrite);

            // Записываем данные из ОЗУ в файл
            ms.WriteTo(fs);
           

            Console.WriteLine("Выводим из файла");
            fs.Position = 0;

            for (int i = 0; i < fs.Length; i++)
            {
                Console.Write(" " + fs.ReadByte());
            }

            ms.Close();
            fs.Close();

        }
    }
}
