using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Перегрузка_операторов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(20,20);
            Point p2 = new Point(20,20); 
            Point p3 = new Point(30,30);

            p3 = p1 + p2;
            Console.WriteLine(p3.x + " " + p3.y);

            Console.WriteLine(p1==p2);
            Console.WriteLine(p1!= p2);
        }
    }
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
    
        public static Point operator +(Point p1,Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y); 
        }

        public override bool Equals(object input)
        {
            if (input is Point)
            {
                if(((Point)input).x == this.x && ((Point)input).y == this.y)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator == (Point p1, Point p2)
        {
            return p1.Equals(p2);   
        }

        public static bool operator != (Point p1, Point p2)
        {
            return !p1.Equals(p2);
        }

    }
}
