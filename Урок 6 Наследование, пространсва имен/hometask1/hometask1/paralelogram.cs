using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class paralelogram : Figure
    {
        public double Top { get; set; }
        public double Side { get; set; }
        public double Angle { get; set; }
        public paralelogram(double top, double side, double  angle)
         {
            Top = top;
            Side = side;
            Angle = angle; }
        public override double Square()
        {
            double s =Math.Round( Top * Side*Math.Sin(Angle*Math.PI/180),2);
            return s;

        }
        public override double Perimetr()
        {
            double p = 2 * (Top + Side);
            return p;

        }
         public override void print()
        {
            Console.WriteLine("Информация по паралелограму: ");
                base.print();
        }

    }
}
