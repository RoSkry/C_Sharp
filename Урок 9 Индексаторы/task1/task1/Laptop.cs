using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Laptop
    {
        public string Vendor { get; set; } //производительность 
        public double Price { get; set; }
        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }


    }
}
