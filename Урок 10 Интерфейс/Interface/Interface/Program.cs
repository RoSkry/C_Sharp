using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            //auditory.GetEnumerator();

            //auditory.Sort(); 
            //auditory.Sort(new DateComparer());

            //foreach(Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
            //Student s = new Student();
            //Student st = s;

           Console.WriteLine("\n+++++++++++++++++++++ копирование ++++++++++++\n");

            Student student1 = new Student { FirstName = "Greg", LastName = "Carter", BirthDate = new DateTime(1999, 12, 5), StudentCard = new StudentCard { Number = 784523, Series = "ММ" } };
            Student student2 = (Student)student1.Clone();

            Console.WriteLine(student1);
            Console.WriteLine(student2);

            Console.WriteLine("\n++++++++++++++++++++++ изменение +++++++++++++\n");

            student2.StudentCard.Number = 817423;
            student2.StudentCard.Series = "КК";

            Console.WriteLine(student1);
            Console.WriteLine(student2);



        }
    }      
}          
           