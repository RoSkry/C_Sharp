using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    public delegate T AddDelegate<T>(T x, T y);

    public class ExampleClass
    {
        public int AddInt(int x, int y)
        {
            return x + y;
        }
        public double AddDouble(double x, double y)
        {
            return x + y;
        }
        public static char AddChar(char x, char y)
        {
            return (char)(x + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass example = new ExampleClass();

            AddDelegate<int> delInt = example.AddInt;
            WriteLine($"Сумма целых чисел: {delInt(8, 6)}");

            AddDelegate<double> delDouble = example.AddDouble;
            WriteLine($"Сумма вещественных чисел: {delDouble(45.67, 62.81)}");

            AddDelegate<char> delChar = ExampleClass.AddChar;
            WriteLine($"Сумма символов: {delChar('S', 'h')}");
        }
    }
}