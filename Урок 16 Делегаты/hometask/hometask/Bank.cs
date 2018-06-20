using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
     public delegate void BalanceMinus(string t);  //создаем делегат
    class Bank
    {

        public event BalanceMinus balanc_otric;  //создаем событие, которое нужно если баланс меньше нуля

         //метод который будет показывать через сколько можно ложить на депозит
        public void BankP(DateTime t)  
        {
            balanc_otric($"у вас малое количество средств, можно будет пополнить счет {t}");                
        }

    }
}
