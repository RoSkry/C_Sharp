using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask2
{
   public abstract class Chetirehugolnik :Figure
    {
        public double Right { get; set; }
        public double Left { get; set; }
        public double Top { get; set; }
        public double Botton { get; set; }
        public  Chetirehugolnik(double right)
        {
            Right = right;
        }
        public Chetirehugolnik(double right,double top)
        {
            Right = right;
            Top = top;

        }
       
        public Chetirehugolnik(double right,double left,double top,double botton)
        {
            Right = right;
            Top = top;
            Left = left;
            Botton = botton;
        }

    }
}
