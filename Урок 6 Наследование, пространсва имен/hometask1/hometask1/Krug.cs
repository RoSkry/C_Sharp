using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class Krug : Figure
    {

        public double Radius { get; set; }
        public Krug(double radius)
        {
            Radius = radius;

        }
        public override double Square()
        {
            double s =Math.Round( Math.Pow(Radius, 2) * Math.PI,2);
            return s;

        }
        public override double Perimetr()
        {
            double p =Math.Round( 2 * Math.PI * Radius,2);
            return p;

        }
        public override void print()
        {
            Console.WriteLine("Информация по кругу: ");
            base.print();
        }
    }
}
