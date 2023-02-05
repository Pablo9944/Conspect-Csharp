using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Информация_о_дисках.Удаление_директорий
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Directory.GetLogicalDrives();
            foreach (string s in drivers)
            {
                Console.WriteLine(s);
            }

            string delPath = @"D:\";

            DirectoryInfo dir = new DirectoryInfo(delPath);
            

            for (int i = 0; i < 5; i++)
            {
                dir.CreateSubdirectory("Delete" + i);
            }
            DirectoryInfo[] temp = dir.GetDirectories();
            

            for (int i = 0; i < dir.GetDirectories().Length; i++)
            {

                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[i].Name == "Delete"+j)
                    {
                        Directory.Delete(delPath + temp[i].Name);
                        
                    }
                }
               
            }

        }
    }
 }

