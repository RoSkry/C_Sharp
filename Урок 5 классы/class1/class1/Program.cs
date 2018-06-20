using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.Num = 5;
            Console.WriteLine(ex.Num);
            Example ex1 = new Example { Num = 6,LastName="ghf"};
            Console.WriteLine(ex1.Num+ ex1.LastName);
            Console.WriteLine(ex1.Firstname);

        }


    }
}

