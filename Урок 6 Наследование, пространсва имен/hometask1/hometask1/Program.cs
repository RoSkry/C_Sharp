using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{

    class Program
    {
        static void Main(string[] args)
        {
            //  Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
            //Разработать классы-наследники: Треугольник, Квадрат, Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг, Эллипс.
            //Реализовать конструкторы, которые однозначно определяют объекты данных классов.
            //Реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур».
            //Для данного класса определить методы нахождения площади и периметра фигуры.
            Figure[] figures = { new Prymougolnik(2, 3),

            new treugolnik(3, 4, 5),
            new kvadrat(3),
            new romb(4,6) ,
            new paralelogram(4, 6,10),
            new Trapeziya(2, 4, 5, 6),
            new Krug(3),
            new Elips(3,5),
            };

            foreach (Figure figure in figures)
            {
               figure.print();

            }

            SostavnayaFigure g = new SostavnayaFigure(figures);
            g.show();








        }
    }
}

 