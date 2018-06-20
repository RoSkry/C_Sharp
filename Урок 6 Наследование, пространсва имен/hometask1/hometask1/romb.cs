using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
  public class romb : Figure
    {
        public double Side { get; set; }
        public double Angle { get; set; }
        public romb(double side,double angle)  {
            Side = side;
            Angle = angle;
        }

        public override double Square()
        {
            double s =Math.Round( Math.Pow(Side,2)*Math.Sin(Angle*Math.PI/180),2);
            return s;
        }
        public override double Perimetr()
        {
            double p = 4 * Side;
            return p;
        }
        public override void print()
        {
            Console.WriteLine("Информация по ромбу: ");
            base.print();
        }





    }

}
