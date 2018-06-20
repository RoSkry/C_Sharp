using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account();
            Account.ObjectFormat = true;
            ac.Save();
            ac.Load();

            Account.ObjectFormat = false;
            ac.Save();
            ac.Load();
        }
    }
}
