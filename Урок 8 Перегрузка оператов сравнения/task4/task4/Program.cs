using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Point
    {
        public int X { get; set; }
        public int Y{ get; set; }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;

        }
        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { X = 10, Y = 20 };
            Point p1 = new Point { X = 0, Y = 30 };
            Point p2 = new Point { X = 0, Y = 0 };

            Console.WriteLine($"p(10,20)= {(p?true:false)}");

        }
    }
}
