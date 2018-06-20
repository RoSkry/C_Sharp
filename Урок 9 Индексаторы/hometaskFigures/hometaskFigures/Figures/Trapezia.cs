using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskFigures
{
    class Trapezia :Figure,IFigure
    {
        public ConsoleColor Color { set; get; }
        public double Top { get; set; }
        public double Botton { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }

        public int X { get; set; }
        public int Y{ get; set; }
        public override  void Show()
        {
            Console.ForegroundColor = Color;
            for (int i=0;i<Top;i++)
            {
             Console.SetCursorPosition(X+i, Y);
              Console.Write("+");

            }

            for (int i = 0; i < Botton; i++)
            {
                Console.SetCursorPosition(X-(int)((Botton-Top)/2)  +i, Y+(int)Left);
                Console.Write("+");
            }
            for (int i = 0; i < Right; i++)
            {
                Console.SetCursorPosition(X - (int)((Botton - Top) / 2) + i, Y +(int)Right- i);
                Console.Write("+");
            }
            for (int i = 0; i < Left; i++)
            {
                Console.SetCursorPosition(X + (int)((Botton-Top)/2+Top)- i, Y + (int)Left -i);
               Console.Write("+");

            }


            Console.ResetColor();
            Console.ReadLine();

        
          }

    }
}
