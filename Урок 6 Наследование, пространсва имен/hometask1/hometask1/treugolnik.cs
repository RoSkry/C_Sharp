using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class treugolnik:Figure
    {
        public double Right { get; set; }
        public double Left { get; set; }
        public double Botton { get; set; }
        public treugolnik(double right, double botton, double left)  {
            Right = right;
            Left = left;
            Botton = botton;

        }
        public override double Square()
        {
            double p = Perimetr() / 2;
            double s = Math.Round( Math.Sqrt(p * (p - Left) * (p - Botton) * (p - Right)),2);
            return s;
        }
        public override double Perimetr()
        {
            double p = Right + Botton + Left;
            return p;
        }
        public override void print()
        {
            Console.WriteLine("Информация по треугольнику: ");
            base.print();
        }
    }
}
