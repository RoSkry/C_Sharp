using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Ostrich:Bird,IRun
    {
        public Ostrich()
        {
            name = "Ostrich";
        }
        public void Run()
        {
            Console.WriteLine(name+"run");
        }
    }
}
