using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
   public class kvadrat : Figure
    {
        public double Side{ get; set; }
        public kvadrat(double side)  {
            Side = side;
        }
        public override double Square()
        {
            double s = Math.Pow(Side, 2);
            return s;

        }
        public override double Perimetr()
        {
            double p = 4 * Side;
            return p;
        }
        public override void print()
        {
            Console.WriteLine("Информация по квадрату: ");
            base.print();
        }
    }
}
