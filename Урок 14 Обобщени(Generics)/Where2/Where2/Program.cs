using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace SimpleProject
{
    class DateComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return DateTime.Compare(x.BirthDate, y.BirthDate);
        }
    }

    class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}, Родился: {BirthDate.ToLongDateString()}";
        }

        public int CompareTo(Student other)
        {
            return LastName.CompareTo(other.LastName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> auditory = new List<Student> {
                new Student {
                    FirstName ="John",
                    LastName ="Miller",
                    BirthDate =new DateTime(1997,3,12)
                },
                new Student {
                    FirstName ="Candice",
                    LastName ="Leman",
                    BirthDate =new DateTime(1998,7,22)
                }
            };

            WriteLine("+++++++++++++++++ список студентов ++++++++++\n");

            foreach (Student student in auditory)
            {
                WriteLine(student);
            }

            WriteLine("\n+++++++++++++++ сортировка по фамилии ++++++++\n");

            auditory.Sort();

            foreach (Student student in auditory)
            {
                WriteLine(student);
            }

            WriteLine("\n+++++++++ сортировка по дате рождения ++++++++\n");

            auditory.Sort(new DateComparer());

            foreach (Student student in auditory)
            {
                WriteLine(student);
            }
        }
    }
}
