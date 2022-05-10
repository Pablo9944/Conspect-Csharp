using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_Работа_с_файлами
{
    public static class DirectoryExtension
    {
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;
       
            FileInfo[] fls = d.GetFiles();
            foreach (var item in fls)
            {
                size += item.Length;
            }
            

            DirectoryInfo[]dir = d.GetDirectories();
            foreach (var item in dir)
            {
                size += DirSize(item);
            }
            return size;    
        }
    }
}
