using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList= new ArrayList();
            arrayList.Add(3);
            arrayList.Add("string");
            arrayList.Add(new MyClass() { MyInt = 5, MyString = "10"});

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);

               
            }
        }
    }
    class MyClass
    {
        public int MyInt { get; set; }
        public string MyString { get; set; }

        public override string ToString()
        {
           return MyInt + " " + MyString;
        }
    }
}
