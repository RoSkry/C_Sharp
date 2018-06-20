using System;
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
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public override string ToString()
        {
            return $"Студенческий билет: {Series} {Number}";
        }
    }

    class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {FirstName}, Родился: {BirthDate.ToLongDateString()}, {StudentCard}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public object Clone() // глубокое копирование
        {
            Student temp = (Student)this.MemberwiseClone(); // поверхностная копия
            temp.StudentCard = new StudentCard { Series = this.StudentCard.Series, Number = this.StudentCard.Number };

            return temp;
        }
    }

    class Auditory : IEnumerable
    {
        Student[] students =
            {
                new Student {
                    FirstName ="John",
                    LastName ="Miller",
                    BirthDate =new DateTime(1997,3,12),
                    StudentCard =new StudentCard { Number=189356, Series="AB" }
                },
                new Student {
                    FirstName ="Candice",
                    LastName ="Leman",
                    BirthDate =new DateTime(1998,7,22),
                    StudentCard =new StudentCard { Number=345185, Series="XA" }
                },
                new Student {
                    FirstName ="Joey",
                    LastName ="Finch",
                    BirthDate =new DateTime(1996,11,30),
                    StudentCard =new StudentCard { Number=258322, Series="AA" }
                },
                new Student {
                    FirstName ="Nicole",
                    LastName ="Taylor",
                    BirthDate =new DateTime(1996,5,10),
                    StudentCard =new StudentCard { Number=513484, Series="AA" }
                }
            };

        public void Sort()
        {
            Array.Sort(students);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();

            WriteLine("++++++++++++++++++++ список студентов ++++++++++\n");

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

            WriteLine("\n++++++++++++ сортировка по дате рождения +++++\n");

            auditory.Sort(new DateComparer());

            foreach (Student student in auditory)
            {
                WriteLine(student);
            }

            WriteLine("\n+++++++++++++++++++++ копирование ++++++++++++\n");

            Student student1 = new Student { FirstName = "Greg", LastName = "Carter", BirthDate = new DateTime(1999, 12, 5), StudentCard = new StudentCard { Number = 784523, Series = "ММ" } };
            Student student2 = (Student)student1.Clone();

            WriteLine(student1);
            WriteLine(student2);

            WriteLine("\n++++++++++++++++++++++ изменение +++++++++++++\n");

            student2.StudentCard.Number = 817423;
            student2.StudentCard.Series = "КК";

            WriteLine(student1);
            WriteLine(student2);
        }
    }
}