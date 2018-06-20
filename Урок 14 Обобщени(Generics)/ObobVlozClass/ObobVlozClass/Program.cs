using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SimpleProject
{
    class A<T>
    {
        public class Inner
        {
        }
    }

    class B<T>
    {
        //вложенный класс имеет собственный список параметров типа
        public class Inner<U>
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //для использования вложенного класса 
            //необходимо указать реальный тип вместо параметра типа внешнего класса
            A<int>.Inner a = new A<int>.Inner();
            WriteLine(a);
            A<double>.Inner a1 = new A<double>.Inner();
            WriteLine(a1);

            //для использования вложенного класса 
            //необходимо указать реальный тип вместо параметра типа вложенного класса
            B<int>.Inner<string> b = new B<int>.Inner<string>();
            WriteLine(b);
        }
    }
}