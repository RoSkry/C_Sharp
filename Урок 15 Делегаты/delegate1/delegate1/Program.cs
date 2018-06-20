using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1  
{                    
       public delegate int IntDelegete(double d);
    class Program    
    {                
       public static int M1(double c)
        {            
            return (int)c;
        }      
             
        static void Main(string[] args)
        {
            double b = double.Parse(Console.ReadLine());
            IntDelegete del = new IntDelegete(M1);
            Console.WriteLine(del(b));

        }
    }
}
