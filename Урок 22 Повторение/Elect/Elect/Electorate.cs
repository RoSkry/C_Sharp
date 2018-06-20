using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elect
{
    class Electorate
    {
        public static int Voiting ()
        {
            return new Random().Next(6);
        }
    }
}
