using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace SimpleProject
{
    class DateComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).BirthDate, (y as Student).BirthDate);
            }
            throw new NotImplementedException();
        }
    }

    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}, Родился: {BirthDate.ToLongDateString()}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList auditory = new ArrayList {
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
