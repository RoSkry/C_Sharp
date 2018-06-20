﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{

    public delegate double CalcDelegate(double x, double y);

    public class Calculator
    {
        public double Add(double x,double y)
        {
            return x + y;
        }
        public static double Sub(double x,double y)
        {
            return x - y;
        }
        public double Mult(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if(y!=0)
            return x /y;
            throw new DivideByZeroException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
           Console.Write("Введите выражения: ");
           string expression = Console.ReadLine();
            char sign = ' ';
            //определения знака арифметического действия 

            foreach(char item in expression)
            {
                if(item=='+'|| item=='-'|| item=='*'|| item=='/')
                {
                    sign = item;
                    break;
                }
            }
            try
            {
                string[] numbers = expression.Split(sign);// получение значений операндов
                CalcDelegate del = null;
                switch (sign)
                {
                    case '+': del = new CalcDelegate(calc.Add);break;
                    case '-': del = new CalcDelegate(Calculator.Sub); break;
                    case '*': del = calc.Mult;//гркповое преобразование типов
                        break;
                    case '/': del = calc.Div; break;
                    default:
                        throw new InvalidOperationException();
                }


                Console.WriteLine($"Результат:{del(double.Parse(numbers[0]),double.Parse(numbers[1]))}");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

        }
    }
}
