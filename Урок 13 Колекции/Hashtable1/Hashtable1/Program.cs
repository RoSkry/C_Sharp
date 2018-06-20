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
            Hashtable hash = new Hashtable();
            hash.Add(1, "John");
            hash.Add("two", new Student { Name = "Jack" });

            WriteLine("----------- Вывод ключ-значение ------------\n");
            foreach (object item in hash.Keys)
            {
                WriteLine("Ключ: " + item + " Значение: " + hash[item]);
            }

            hash.Add("Pi", 3.14159);

            WriteLine("\n----- Коллекция значений после добавление элемента -----\n");
            foreach (object item in hash.Values)
                WriteLine(item);

            WriteLine("\n----- Удаление элемента по ключу \"two\" ------\n");
            hash.Remove("two");
            WriteLine($"Существует ли элемент \"two\": {hash.ContainsKey("two")}"); // false
        }
    }
}

