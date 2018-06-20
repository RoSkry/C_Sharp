
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}, Родился: {BirthDate.ToLongDateString()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const double daysOfYear = 365.25;

            List<Student> students = new List<Student> {
                new Student {
                    FirstName = "John",
                    LastName = "Miller",
                    BirthDate = new DateTime(1997,3,12)
                },
                new Student {
                    FirstName = "Candice",
                    LastName = "Leman",
                    BirthDate = new DateTime(1998,7,22)
                },
                new Student {
                    FirstName = "Joey",
                    LastName = "Finch",
                    BirthDate = new DateTime(1996,11,30)
                },
                new Student {
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    BirthDate = new DateTime(1996,1,10)
                }
            };

            WriteLine($"\tТекущая дата: {DateTime.Now.ToLongDateString()}\n");
            //Console.WriteLine((DateTime.Now - students[0].BirthDate).Days);
            double days = ((new DateTime(2018, 1, 15) - new DateTime(1997, 5, 25)).Days / daysOfYear);
            Console.WriteLine(days);
            var query = from s in students
                        where (DateTime.Now - s.BirthDate).Days / daysOfYear > 20
                        select s;

            WriteLine("\tСтуденты старше 20 лет:");

            foreach (var item in query)
            {
                WriteLine(item);
            }
        }
    }
}