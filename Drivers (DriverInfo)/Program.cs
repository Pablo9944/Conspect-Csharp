using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivers__DriverInfo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] dr = DriveInfo.GetDrives();

            foreach (DriveInfo d in dr)
            {
                Console.WriteLine(d.Name);
                Console.WriteLine(d.VolumeLabel);
                Console.WriteLine(d.DriveType);
                Console.WriteLine(d.DriveFormat);
                Console.WriteLine();
            }
        }
    }
}
