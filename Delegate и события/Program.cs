using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_и_события
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyEvent += new EventDelegate(Handler1);
            myClass.MyEvent += new EventDelegate(Handler2);
            myClass.InvokeEvent();
            Console.WriteLine(new String('=',30));


            Printer p = new Printer();
            p.EventHandler += Print_Message;
            Eve e = new Eve();

            bool flag = true;
            while (flag)
            {

                START();
                
               
                p.StartPrint(e, e);
            }
        }

        static async void START()
        {
            await Task.Delay(200);
            //await Task.Run(() =>
            //{
                
            //    Console.Write("Введите что угодно: ");
            //});
            
        }
        static void Print_Message(object sender, Eve e)
        {
            
            Console.WriteLine("Слово изменилось");
        }
        static void Handler1()
        {
            Console.WriteLine("Обработчик событий 1");
        }
        static void Handler2()
        {
            Console.WriteLine("Обработчик событий 2");
        }

    }
    public delegate void EventDelegate();
    class MyClass
    {
        EventDelegate myEvent;

        public event EventDelegate MyEvent
        {
            add { myEvent += value;}
            remove { myEvent -= value;}
        }

        public void InvokeEvent()
        {
            myEvent.Invoke();
        }
    }

    public delegate void DelegateHandler(object sender, Eve e);
    class Printer
    {
        public string field = "sdfsd";
        event DelegateHandler eventHandler;

        public event DelegateHandler EventHandler
        {
            add
            {
                eventHandler += value;
            }
            remove
            {
                eventHandler -= value;
            }
           
        }
        public async void StartPrint(object sender, Eve e)
        {
            await Task.Run(async () =>
            {
                await Task.Delay(500);
                Console.WriteLine('-');
                while (e.message.ToString() != "a");
                eventHandler.Invoke(sender, e);
            });
           
            
        }
    }
  public  class Eve : EventArgs
    {
        public string message = "sdsdsd";
    }
}



