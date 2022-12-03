using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.События
{
    // 1
    // Обьяваили делегат
    delegate void PushPrinterButton();
    internal class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            // 3
            // подписались на событие с указанием конкретного метода
            mouse.Click += new PushPrinterButton(mouse.OnMouseClick);
            mouse.Click += new PushPrinterButton(mouse.OnMouseClickVersionTwo);

            mouse.Click -= new PushPrinterButton(mouse.OnMouseClick);
            // вызывется событие
            mouse.DoEvent();
        }
    
    
    }

    class Mouse
    {
        //2
        // Обьявили событие о нажатии кнопки мыши
        public event PushPrinterButton Click; 

        //4
        // генерация события
        public void DoEvent()
        {
            if (Click != null)
           // запуск события
            Click();
        }
        // 3.1
        // обработчик события
        public void OnMouseClick()
        {
            Console.WriteLine("Произошло нажатие кнопки мышки на кнопке печати\n" +
                              "Начинается печать....");
            Console.ReadLine();
        }

        public void OnMouseClickVersionTwo()
        {
            Console.WriteLine("Дождитесь конца печати");
            Console.ReadLine();
        }
    }

}
