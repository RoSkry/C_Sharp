using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
   public abstract class Figure
    {
        public abstract double Square();
        public abstract double Perimetr();
        public virtual void print()
        {
            Console.WriteLine("Площадь равна " + Square());
            Console.WriteLine("Периметр равен " + Perimetr());
        }

    }
}
