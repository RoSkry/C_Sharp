using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class StudentCard
    {
        public int  Number{ get; set; }
        public string Series { get; set; }
        public override string ToString()
        {
            return $"Билет:{Series}{Number}";
        }
    }
}
