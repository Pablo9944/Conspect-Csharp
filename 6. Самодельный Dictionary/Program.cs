using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Самодельный_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary d = new Dictionary();
            Console.WriteLine(d[0]);

            Console.WriteLine(d["стол"]);
        }
    }
}
