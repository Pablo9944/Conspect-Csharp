using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Описание__StreamBilder_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // STreamBilder используется для конкатенации string (самый быстрый поток)
            StringBuilder s = new StringBuilder();
            s.Append("text");

            Print p = new Print();
            Console.WriteLine("{0:test}",p);
           
        }
    }
    public class Print : IFormattable
    {
        public string line;
        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format)
            {
                case "test": return (format + " " + ".test");
                default: throw new  Exception();
               
            }
        }
    }
}
