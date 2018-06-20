using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskFigures
{
    class Polygon :Figure,IFigure
    {
        public ConsoleColor Color { set; get; }
        public  int X { get; set; }
      public  int Y { get; set; }
        public int Side { get; set; }
       public override void Show()
        {
            Console.ForegroundColor = Color;
            for (int i=0;i<=Side;i++)
            {
                Console.SetCursorPosition(X  + i, Y);
                Console.WriteLine("+");
                Console.SetCursorPosition(X +Side+ i, Y + i);
                Console.WriteLine("+");
                Console.SetCursorPosition(X  - i, Y + i);
                Console.WriteLine("+");
                Console.SetCursorPosition(X-Side + i, Y+Side + i);
                Console.WriteLine("+");
                Console.SetCursorPosition(X + i, Y+Side*2);
                Console.WriteLine("+");
                Console.SetCursorPosition(X +Side+ i, Y +Side * 2-i);
                Console.WriteLine("+");
            }
            Console.ResetColor();


        }
    }
}
