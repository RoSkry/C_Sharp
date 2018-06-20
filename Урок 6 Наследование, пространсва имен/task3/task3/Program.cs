using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    public class Human
    {
        int _id;
        protected string firstName;
        protected string lastName;
    }
    public class Employee:Human 
    {
        double _salary;
        public Employee(string fName, string lName, double salary)
        {
            firstName = fName;
            lastName = lName;
            _salary = salary;
            //_id = 34; Error
        }

        public void Print()
        {
            WriteLine($"Фамилия: {lastName}\nИмя: {firstName}\nЗаработная плата: {_salary} $");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Doe", 2563.57);
            employee.Print();
        }
    }
}
