using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static T MaxElement<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];
            foreach (T item in arr)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] arrInt = new int[] { 22, 63, 718, 14, 5 };

            //реальный тип для параметра типа указывается явно
            WriteLine($"Максимальный элемент: {MaxElement<int>(arrInt)}");

            double[] arrDouble = new double[] { 45.62, 77.354, 18.48, 11.3 };

            //реальный тип определяется по типу переданного массива
            WriteLine($"Максимальный элемент: {MaxElement(arrDouble)}");
        }
    }
}

