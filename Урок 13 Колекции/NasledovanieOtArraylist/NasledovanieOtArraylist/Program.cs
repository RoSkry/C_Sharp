using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace SimpleProject
{
    public class SortedArrayList : ArrayList
    {
        public void AddSorted(object item)
        {
            int position = BinarySearch(item);

            if (position < 0)
            {
                position = ~position;
            }

            Insert(position, item);
        }

        public void ModifySorted(object item, int index)
        {
            RemoveAt(index);

            int position = BinarySearch(item);

            if (position < 0)
            {
                position = ~position;
            }

            Insert(position, item);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedArrayList sortedAL = new SortedArrayList();

            WriteLine("----------- Начальные значения ------------\n");
            sortedAL.AddSorted(200);
            sortedAL.AddSorted(-7);
            sortedAL.AddSorted(0);
            sortedAL.AddSorted(-20);
            sortedAL.AddSorted(56);
            sortedAL.AddSorted(200);

            foreach (int i in sortedAL)
            {
                Write(i + " ");
            }
            WriteLine();

            WriteLine("\n----------- Изменение значений ------------\n");
            sortedAL.ModifySorted(3, 5);
            foreach (int i in sortedAL)
            {
                Write(i + " ");
            }
            WriteLine();
            sortedAL.ModifySorted(-1, 2);
            foreach (int i in sortedAL)
            {
                Write(i + " ");
            }
            WriteLine();
            sortedAL.ModifySorted(2, 4);
            foreach (int i in sortedAL)
            {
                Write(i + " ");
            }
            WriteLine();
            sortedAL.ModifySorted(7, 3);

            foreach (int i in sortedAL)
            {
                Write(i + " ");
            }
            WriteLine();
        }
    }
}

