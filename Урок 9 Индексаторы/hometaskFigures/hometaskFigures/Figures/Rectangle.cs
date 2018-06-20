using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskFigures
{
    class Rectangle : Figure, IFigure
    {
        public ConsoleColor Color { set; get; }
        public Rectangle() { }
        public double Top { get; set; }
        public double Side { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public override void Show()
        {
             Console.ForegroundColor = Color;
            for (int i = 0; i < Top; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write("+");

                Console.SetCursorPosition(X + i, Y + (int)Side-1);
                Console.Write("+");
            }

            for (int i = 0; i < Side; i++)
            {
                
                Console.SetCursorPosition(X, Y + i);
                Console.Write("+");
                Console.SetCursorPosition(X + (int)Top-1, Y + i);
                Console.Write("+");

            }
            Console.ResetColor();
        }

        }

    }

