using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать приложение, которое будет отображать в консоли простейшие геометрические фигуры заданные пользователем.
//Пользователь выбирает фигуру и задает ее расположение на экране, а также размер и цвет с помощью меню.
//Все заданные пользователем фигуры отображаются одновременно на экране.
//Фигуры (прямоугольник, ромб, треугольник, трапеция, многоугольник) рисуются звездочками или другими символами.
//Для реализации программы необходимо разработать иерархию классов(продумать возможность абстрагирования).

//Для хранения всех, заданных пользователем фигур, создать класс «Коллекция геометрических фигур» с методом «Отобразить все фигуры».
namespace hometaskFigures
{
    class Program
    {
        static void Main(string[] args)
        { 
            ShowMenu s = new ShowMenu();
            CollectFigure figures = new CollectFigure();

            while (true)
            {
                figures.AddFigure(s.Get_Figure());
                Console.WriteLine("Хотите продолжить? Yes-1 or No-2");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 2) break;

            }
            Console.Clear();
            figures.show();




        }
    }
}
