using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    /// <summary>
    /// Обобщенный класс точки
    /// </summary>
    /// <typeparam name="T">
    /// координаты точки могут быть любого типа
    /// </typeparam>
    public class Point2D<T> 
    {
        //параметр типа используется для задания типа свойства
        public T X { get; set; }
        public T Y { get; set; }

        //параметр типа используется для задания типов параметров метода
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //тестирование обобщенного класса - точки в 2D
            Point2D<int> p1 = new Point2D<int>();
            WriteLine($"x = {p1.X} y = {p1.Y}");
            WriteLine(typeof(Point2D<int>));
           
            Point2D<double> p2 = new Point2D<double>(10.5, 20.5);
            WriteLine($"\nx = {p2.X} y = {p2.Y}");
            WriteLine(typeof(Point2D<double>));
        }
    }
}