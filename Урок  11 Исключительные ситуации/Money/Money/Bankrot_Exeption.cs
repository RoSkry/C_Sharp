using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Bankrot_Exeption : ApplicationException
    {

        public Bankrot_Exeption():base("Сумма не может быть меньше нуля")
        {}

        public Bankrot_Exeption(string message) : base(message)
        {
        }
    }
}
