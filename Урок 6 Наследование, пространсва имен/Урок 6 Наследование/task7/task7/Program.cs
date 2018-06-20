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

        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string fName, string lName, DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _birthDate = date;
        }

       

        public virtual void Print()
        {
            WriteLine($"\nФамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToShortDateString()}");
        }
    }

    public class Employee : Human
    {
        double _salary;

        public Employee(string fName, string lName, DateTime date, double salary) : base(fName, lName, date)
        {
            _salary = salary;
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Заработная плата: {_salary} $");
        }

        //public override void Print()
        //{

        //    WriteLine($"Заработная плата: {_salary} $");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human employee = new Employee("Jack", "Smith", DateTime.Now, 3587.43);
            
            employee.Print();
        }
    }
}