
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Вложенные_пространстваимён
{
    using NamespaceA.NamespaceB.NamespaceC;
    using NamespaceA.NamespaceB;
    using NamespaceA;


    // Создание псевдонима MeClass, для класса MyClassC из пространства имен NamespaceA.NamespaceB.NamespaceC
    using Name = NamespaceA.NamespaceB.NamespaceC.MyClassA;

    internal class Program
    { 
        static void Main(string[] args)
        {
            //MyClassA mcA = new MyClassA();
            //MyClassB mcB = new MyClassB();
            //MyClassC mcC = new MyClassC();

            Name MyClassA = new Name();
            Console.WriteLine(MyClassA.GetType());


            
           
        }
    }
}
namespace NamespaceA
{
    namespace NamespaceB
    {
        namespace NamespaceC
        {
            class MyClassA
            {
                public MyClassA()
                {
                    Console.WriteLine(this.GetType().Name);
                }
            }
        }
        class MyClassB
        {

        }
    }
    class MyClassC
    {

    }
}