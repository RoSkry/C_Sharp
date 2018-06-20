using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new { FirstName = "John", LastName = "Doe", Salary = 7456.32 };
            Console.WriteLine($"Строка: {worker}");
            Console. WriteLine($"Тип: {worker.GetType()}");
            Console.WriteLine($"Хеш-код: {worker.GetHashCode()}");
        }
    }
}
