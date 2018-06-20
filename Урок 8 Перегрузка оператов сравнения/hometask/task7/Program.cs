using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Разработать класс Fraction, представляющий простую дробь.В классе предусмотреть два поля: числитель и знаменатель дроби.
            //Выполнить перегрузку следующих операторов: +,-,*,/,==,!=,<,>, true и false.
            //Арифметические действия и сравнение выполняется в соответствии с правилами работы с дробями.
            //Оператор true возвращает true если дробь правильная(числитель меньше знаменателя), оператор false возвращает true если дробь неправильная(числитель больше знаменателя).
            Fraction fraction1 = new Fraction { Numerator = 5, Denominator = 8 };
            Fraction fraction2 = new Fraction { Numerator = 3, Denominator = 9};

            Console.WriteLine("Сложение {0} ",fraction1+fraction2);
            Console.WriteLine("Вычетание {0} ", fraction1 - fraction2);
            Console.WriteLine("Умножение {0} ", fraction1 * fraction2);
            Console.WriteLine("Деление {0} ", fraction1 / fraction2);
            Fraction fraction3 = new Fraction { Numerator = 5, Denominator = 7 };
            Fraction fraction4 = new Fraction { Numerator = 5, Denominator = 7 };
            //проверяем равенство
            Console.WriteLine(fraction3 ==fraction4);
            Console.WriteLine(fraction1 != fraction2);
           
            Console.WriteLine();
            Fraction fraction5 = new Fraction { Numerator = 5, Denominator = 13 };
            Fraction fraction6 = new Fraction { Numerator = 5, Denominator = 7 };
            //больше меньше
            Console.WriteLine(fraction5 >fraction6);
            Console.WriteLine(fraction5 <fraction6);
            
            Console.WriteLine();
            Fraction fraction7 = new Fraction { Numerator = 1, Denominator = 7 };
           if(fraction7)
                Console.WriteLine("Правильная дробь");

            else Console.WriteLine("Неправильная дробь");

            
        }
    }
}
