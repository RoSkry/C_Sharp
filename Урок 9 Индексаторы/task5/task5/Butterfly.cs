using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Butterfly:Insect,IFly
    {
        public void Fly()
        {
            Console.WriteLine("Butterfly fly");
        }
    }
}
