using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledInterface
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Show();
            ((IA)c1).Show();

            (c1 as IA).Show();
             
            IB iB = new Class1();
           
            iB.Show();
                       
        }
    }
}
