using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Student
    {
        string _lastName;
        
        public const string country = "Ukraine";
        static string _university;/*= "Step"*/
        public static string getUniver()//внутри метода только статические поля 
        {
            return _university;
        }
        public void show()
        {
            Console.WriteLine($"{_lastName},{_university},{country}");
        }
        public readonly string town;
        public Student(string lastName, string t)
        {
            _lastName = lastName;
            town = t;
         }

        static Student()
        {
            _university = "Step";
        }

            
    
        }
    }

