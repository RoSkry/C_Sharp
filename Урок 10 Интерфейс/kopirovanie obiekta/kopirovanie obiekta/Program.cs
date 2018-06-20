using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SimpleProject
{
    class Child : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }

        public object Clone()
        {
            // поверхностная копия объекта, если нет ссылочных полей
            return this.MemberwiseClone();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child1 = new Child { Name = "Arthur", Age = 12 };

            WriteLine("Начальные значения:");
            Child child2 = (Child)child1.Clone();
            WriteLine($"Ребенок №1: {child1}");
            WriteLine($"Ребенок №2: {child2}");

            child2.Age = 14; // изменяем возраст

            WriteLine("\nЗначения после изменения возраста:");
            WriteLine($"Ребенок №1: {child1}");
            WriteLine($"Ребенок №2: {child2}");
        }
    }
}