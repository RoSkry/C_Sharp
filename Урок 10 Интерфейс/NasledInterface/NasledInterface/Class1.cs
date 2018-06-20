using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledInterface
{
    class Class1 : IA, IB, IC
    {
        void IB.Show() //явно
        {
            Console.WriteLine("Show IB"); ;
        }

        void IA.Show() //явно
        {
            Console.WriteLine("Show IA");
        }

        public void Show()
        {
            Console.WriteLine("Show");
        }
          


    }
}
