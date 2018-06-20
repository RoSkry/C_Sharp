using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Class3
    {
        int _id;
        private string _firstName="john";
        string _lastName="Doe";
        public void print()
        {
            Console.WriteLine($"номер:{_id}, фамилия:{_lastName},имя:{_firstName}");
        }
        public Class3(string f,string l)
        {
            _firstName = f;
            _lastName = l;
        }
        public Class3()
        {

        }


    }
}
