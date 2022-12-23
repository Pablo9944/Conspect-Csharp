using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork__Matrix_
{
    internal class Program
    {
        static object block = new object();   
        static void Main(string[] args)
        {
            //Random r = new Random();



            //    Thread threadGreen = new Thread(new ThreadStart(Print_Green));
            //    threadGreen.Start();

            //    Thread threadDarkGreen = new Thread(new ThreadStart(Print_DarkGreen));
            //    threadDarkGreen.Start();

            //    Thread threadWhiteCentr = new Thread(new ThreadStart(Print_White_Centr));
            //    threadWhiteCentr.Start();

            //    Thread threadGreenCentr = new Thread(new ThreadStart(Print_Green_Centr));
            //    threadGreenCentr.Start();

            //    Thread threadDarkGreenCentr = new Thread(new ThreadStart(Print_DarkGreen_Centr));
            //    threadDarkGreenCentr.Start();

            //    Thread threadWhiteLast = new Thread(new ThreadStart(Print_White_Last));
            //    threadWhiteLast.Start();

            //    Thread threadGreenLast = new Thread(new ThreadStart(Print_Green_Last));
            //    threadGreenLast.Start();

            //    Thread threadDarkGreenLast = new Thread(new ThreadStart(Print_DarkGreen_Last));
            //    threadDarkGreenLast.Start();
           




            //string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //char[] chars = symbols.ToCharArray();
            //for (int i = 0; i < 10; i++)
            //{
            //    lock (block)
            //    {
            //        string format = string.Format("{0}{1}{2}",
            //                                           new string(' ', new Random().Next(0, 15)),
            //                                           new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))),
            //                                           new string(' ', new Random().Next(0, 15)));

            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.WriteLine(format);
            //        Console.ResetColor();
            //        Thread.Sleep(100);
            //    }
                   
            //}


        }

        static void Print_Green()
        {

            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
               
            for (int i = 0; i < 10; i++)
            {
                    lock(block)
                    {
                    string format = string.Format("{0}{1}{2}",
                                                                new string(' ', new Random().Next(0, 15)),
                                                                new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0,3),new Random().Next(1,4))),
                                                                new string(' ', new Random().Next(0, 15)));
                      Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(format);
                        Console.ResetColor();
                        Thread.Sleep(100);
                    }
                  
             }

        }
        static void Print_DarkGreen()
        {
            Random r = new Random();
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}{2}",
                                                           new string(' ', new Random().Next(0, 15)),
                                                           new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))),
                                                           new string(' ', new Random().Next(0, 15)));
              
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }
  
        static void Print_White_Centr()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}{2}",
                                                       new string(' ', new Random().Next(20, 60)),
                                                       new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))),
                                                       new string(' ', new Random().Next(0, 15)));

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }
        static void Print_Green_Centr()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}{2}",
                                                       new string(' ', new Random().Next(20, 60)),
                                                       new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))),
                                                       new string(' ', new Random().Next(0, 15)));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }
        static void Print_DarkGreen_Centr()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}{2}",
                                                       new string(' ', new Random().Next(20, 60)),
                                                       new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))),
                                                       new string(' ', new Random().Next(0, 15)));

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }

        static void Print_White_Last()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}",
                                                       new string(' ', new Random().Next(80, 110)),
                                                       new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))));

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }
        static void Print_Green_Last()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}",
                                                       new string(' ', new Random().Next(80, 110)),
                                                       new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }
        static void Print_DarkGreen_Last()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] chars = symbols.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                lock (block)
                {
                    string format = string.Format("{0}{1}",
                                                       new string(' ', new Random().Next(80, 110)),
                                                       new string(chars[new Random().Next(0, chars.Length)], new Random().Next(new Random().Next(0, 3), new Random().Next(1, 4))));

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(format);
                    Console.ResetColor();
                    Thread.Sleep(100);
                }

            }
        }
    }
}
