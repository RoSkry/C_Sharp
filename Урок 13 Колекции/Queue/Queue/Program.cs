using System;
using System.Collections;
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
            Write("Метод Enqueue(): ");
            Queue queue = new Queue();
            for (int i = 1; i < 4; i++)
            {
                queue.Enqueue(i);
            }

            foreach (int item in queue)
                Write($"{item} ");

            WriteLine($"\n\nМетод Dequeue(): {queue.Dequeue()}\n");

            WriteLine($"Существует ли элемент 1: {queue.Contains(1)}\n");

            WriteLine($"Метод Peek() {queue.Peek()}\n");

            WriteLine($"Существует ли элемент 2: {queue.Contains(2)}");
        }
    }
}