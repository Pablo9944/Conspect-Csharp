using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3._1_Enum__пример_с_цветами_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] favcolors = new int[15];
            ConsoleColor cc = ConsoleColor.DarkBlue;
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = (i);

                switch ((ConsoleColor)favcolors[i])
                {
                    case ConsoleColor.Black:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkBlue:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkGreen:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkCyan:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkRed:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkMagenta:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkYellow:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.Gray:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.DarkGray:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.Cyan:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.Magenta:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Text");
                        break;
                    case ConsoleColor.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Text");
                        break;

                    case ConsoleColor.White:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Text");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
