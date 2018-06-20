using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace SimpleProject
{
    class Student
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return $"Имя: {Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(3, 6.7);
            sortedList.Add(2, new Student { Name = "Jack" });
            sortedList.Add(1, "one");
        
            WriteLine("----------- Вывод ключ-значение ------------\n");
            foreach (object item in sortedList.Keys)
            {
                WriteLine($"Ключ: {item} Значение: {sortedList[item]}");
            }

            WriteLine("\n------- Вывод ключ-значение по индексу --------\n");
            for (int i = 0; i < sortedList.Count; i++)
            {
                WriteLine($"Ключ: {sortedList.GetKey(i)} Значение: {sortedList.GetByIndex(i)}");
            }

            WriteLine("\n----------- Коллекция значений ------------\n");
            foreach (object item in sortedList.Values)
                WriteLine(item);

            WriteLine("\n----- Удаление элемента по ключу 3 ------\n");
            sortedList.Remove(3);

            WriteLine($"Существует ли элемент 3: {sortedList.ContainsKey(3)}"); // false
        }
    }
}
