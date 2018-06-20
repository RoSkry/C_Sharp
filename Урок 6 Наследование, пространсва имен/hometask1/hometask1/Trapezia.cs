using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class Trapeziya : Figure
    {

        public double Top{ get; set; }
        public double Botton { get; set; }
        public double Left { get; set; }
        public double Right{ get; set; }
        public Trapeziya(double top, double botton, double left, double right)     {
            Top = top;
            Botton = botton;
            Left = left;
            Right = right;
        }

        public override double Square()
        {
            double f = (Top + Botton) / 2;
            double v = Math.Pow((Botton - Top), 2) + Math.Pow(Left, 2) - Math.Pow(Right, 2);
            double n = 2 * (Botton - Top);
            double o = Math.Pow(v / n, 2);
            double t = Math.Sqrt(Math.Pow(Left, 2)-o);
            double result = Math.Round( f * t,2);
            return result; 

        }
        public override double Perimetr()
        {
            double p = Top + Botton + Left + Right;
            return p;
        }
        public override void print()
        {
            Console.WriteLine("Информация по трапеции: ");
            base.print();
        }


    }
}
