using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometaskFigures
{
    class CollectFigure
    {
        public CollectFigure() { }
    Figure[] _figures = new Figure[0];
      public  CollectFigure(Figure[] f)
        {
            _figures = new Figure[f.Length];
            for(int i=0;i<f.Length;i++)
            {
                _figures[i] = f[i];
            }
        }
        public void AddFigure(Figure o)
        {
            Array.Resize(ref _figures, _figures.Length + 1);
            _figures[_figures.Length - 1] = o;
        }
        public void show()
        {
            for( int i=0;i< _figures.Length;i++)
            {
                _figures[i].Show();
            }
        }
    }
}
