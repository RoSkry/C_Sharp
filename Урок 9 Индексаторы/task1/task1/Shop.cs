using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Shop
    {
        Laptop[] LaptopArr;
        public Shop(int size)
        {
            LaptopArr = new Laptop[size];
        }
        public int Length
        {
            get
            {
                return LaptopArr.Length;
            }
        }
        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                {
                    return LaptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < Length)
                {
                    LaptopArr[index] = value;
                }
            }


        }
    }
}
