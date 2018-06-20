using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
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
        static bool OnlySpring(Student student)
        {
            return student.BirthDate.Month >= 3 && student.BirthDate.Month <= 5;
        }

        static void Main(string[] args)
        {
            List<Student> group = new List<Student> {
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
                    BirthDate = new DateTime(1996,5,10)
                }
            };
            WriteLine("Рожденные весной:");

            //List<Student> students = group.FindAll(new Predicate<Student>(Program.OnlySpring));
            //List<Student> students = group.FindAll(new Predicate<Student>(OnlySpring));
            List<Student> students = group.FindAll(OnlySpring);

            foreach (Student item in students)
            {
                WriteLine(item);
            }
        }
    }
}
