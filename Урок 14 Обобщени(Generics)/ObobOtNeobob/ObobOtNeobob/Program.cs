using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    class BasicClass
    {
        protected int age;
    }

    class GenericClass<T> : BasicClass
    {
        public void M1(T obj)
        {
            age = 57;
            WriteLine($"Basic: {age}\nGeneric: {obj}");
        }
    }

    class Program
    {
        static void Main()
        {
            GenericClass<int> obj = new GenericClass<int>();
            obj.M1(45);
        }
    }
}
