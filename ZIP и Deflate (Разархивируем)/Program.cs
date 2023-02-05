using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIP_и_Deflate__Разархивируем_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream source = File.OpenRead("test.zip");
            FileStream destination = File.Create("test.zip.txt");

            GZipStream decompression = new GZipStream(source, CompressionMode.Decompress);

            int thebyte = decompression.ReadByte();

            while (decompression.ReadByte() != -1)
            {
                destination.WriteByte((byte)thebyte);
                thebyte = decompression.ReadByte();

            }
            decompression.Close();
            Console.ReadKey();
        }
    }
}
