using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_События__самый_практичный_пример_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KeyBoardMaster KM = new KeyBoardMaster();
            KM.wKeyPressedEvent += buttonW_Click;
            KM.sKeyPressedEvent += buttonS_Click;

            ConsoleKey pressedKey;
            while (true)
            {
                pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                { 
                    case ConsoleKey.S:
                        KM.SKeyPressedEvent();
                        break;
                    case ConsoleKey.W:
                        KM.WKeyPressedEvent();
                        break;
                }
            }


        }
        static private void buttonW_Click()
        {
            Console.WriteLine(" Вперёд");
        }

        static private void buttonS_Click()
        {
            Console.WriteLine(" Назад");
        }
       
    }

    public delegate void KeyPressEventDelegate();
    class KeyBoardMaster
    {
        public event KeyPressEventDelegate wKeyPressedEvent = null;
        public event KeyPressEventDelegate sKeyPressedEvent = null;

        public void WKeyPressedEvent () => wKeyPressedEvent?.Invoke();
    
        public void SKeyPressedEvent()
        {
            if (sKeyPressedEvent != null)
                sKeyPressedEvent.Invoke();
        }

    }
}
