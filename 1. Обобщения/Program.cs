using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Обобщения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Myclass<int> mc1 = new Myclass<int>(3); mc1.GetInfoProperty();
            Myclass<DateTime> mc2 = new Myclass<DateTime>(DateTime.Now); mc2.GetInfoProperty();
            Myclass<string> mc3 = new Myclass<string>("Привет"); mc3.GetInfoProperty();

            
        }
    }
}
