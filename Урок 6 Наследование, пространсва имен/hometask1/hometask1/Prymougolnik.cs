using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class Prymougolnik:Figure
    {
        public double Top { get; set; }
        public double Side { get; set; }
        public Prymougolnik(double top, double side)  {
            Top = top;
            Side = side;
        }
            public override double Square()
            {
            
                double s = Top * Side;
                return s;
            }
            public override double Perimetr()
            {
                double p = 2 * (Top + Side);
                return p;
            }
        public override void print()
        {
            Console.WriteLine("Информация по прямоугольнику: ");
            base.print();
        }

    }
}
