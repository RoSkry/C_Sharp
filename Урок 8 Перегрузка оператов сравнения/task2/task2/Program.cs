using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    class CPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    struct SPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main()
        {
            // работа метода ReferenceEquals со ссылочными и значимыми типами

            //ссылочный тип массивы строки делегаты 
            CPoint cp = new CPoint { X = 10, Y = 10 };
            CPoint cp1 = new CPoint { X = 10, Y = 10 };
            CPoint cp2 = cp1;

            // хотя cp и cp1 содержат одинаковые значения, они указывают на разные адреса памяти
            WriteLine($"ReferenceEquals(cp, cp1) = {ReferenceEquals(cp, cp1)}"); // false

            // cp1 и cp2 указывают на один и тот же адрес памяти
            WriteLine($"ReferenceEquals(cp1, cp2) = {ReferenceEquals(cp1, cp2)}"); // true

            // значимый тип
            SPoint sp = new SPoint { X = 10, Y = 10 };

            // при передаче в метод ReferenceEquals выполняется упаковка,
            // упакованные объекты располагаются по разным адресам
            WriteLine($"ReferenceEquals(sp, sp) = {ReferenceEquals(sp, sp)}"); // false

            // работа метода Equals со ссылочными и значимыми типами

            //выполняется сравнение адресов ссылочных типов
            WriteLine($"Equals(cp, cp1) = {Equals(cp, cp1)}"); // false

            // значимый тип
            SPoint sp1 = new SPoint { X = 10, Y = 10 };

            // выполняется сравнение значений полей
            WriteLine($"Equals(sp, sp1) = {Equals(sp, sp1)}"); // true
        }
    }
}
