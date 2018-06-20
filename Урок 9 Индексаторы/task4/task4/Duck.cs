using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Duck:Bird,IFly,ISwim
    {
        public Duck()
        {
            name = "Duck";

        }
        public void Fly()
        {                                              
            Console.WriteLine(name+"fly");
        }
        public void Swim()
        {
            Console.WriteLine(name + "swim");
        }

    }
    
}
