using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
      public  Money() { }
      public int Summa { get; set; } //сумма в копейках
      public  Money( int sum)
        {
            Summa = sum;
        }
        //сложение денежных сумм
        public static Money operator +(Money obj1, Money obj2)
        {
            
            return new Money() { Summa = obj1.Summa + obj2.Summa };
          
        }
        //вычитание сумм
        public static Money operator -(Money obj1, Money obj2)
        {
            return  new Money() { Summa = obj1.Summa - obj2.Summa };;
        }
        //умножение суммы на целое число
        public static Money operator *(Money obj, int n )
        {
            
          return new Money() { Summa=obj.Summa*n};

        }
        //деление суммы на целое число
        public static Money operator /(Money obj, int n)
        {
             
            return new Money() { Summa = obj.Summa / n };

        }
        //сумма увеличивается на 1 копейку
        public static Money operator++(Money obj)
        {
            return new Money() { Summa = ++obj.Summa};
        }
        // сумма уменьшается на 1 копейку
        public static Money operator --(Money obj)
        {
            return new Money() { Summa = --obj.Summa };
        }
        //одинаковые ли суммы
         public static bool operator ==(Money obj1, Money obj2)
        {
            return obj1.Equals(obj2);
        }
        public static bool operator !=(Money obj1, Money obj2)
        {
            return !(obj1==obj2);
        }
        // переопределение метода Equals
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        // необходимо также переопределить метод GetHashCode
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
         //операторы больше меньше > , <
         public static bool operator >(Money obj1, Money obj2)
        {
            return obj1.Summa > obj2.Summa;
        }
        public static bool operator <(Money obj1, Money obj2)
        {
            return !(obj1 > obj2);
        }
        // вывод на экран
        public override string ToString()
        {
            return $"Сумма : {Summa/100} гривен {Summa%100} коопеек";
        }




    }
}
