using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class SostavnayaFigure
    {
        Figure[] x;


      public  SostavnayaFigure(Figure[] d)
        {
             x = new Figure[d.Length];
         
            for (int i = 0; i < d.Length; i++)
            {
                x[i] = d[i];
            }     

        }
           public double Square (){
            double s = 0;
                    for (int i = 0; i < x.Length; i++)
            {
                 s+= x[i].Square();

                
            }
              return s;     
           

        }
        public double Perimetr()
        {
            double p = 0;
            for (int i = 0; i < x.Length; i++)
            {
                p += x[i].Perimetr();


            }
            return p;
        } 
                 public void show()
        {
            Console.WriteLine("Периметр новой фигуры " + Math.Round( Perimetr(),2));
            Console.WriteLine("Площадь новой фигуры " + Math.Round(Square(),2));

        }

        }

    }

