using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2.Матрица___1
{
     class Matrix
    {
        static readonly object locker = new object(); // обьект синхронизации
        Random r;

        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public int Colunm { get; set; } // текущая колонка в которуя падает данная цепочка

        public Matrix(int col)
        {
            Colunm = col;
            r = new Random((int)DateTime.Now.Ticks);
        }

        private char GetChar()
        {
            return litters.ToCharArray()[r.Next(0,34)]; 
        }
        public void Move()
        {
            int length;
            int count;
            while (true)
            {
                count = r.Next(3, 6);
                length = 0;
                Thread.Sleep(r.Next(20, 5000));

                for (int i = 0; i < 40; i++)
                {
                    lock(locker)
                    {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;
                        for (int j = 0; j < i; j++)
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine("█");
                        }
                        if (length < count)
                            length++;

                        else
                            if(length==count)
                            count = 0;

                        if (39 - i < length)
                            length--;
                        Console.CursorTop = i - length + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        for (int j = 0; j < length - 2; j++)
                        {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                       
                        if (length >= 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }

                        if (length >= 1)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        Thread.Sleep(20);

                    }
                }
            }
        }

    }
}
