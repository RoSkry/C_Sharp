using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{



    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(3);
            shop[0] = new Laptop { Vendor = "Asus", Price = 1500 };

            shop[4]= new Laptop { Vendor = "Asus", Price = 1500 };//не запишется  
            try {
              
                for (int i = 0; i <shop.Length; i++)
            {
                    Console.WriteLine(shop[i]);
            }
                Console.WriteLine(shop[4]);
          }
            catch { }
        }
    }
}
