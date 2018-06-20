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
        protected string middleName;

        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public Human(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public Human(string fName, string lName, DateTime date)
        {
            _firstName = fName;
            _lastName = lName;
            _birthDate = date;
        }

        public void Show()
        {
            WriteLine($"\nФамилия: {_lastName}\nИмя: {_firstName}\nДата рождения: {_birthDate.ToShortDateString()}");
        }
    }

    public class Employee : Human
    {
        new string middleName; 
        double _salary;
        public Employee(string fName, string lName) : base(fName, lName) { }

        public Employee(string fName, string lName, double salary)
            : base(fName, lName)
        {
            middleName = "jnkk";
            _salary = salary;
        }
        public Employee(string fName, string lName, DateTime date, double salary) : base(fName, lName, date)
        {
            base.middleName = "jj";
            _salary = salary;
        }

        public new void Show()//должно быть написано new, скрывает предупреждение
        {
            base.Show();

            WriteLine($"Заработная плата: {_salary} $");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Doe");
            employee.Show();
        
            employee = new Employee("Jim", "Beam", 1253);
            employee.Show();

            employee = new Employee("Jack", "Smith", DateTime.Now, 3587.43);
            employee.Show();
        }
    }
}
