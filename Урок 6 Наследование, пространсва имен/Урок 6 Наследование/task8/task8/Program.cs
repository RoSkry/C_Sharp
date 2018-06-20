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
            WriteLine($"\nФамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToLongDateString()}");
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
    }

    class Manager : Employee
    {
        string _fieldActivity;

        public Manager(string fName, string lName, DateTime date, double salary, string activity) : base(fName, lName, date, salary)
        {
            _fieldActivity = activity;
        }

        public override void Print()
        {
            Write($"\nМенеджер. Сфера деятельности: {_fieldActivity}");
            base.Print();
        }
    }
    class Scientist : Employee
    {
        string _scientificDirection;
        public Scientist(string fName, string lName, DateTime date, double salary, string direction) : base(fName, lName, date, salary)
        {
            _scientificDirection = direction;
        }
        public override void Print()
        {
            Write($"\nУченый. Научное направление: {_scientificDirection}");
            base.Print();
        }
    }
    class Specialist : Employee
    {
        string _qualification;
        public Specialist(string fName, string lName, DateTime date, double salary, string qualification) : base(fName, lName, date, salary)
        {
            _qualification = qualification;
        }
        public override void Print()
        {
            Write($"\nСпециалист. Квалификация: {_qualification}");
            base.Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human[] people = {
              new Manager("John", "Doe", new DateTime(1995,7,23), 3500, "продукты питания"),
              new Scientist("Jim", "Beam", new DateTime(1956,3,15), 4253, "история"),
              new Specialist("Jack", "Smith", new DateTime(1996,11,5), 2587.43,"физика")
            };

            foreach (Human item in people)
            {
                item.Print(); // полиморфизм
            }
        }
    }
}
