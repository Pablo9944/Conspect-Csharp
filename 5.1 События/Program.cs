using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1_События
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.myEvent += Handler1;
            instance.myEvent += Handler2;
            instance.InvokeEvent();
            Console.WriteLine("---");
            instance.myEvent -= Handler2;
            instance.InvokeEvent();
            Console.ReadKey();

        }
        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }
    }

    public delegate void EventDelegate();
    class MyClass
    {
        public event EventDelegate myEvent = null;

        public event EventDelegate MyEvent
        {
            add{ myEvent += value; }
            remove{ myEvent -= value; }
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }
}
