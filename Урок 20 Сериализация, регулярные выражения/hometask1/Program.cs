using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Election el = new Election();

            //Console.WriteLine(Enum.GetValues(typeof(Candedates)).GetValue(1));
            Console.WriteLine("Первый тур");
                if(!el.Show())
            {
                    
                Console.WriteLine("Второй тур");
                if (!el.Show())
                {
                    Console.WriteLine("Третий тур");
                    if (!el.Show())
                        Console.WriteLine("Выборы окончены никто не выиграл");
                }

            }
         
        
        }
    }
}
