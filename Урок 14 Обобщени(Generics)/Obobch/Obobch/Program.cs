using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obobch
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);//boxing
            arr.Add(2.3);

            short s = (short)arr[0];//unboxing

            Console.WriteLine(arr[0]);//boxing


            int n = 45;
            object obf = n;//boxing значимый в ссылочный

            int m = (int)obf;//unboxing 
            Console.WriteLine(m);//boxing
        }
    }
}
