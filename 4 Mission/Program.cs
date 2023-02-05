using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddArcticle(new Arcticle() { name = "колбаса", nameStrore = "5", Cost = 100 }, 0);
            store.AddArcticle(new Arcticle() { name = "картошка", nameStrore = "5", Cost = 200 }, 1);
            store.AddArcticle(new Arcticle() { name = "сыр", nameStrore = "5", Cost = 300 }, 2);


            Console.WriteLine(store["колбаса"]);
            Console.WriteLine(store["test"]);
            Console.WriteLine(store[0]);
        }
    }
}
