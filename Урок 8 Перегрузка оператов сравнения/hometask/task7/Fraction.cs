using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Fraction
    {
        public int Numerator{ get; set; }     //числитель
        public int Denominator { get; set; } //знаменатель
        public Fraction() { }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
          //соложение
        public static Fraction operator +(Fraction a,Fraction b)   // сложение дробей 
        {
            int NewNumenator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int NewDenominator = a.Denominator * b.Denominator;
            Fraction NewFraction = new Fraction { Numerator = NewNumenator, Denominator = NewDenominator };
            NewFraction.Uproshonie();
            return NewFraction ;
            
        }
        //вычетание
        public static Fraction operator -(Fraction a, Fraction b)   // сложение дробей 
        {
            int NewNumenator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int NewDenominator = a.Denominator * b.Denominator;
            Fraction NewFraction = new Fraction { Numerator = NewNumenator, Denominator = NewDenominator };
            NewFraction.Uproshonie();
            return NewFraction;

        }
            //умножение
        public static Fraction operator *(Fraction a, Fraction b)   // сложение дробей 
        {
            int NewNumenator = a.Numerator*b.Numerator;
            int NewDenominator = a.Denominator * b.Denominator;
            Fraction NewFraction = new Fraction { Numerator = NewNumenator, Denominator = NewDenominator };
            NewFraction.Uproshonie();
            return NewFraction;

        }
        //деление
        public static Fraction operator /(Fraction a, Fraction b)   // сложение дробей 
        {
            int NewNumenator = a.Numerator * b.Denominator;
            int NewDenominator = a.Denominator * b.Numerator;
            Fraction NewFraction = new Fraction { Numerator = NewNumenator, Denominator = NewDenominator };
            NewFraction.Uproshonie();
            return NewFraction;

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
         // равенство дробей
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a==b);
        }
            //сравнение дробей больше меньше 
        public static bool operator >(Fraction a, Fraction b)
        {
            int NewNumenator1 = a.Numerator * b.Denominator;
            int NewDenominator1 = a.Denominator * b.Denominator;
            int NewNumenator2 = b.Numerator * a.Denominator;
            int NewDenominator2 = b.Denominator * a.Denominator;
            Fraction NewFraction1 = new Fraction { Numerator = NewNumenator1, Denominator = NewDenominator1 };
            Fraction NewFraction2 = new Fraction { Numerator = NewNumenator2, Denominator = NewDenominator2 };
            return NewFraction1.Numerator > NewFraction2.Numerator; 
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            return !(a > b);
        }

        public override string ToString()
        {
            return $"Числитель равен {Numerator}, знаменатель равен {Denominator} ";
        }
        public static bool operator true(Fraction a)
        {
            return a.Numerator < a.Denominator?true:false;
        }
        public static bool operator false(Fraction a)
        {
            return a.Numerator > a.Denominator?true:false;
        }

        //упростим дробь
        public void Uproshonie()
        {
              for(int i=2;i<=Numerator;i++)
            {
                if(Numerator%i==0&&Denominator%i==0)
                {
                    Numerator /= i;
                    Denominator /= i;
                    i = 1;
                }

            }

        }      
   
    }
}
