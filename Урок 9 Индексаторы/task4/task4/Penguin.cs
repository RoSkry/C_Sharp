using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Penguin : Bird, ISwim
    {
        public Penguin()
        {

            name = "Penguin";
           
        }
        public void Swim()
        {
            Console.WriteLine(name+"swim");
        }
    }
}
