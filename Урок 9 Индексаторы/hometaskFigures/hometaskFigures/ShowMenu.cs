using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskFigures
{
    class ShowMenu
    {
     
        ConsoleColor color;

        public ConsoleColor Color()
        {
            Console.WriteLine("Выберете цвет 1-зеленый,2-красный, 3-желтый, 4-серый");
            int d = int.Parse(Console.ReadLine());
           
            switch(d)
            {
                case 1: return ConsoleColor.Green;
                case 2: return ConsoleColor.Red;  
                case 3: return ConsoleColor.Yellow; 
                case 4: return ConsoleColor.Gray;
            }

            return 0;
        }
        


        public Figure Get_Figure()
        {
            Console.WriteLine("Выберете фигуру 1- ромб, 2-треугольник, 3-прямоугольник, 4 - трапеция, 5-многоугольник ");
            int c = int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:
                    {
                        Console.WriteLine("Укажите сторону");
                     int side= int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите координаты");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        color = Color();
                        return new Romb() { X = x, Y = y, Side = side, Color=color };
                    };
                case 2:
                    {
                        Console.WriteLine("Укажите нижнюю сторону ");
                        int  botton= int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите правую сторону ");
                        int right = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите левую сторону ");
                        int left = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите координаты");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        color = Color();
                        return new Triangle() {Botton=botton,Left=left,Right=right,X=x,Y=y,Color=color};
                    };
                case 3:
                    {
                        Console.WriteLine("Укажите верхнюю сторону ");
                        int top = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите боковую сторону ");
                        int right = int.Parse(Console.ReadLine());
                      
                        Console.WriteLine("Укажите координаты");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        color = Color();
                        return new Rectangle() { Top=top,Side=right, X = x, Y = y, Color = color };
                    };
                case 4:
                    {
                        Console.WriteLine("Укажите верхнее основание ");
                        int top = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите нижнее основание");
                        int botton = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите правую сторону ");
                        int right = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите левую сторону ");
                        int left = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите координаты");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        color = Color();
                        return new Trapezia() { Botton = botton, Left = left, Right = right,Top=top, X = x, Y = y, Color = color };
                    };
                case 5:
                    {
                        Console.WriteLine("Укажите сторону");
                        int side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Укажите координаты");
                        int x = int.Parse(Console.ReadLine());
                        int y = int.Parse(Console.ReadLine());
                        color = Color();
                        return new Polygon() { X = x, Y = y, Side = side, Color = color };
                    };





            }
            return null;


        }
    }
}
