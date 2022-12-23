using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static _9._0.Интерфейсы__явная_реализация_.Program;

namespace _9._0.Интерфейсы__явная_реализация_
{
    public class Program
    {
        interface IFirstInterface
        {
            void Action();
        }
        interface ISecondInterface
        {
            void Action();
        }

        class MyClass : IFirstInterface, ISecondInterface
        {
            public void Action()
            {
                Console.WriteLine("Вывод MyClass");
            }
        }

       public class MyOtherClass : IFirstInterface, ISecondInterface
        {
            void IFirstInterface.Action()
            {
                Console.WriteLine("Реализация IFirstInterface ");
            }

            void ISecondInterface.Action()
            {
                Console.WriteLine("Реализация ISecondInterface");
            }
        }

        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Action();
        }

        static void Bar(ISecondInterface secondInterface)
        {
            secondInterface.Action();
        }

        class TestClass
        {

        }

        static void Main(string[] args)
        {
            TestClass ts = new TestClass ();
            //MyClass mc = new MyClass();
            //Foo(mc);
            //Bar(mc);
            //Console.WriteLine();

            MyOtherClass moc = new MyOtherClass();
            moc.Extance();
           //((IFirstInterface)moc).Action();

           //if( moc is IFirstInterface firstInterface)
           //{
           //    firstInterface.Action();
           //}

           var test = ts as IFirstInterface;
            if (test != null)
            {
                test.Action();
            }

            //Foo(moc);
            //Bar(moc);
          


        }
     

    }
    public static class Extance_Test
    {
        public static void Extance(this MyOtherClass moc)
        {
            Console.WriteLine("Метод расширения");
        }
    }
}
