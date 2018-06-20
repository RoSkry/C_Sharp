using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Menu
    {
        //Ввод первоначальной суммы  
        public int Enter()
        {
            Console.WriteLine("Введите сумму денег");
            double grn = double.Parse(Console.ReadLine());
            if (grn < 0) throw new Bankrot_Exeption();
            return (int)(grn * 100);
        }
        // выбор того, что хоти сделать с суммой
        public int Choice()
        {

            Console.WriteLine("Что вы хотите сделать?");
            Console.WriteLine("1-добавить сумму");
            Console.WriteLine("2-снять сумму");
            Console.WriteLine("3-разделить сумму на число");
            Console.WriteLine("4-умножить на число сумму");
            Console.WriteLine("5-увеличить на копейку");
            Console.WriteLine("6-уменьшить на копейку");
            Console.WriteLine("7-равны ли суммы");
            Console.WriteLine("8-какая сумма больше");
            int num = int.Parse(Console.ReadLine());
            return num;
          
        }
        public Money Sum()
        {
            Console.WriteLine("Введите сумму которую хотите добавить в ");
            double add = double.Parse(Console.ReadLine());
            if(add<0)  throw new Bankrot_Exeption();
            return new Money() { Summa= (int)(add * 100) };

        }
        public int Minus()
        {
            Console.WriteLine("Введите сумму которую хотите вычесть ");
            double minus = double.Parse(Console.ReadLine());
            if (minus < 0) throw new Bankrot_Exeption();
            return (int)(minus * 100);

        }
        public int delenie()
        {
            Console.WriteLine("Введите чило на которое нужно разделить ");
            int del = int.Parse(Console.ReadLine());
            if (del < 0)
            {  throw new Bankrot_Exeption("На ноль делить нельзя"); };
            return del;
        }
        public int umnozenie()
        {
            Console.WriteLine("Введите чило на которое нужно умножить ");
            int  umn= int.Parse(Console.ReadLine());
            if (umn < 0)
            { throw new Bankrot_Exeption("на отрицательное умножать нельзя"); };
            return umn;

        }
        public Money is_equal()
        {
            Console.WriteLine("Введите вторую сумму для сравнения");
            double sr = double.Parse(Console.ReadLine());
            if (sr < 0) throw new Bankrot_Exeption();
            int sum3 = (int)(sr * 100);
            return new Money() { Summa = sum3 };
        }
        public Money Sravnenie()
        {
            Console.WriteLine("Введите вторую сумму для сравнения");
            double srav = double.Parse(Console.ReadLine());
            if (srav < 0) throw new Bankrot_Exeption();
            int sum3 = (int)(srav * 100);
            return new Money() { Summa = sum3 };
        }

        }
}
