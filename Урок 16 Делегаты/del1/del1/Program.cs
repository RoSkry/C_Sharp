using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{

    public delegate double CalcDelegate(double x, double y);

    public class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
             return x - y; 
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            throw new DivideByZeroException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            CalcDelegate del = calc.Add;
            del += Calculator.Sub;
            del += calc.Mult;
            del += calc.Div;
            del -= calc.Mult;
            foreach (CalcDelegate item in del.GetInvocationList())
            {
                Console.WriteLine($"Результат:{item(5.5,4.7)}");
            }

            Delegate[] delArr = del.GetInvocationList();
            if(delArr[2] is CalcDelegate)
            Console.WriteLine((delArr[2] as CalcDelegate).Invoke(5.5, 4.7));


        }
    }
}
