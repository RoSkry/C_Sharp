using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    class GenericClass<T>
    {
        public void M1(T obj)
        {
            WriteLine($"Параметр: {obj}");
        }

        public virtual void M2(T data)
        {
            WriteLine($"Generic: {data}");
        }
    }
    class InheritClass : GenericClass<int> // необходимо явно указывать тип
    {
        public override void M2(int data)
        {
            WriteLine($"Inherit: {data}");
        }
    }
    class Program
    {
        static void Main()
        {
            InheritClass obj = new InheritClass();
            obj.M1(45);
            obj.M2(82);
        }
    }
}

