using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Container
    {
        public int Priority { get; set; }
       public ArrayList worker { get; set; } 
       public Container(ArrayList w,int p)
        {
            Priority = p;
            worker = w;
        }


    }
}
                                                                                   