using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    interface IPerson
    {
        string LastName { get; set; }
        int Age { get; }
        string Gender { set; }
    }
    class Employee : IPerson
    {
        int _age;
        public int Age
        {
            get
            {
                return _age; ;
            }
        }

        public string Gender
        {
            get; set;
        }

        public string LastName
        {
            get;
            set;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
