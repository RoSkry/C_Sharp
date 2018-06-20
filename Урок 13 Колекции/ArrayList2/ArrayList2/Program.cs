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
            Write("Исходная коллекция: ");
            ArrayList arrayList = new ArrayList(new int[] { 1, 2, 3, 4 });
            foreach (int i in arrayList)
            {
                Write($"{i} ");
            }

            Write("\n\nВставка элемента: ");
            arrayList.Insert(2, "Hello");
            foreach (object item in arrayList)
            {
                Write($"{item} ");
            }

            Write("\n\nУдаление элемента: ");
            arrayList.RemoveAt(3);
            foreach (object item in arrayList)
            {
                Write($"{item} ");
            }

            WriteLine("\n\nИндекс элемента \"Hello\": " + arrayList.IndexOf("Hello"));

            Write("\nПолучение диапазона: ");
            ArrayList days = new ArrayList(new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            ArrayList onlyWork = new ArrayList(days.GetRange(1, 5));
            foreach (string s in onlyWork)
            {
                Write($"{s} ");
            }

            Write("\n\nСортировка коллекции: ");
            onlyWork.Sort();
            foreach (string s in onlyWork)
            {
                Write($"{s} ");
            }

            WriteLine();
        }
    }
}