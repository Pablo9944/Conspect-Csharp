using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyList__Mission_;

namespace _11._2_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> c = new CarCollection<string> ();
            c.AddCar("bmw",DateTime.Now);


            Console.WriteLine(c);
        }
    }
}
