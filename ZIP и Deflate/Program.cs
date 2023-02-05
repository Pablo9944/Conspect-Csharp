using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIP_и_Deflate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"test.txt";
            FileStream source = File.Open(path, FileMode.OpenOrCreate);
            FileStream destination = File.Create("test.zip");

            // Создание компрессора
            GZipStream compressor = new GZipStream(destination, CompressionMode.Compress);

            
            // Заполнение архива информацией из файла
            int theByte = source.ReadByte();

            while (theByte != -1)
            {
                compressor.WriteByte((byte)theByte);

                theByte = source.ReadByte();
                
            }
            compressor.Close();
        }
    }
}
