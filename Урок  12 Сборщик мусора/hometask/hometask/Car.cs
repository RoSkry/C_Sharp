using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace hometask
{
    class Car
    {
        public Car() { }
        public ConsoleColor Color { get; set; }
        public int Number { get; set; }
        public int Peremes { get; set; }
        public Car(int n)
        {
            Number = n;


        }
        public void show()
        {
            for (int i = 0; i < Number; i++)
            {
                //Console.SetCursorPosition(10+i,10+i);
                Console.ForegroundColor = ConsoleColor.Blue + i;
                Console.WriteLine("***");
                Console.WriteLine("***");
                Console.WriteLine();

                //Thread.Sleep(1000);
                Console.ResetColor();
            }





        }
        public static Car operator ++(Car m)
        {
            Random r = new Random();
            return new Car() { Peremes = r.Next(1, 6) };
        }
        public void move()
        {
            for (int i = 0; i < Number; i++)
            {
                Console.SetCursorPosition(10+i , 10);
                Console.WriteLine("***");
                Console.WriteLine("***");
                Thread.Sleep(1000);
            }
        }
    }
}
