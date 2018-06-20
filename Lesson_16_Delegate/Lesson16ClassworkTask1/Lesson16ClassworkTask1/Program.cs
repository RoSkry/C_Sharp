using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16ClassworkTask1
{

    using System;
    using static System.Console;

    namespace SimpleProject
    {
        public delegate double CalcDelegate(double x, double y);

        public class Calculator
        {
            public double Add(double x, double y)
            {
                Console.WriteLine("Add");
                return x + y;
            }
            public static double Sub(double x, double y)
            {
                Console.WriteLine("Sub");
                return x - y;
            }
            public double Mult(double x, double y)
            {
                Console.WriteLine("Mult");

                return x * y;
            }
            public double Div(double x, double y)
            {
                Console.WriteLine("Div");

                if (y != 0)
                {
                    return x / y;
                }
                throw new DivideByZeroException();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Calculator calc = new Calculator();

                CalcDelegate del = new CalcDelegate(calc.Add);

                del += new CalcDelegate(Calculator.Sub);
                del += calc.Mult; // групповое преобразование методов
                del += calc.Div;
                Console.WriteLine("Example 1");
                Console.WriteLine($"Result:{del(6.0, 2.0)} \n\n\n");
                Console.WriteLine("Example 2");
                foreach (CalcDelegate item in del.GetInvocationList())
                {
                    Console.WriteLine($"Result:{item(6.0, 2.0)} \n\n\n");
                }
                Console.WriteLine("Example 2");

                Delegate[] delArr = del.GetInvocationList();
                if (delArr[2] is CalcDelegate)
                {
                    Console.WriteLine((delArr[2] as CalcDelegate).Invoke(2,2));

                }


            }
        }
    }

}
