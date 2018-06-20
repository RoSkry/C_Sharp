using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class Elips : Figure
    {

        public double Large { get; set; }
        public double Small { get; set; }

        public Elips(int large, int small) {
            Large = large;
            Small = small;

        }
        public override double Square()
        {
            double s =Math.Round( Large * Small * Math.PI,2);
            return s;

        }
        public override double Perimetr()
        {
            double p = Math.Round(2 * 3.14 * Math.Sqrt(Math.Pow(Large, 2) + (Math.Pow(Small, 2) / 2)), 2);
            return p;

        }
        public override void print()
        {
            Console.WriteLine("Информация по елипсу: ");
            base.print();
        }

    }
}
