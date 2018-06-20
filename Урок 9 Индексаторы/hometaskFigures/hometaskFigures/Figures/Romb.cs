using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskFigures
{
    class Romb:Figure,IFigure
    {
       public ConsoleColor Color { set; get; }
       public double Side { get; set; }
      public  int X { get; set; }
      public  int Y { get; set; }
      public override void Show()
        {
             Console.ForegroundColor = Color;
            for(int i=0;i<=Side;i++)
            {
                Console.SetCursorPosition(X+i, Y+i);
                Console.Write("+");
                Console.SetCursorPosition(X - i, Y + i);
                Console.Write("+");
                Console.SetCursorPosition(X +i, Y+(int)Side*2 -i);
                Console.Write("+");
                Console.SetCursorPosition(X-i, Y + (int)Side*2 - i);
                Console.Write("+");

            }
            Console.ResetColor();
            Console.SetCursorPosition(X + 15, Y +15);
       
            
           


        }

    }
}
