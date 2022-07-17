using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1_Пример_События
{
    delegate void PushPrinterButton();
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintButton printButton = new PrintButton();
            printButton.Click += new PushPrinterButton(StartPrint.OnPrintClick);
            
            Console.WriteLine("Введите текст:");
            Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);
           
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp != "")
                {
                    StartPrint.text += temp+"\n";
                    continue;
                }

                break;
            }
            while (true)
            {
                if (Console.ReadLine() == "p")
                {
                    printButton.DoEvent();
                    break;
                }
            }

        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("\a");
           
            
        }
    }
    class StartPrint
    {
        public static string text;
        public static void OnPrintClick()
        {
            Console.WriteLine("Текст:\n-----------\n" + text);
            Console.ReadLine();
        }
    }

    class PrintButton
    {
        public event PushPrinterButton Click;

        public void DoEvent()
        {
            if (Click!= null)
            {
                Click();
            }
        }
    }

}
