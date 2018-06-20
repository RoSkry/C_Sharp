using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Client  //   сдесь содержится фамилия, количество денежных средств клиента и методы снятие денег,
        //пополнение банковского счета и показ остатка или времени через которое можно будет положить на депозит
    {
        public string Surname { get; set; }   //Фамилия
        public double SumMoney { get; set; }     //Количество денежных средств
        //снятие денег, возращает true, если запрошенная сумма на снятие не превышает сумму на счете в банке
        public bool GetMoney(double m)             
        {
            if (SumMoney > m)
            {
                SumMoney -= m;
                return true;
            }
            else
            { SumMoney -= m;
              return false;}
                
        }
        //ложем на депозит
        public bool AddMoney(double m)
        {
           
                SumMoney += m;
                return true;

        }
           //показываем информацию о клиенте
        public void  Show(string t)
        {
            Console.WriteLine( $"у клиета {Surname} осталось на счету {SumMoney} {t}");
        }
    }
}
