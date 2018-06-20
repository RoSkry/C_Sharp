using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            Write("Метод Push(): ");
            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            foreach (string item in stack)
            {
                Write($"{item} ");
            }

            Write("\n\nМетод Pop(): ");
            stack.Pop();
            foreach (string item in stack)
            {
                Write($"{item} ");
            }

            WriteLine($"\n\nМетод Peek(): {(string)stack.Peek()}");

            WriteLine("\nСуществует ли элемент \"ten\": " + stack.Contains("ten")); // false
            WriteLine("\nСуществует ли элемент \"two\": " + stack.Contains("two")); // true

            Write("\nМетод CopyTo(): ");
            string[] strArr = new string[stack.Count];
            stack.CopyTo(strArr, 0);
            foreach (string item in strArr)
            {
                Write($"{item} ");
            }

            WriteLine("\n\nКоличество элементов: " + stack.Count); // 3
            stack.Clear();
            WriteLine("\nКоличество элементов после вызова метода Clear(): " + stack.Count); // 0
        }
    }
}
