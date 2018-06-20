using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace SimpleProject
{
    public delegate void ExamDelegate(string t);

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void ExamStudent(string task)
        {
            WriteLine($"Студент {LastName} решил {task}");
        }
    }

    class Teacher
    {
       public ExamDelegate examEvent;

        public void ExamTeacher(string task)
        {
            if (examEvent != null)
            {
                examEvent(task);
            }
        }
    }

    class Program
    {
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

            Teacher teacher = new Teacher();

            foreach (Student item in group)
            {
                teacher.examEvent += item.ExamStudent;
            }

            teacher.examEvent.Invoke("Всем 2!");  // обращение напрямую

                         teacher.examEvent = null; // новое значение
         
                teacher.ExamTeacher("Задача"); // ни к чему не приведет   
      
          
        }
    }
}
