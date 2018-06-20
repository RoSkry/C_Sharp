using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BankClient
    {
        public Client Client { get; set; }
    }

    class Bank
    {
        public List<BankClient> MyProperty { get; set; }
    }
}
