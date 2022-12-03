using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace _666.Тестовая
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Office of = new Office(new Operator("Александр", "Герасимов", 60000, "CВО"),
                                   new Operator("Александр", "Герасимов", 60000, "CВО"),
                                   new Operator("Александр", "Герасимов", 60000, "CВО"));

            for (int i = 0; i < of.id.Length; i++)
            {
                Console.WriteLine(of.id[i].Print());
            }
        }

        static void Start(int number) => Console.WriteLine(number);
        static void Starts(string number) => Console.WriteLine(number);

    }

    public delegate void Delegat_Test(int number);
    class MyClass
    {
       

        public Delegat_Test dT { get; set; }

        public void Show(int number)
        {
            dT(number);
        }
    }

}