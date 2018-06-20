using System;
using static System.Console;

namespace SimpleProject
{
    public delegate double AnonimDelegateDouble(double x, double y);

    public delegate int AnonimDelegateInt(int n);

    public delegate void AnonimDelegateVoid();

    class Dispacher
    {
        public event AnonimDelegateDouble eventDouble;
        public event AnonimDelegateInt eventInt;

        public double OnEventDouble(double x, double y)
        {
            if (eventDouble != null)
            {
                return eventDouble(x, y);
            }
            throw new NullReferenceException();
        }

        public int OnEventInt(int n = 0)
        {
            if (eventInt != null)
            {
                return eventInt(n);
            }
            throw new NullReferenceException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\tБлочное лямбда выражение");

            Dispacher dispacher = new Dispacher();

            // явная типизация
            dispacher.eventDouble += (double a, double b) =>
            {
                if (b != 0)
                {
                    return a / b;
                }
                throw new DivideByZeroException();
            };

            double n1 = 5.7, n2 = 3.2;

            WriteLine($"{n1} / {n2} = {dispacher.OnEventDouble(n1, n2)}"); // вызов

            WriteLine("\tОдиночное лямбда выражение");

            int number1 = 5, number2 = 6;

            dispacher.eventInt += n => number1 + n; // неявная типизация

            WriteLine($"{number1} + {number2} = {dispacher.OnEventInt(number2)}"); // вызов

            WriteLine("\tПрименение с делегатом");

            AnonimDelegateVoid voidDel = new AnonimDelegateVoid(() =>  WriteLine("Ok!"));

            voidDel += () => { WriteLine("Bye!"); };

            voidDel(); // вызов
        }
    }
}