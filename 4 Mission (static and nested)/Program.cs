using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Mission__static_and_nested_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Notes n = new Book.Notes();
            Book b = new Book(n);
            Console.WriteLine(b["2"]);
 
        }
    }
}
 