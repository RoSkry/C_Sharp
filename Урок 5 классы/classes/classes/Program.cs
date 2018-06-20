using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        private static void MyFunction(int i, int[] myArr)
        {
            Console.WriteLine("Внутри метода MyFunction до изменения i = " + i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " "); 
            Console.WriteLine("}");

            i = 100;
            myArr = new int[] { 3, 2, 1 };

            Console.WriteLine("Внутри метода MyFunction после изменения i = " + i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");
        }

        //static void MyFunction(int[] MyArr, int i)
        //{
        //    MyArr[0] = 100;
        //    i = 100;
        //}
        static void Main(string[] args)
        {
            int i = 10;
            int[] myArr = { 1, 2, 3 };

            Console.WriteLine("Внутри метода Main до передачи в метод MyFunction i = " + i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");

            MyFunction(i, myArr);
            
            Console.WriteLine("Внутри метода Main после передачи в метод MyFunction i = " + i);
            Console.Write("MyArr { ");
            foreach (int val in myArr)
                Console.Write(val + " ");
            Console.WriteLine("}");

            //int і = 0;
            //int[] MyArr = { 0, 1, 2, 4 };
            //Console.WriteLine("i = " + і);
            //Console.WriteLine("MyArr[0] = " + MyArr[0]);
            //Console.WriteLine("Вызов MyFunction");
            //MyFunction(MyArr, і);
            //Console.WriteLine("i = " + і);
            //Console.WriteLine("MyArr[0] = " + MyArr[0]);
            //Car myCar = new Car();
            //for (int i = 0; i <= 10; i++)
            //{
            //    myCar.SpeedUp(5);
            //    myCar.PrintState();
            //}

            //Console.WriteLine(Student.country);
            //Console.WriteLine(Student.getUniver());
            //Student st = new Student("Doe","Kharkiv");
            //st.show();

        }
    }
}
