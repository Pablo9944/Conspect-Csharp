using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Создаем_папки_и_подпапки_и_многое_другое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @".";
            DirectoryInfo dir = new DirectoryInfo(path);

            if (dir.Exists )
            {
                dir.CreateSubdirectory("SUBCreateTest");
                dir.CreateSubdirectory(@"SUBCreateTest\SUB_2");
                dir.CreateSubdirectory(@"1\2");
            }
        }
    }
}
