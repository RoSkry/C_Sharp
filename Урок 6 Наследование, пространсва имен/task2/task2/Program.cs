using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using X = NS;
using Y = NS1;
namespace M
{
    public class ClassM
    {
        public int m = 3;

        public static void Main()
        {
            //X.Class objA = new X.Class(); Error
            X::Class objA = new X::Class();
            objA.Print();
            Y::Class objB = new Y::Class();
            objB.Print();
        }
    }
    public class X
    {
        //...
    }
}