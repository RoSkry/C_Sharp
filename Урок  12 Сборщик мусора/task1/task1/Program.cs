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
            //           try {
            //           Console.WriteLine("Enter n");
            //           int n = int.Parse(Console.ReadLine());
            //           if(n<=0)
            //               {
            //                   throw new ArgumentOutOfRangeException();
            //               }

            //               double log = 100 / Math.Log(n);
            //               Console.WriteLine(log);

            //}
            //           catch(Exception i)
            //           {
            //               Console.WriteLine(i.Message);
            //           }

            //byte b = 100;
            //b = (byte)(b + 200);
            //Console.WriteLine(b);
            byte b= 100;
            try
            {
                checked//ошибка
                {
                    b = (byte)(b + 200);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            b = 255;
            unchecked// пропустит ошибку
            {
                b++;
            }
            Console.WriteLine(unchecked((byte)(b+300)));

        }
    }
}
