using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace SimpleProject
{
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

    class FirstNameComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return string.Compare(x.FirstName, y.FirstName);
        }
    }

    class Program
    {
        static int SortBirthDate(Student student1, Student student2)
        {
            return student1.BirthDate.CompareTo(student2.BirthDate);
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
            WriteLine("\nСортировка по дате рождения:");

            //group.Sort(new Comparison<Student>(Program.SortBirthDate));
            //group.Sort(new Comparison<Student>(SortBirthDate));
            group.Sort(SortBirthDate);
          

            foreach (Student item in group)
            {
                WriteLine(item);
            }

            WriteLine("\nСортировка по фамилии:");
            group.Sort();

            foreach (Student item in group)
            {
                WriteLine(item);
            }

            WriteLine("\nСортировка по имени:");
            IComparer<Student> iComp = new FirstNameComparer();
            group.Sort(iComp);

            foreach (Student item in group)
            {
                WriteLine(item);
            }
        }
    }
}
