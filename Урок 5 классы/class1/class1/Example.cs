using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    // свойства 
    class Example
    {

        int _num;
        public int Num
        {
            get { return _num; }
            set {if(value<0)
                {
                    new Exception("Oshibka");
                }
                _num = value; }
        }
     
        string _lastName;
        //public string Lastname
        //{
        //    get { return _lastName; }
        //    set { _lastName = value;}
        //}

   
        public string LastName { get; set; }

        //string _firstname="dfgghj";
        public string Firstname { get; private set; } = "ghj";

    }
}
