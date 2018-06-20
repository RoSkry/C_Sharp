using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(5);//5 вместимость 
            ArrayList list1 = new ArrayList(new int[] { 1, 84, 383 });
            list1.Add("Hello");
            list1.Add(8.34);
            list1.Add(new Exception("Error"));
            foreach(object item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
