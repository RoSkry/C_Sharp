using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        class Example
        {

        }

        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(n);
            Example ex = new Example();
            Console.WriteLine(ex);//пространство имен Example 
        }
    }
}
