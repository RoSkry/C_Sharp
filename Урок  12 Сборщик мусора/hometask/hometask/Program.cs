using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько автомобилей 2 - 7");
            int number = int.Parse(Console.ReadLine());
            Car c = new Car(number);
            c.show();
            c.move();

        }
    }
}
