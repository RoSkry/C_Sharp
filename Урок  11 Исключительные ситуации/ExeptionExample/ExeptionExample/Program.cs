using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionExample
{
    public class A
    {
        private int num;

        public A(int num)
        {
            this.num = num;
        }
        public void MethodA()
        {
            Console.WriteLine("Entering MethodA");
            try
            {
                this.MethodB();
                Console.WriteLine("Class A");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                // throw; передача исходного объекта исключения
                Console.WriteLine("Exception MethodA");
            }
            Console.WriteLine("Leaving MethodA");
        }
        public void MethodB()
        {
            Console.WriteLine("Entering MethodB");
            if (this.num > 10 || this.num < 0)
                throw new System.Exception("Exception in MethodB - out of range");
            Console.WriteLine("Leaving MethodB");
        }
    }
    public class Tester
    {
        public static void Main()
        {
            Console.WriteLine("Entering Main");
            A a = new A(15);
            try
            {
                a.MethodA();
                Console.WriteLine("Main");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Main");

                // причина возникновения исключения
                Console.WriteLine(e.Message);
                // имена, сигнатуры и нахождение методов, вызов которых привел к возникновению исключения
                Console.WriteLine(e.StackTrace);
                // метод, сгенерировавший исключение
                Console.WriteLine(e.TargetSite);
            }
            Console.WriteLine("Leaving Main");
        }
    }

}
