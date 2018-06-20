using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Class2
    {
struct Dimentions
        {
            public double Height;
            public double Width;
            public Dimentions(double h, double w)
            {
                Height = h;
                Width = w;
            }
            public void print()
            {
                Console.WriteLine($"Ширина:{Width},высота:{Height}");
            }


        }
        static void Main(string[] args)
        {
            Class3 st = new Class3();
   st.print();
            Class3 st1 = st;
            Class3 st2=null;
            st2 = new Class3("fdg", "ghj");
            st2.print();


            //Dimentions d1 = new Dimentions();
            //d1.print();
            //Dimentions d2 = new Dimentions(6.3,8.4);
            //d2.print();
            //d1.Height += 5;
            //d1.Width += 8;
            //d1.print();

        }
    }
}

