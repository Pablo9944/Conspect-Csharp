using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12._1_Бинарный_данные_пример
{
    internal class Program
    {
        const string path = @"C:\Users\peyur\OneDrive\Рабочий стол\Students.dat";
        static void Main(string[] args)
        {
            
            //WriteValues();
            ReadValues();
        }

        //static void WriteValues()
        //{
        //    using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
        //        writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
        //}

        static void ReadValues()
        {
            string StringValue;

            if (File.Exists(path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    StringValue = reader.ReadString();
                }

                Console.WriteLine(StringValue);
            }


        }
    }
}
