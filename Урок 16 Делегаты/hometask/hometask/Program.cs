using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//            Задание «Банк и клиенты».
//            Решить с помощью делегатов.
//Банк отправляет информацию про критическое количество доступных денег для выдачи кредита(с указанием остатка) или дату следующего возможного пополнения депозита, 
//если денег больше нет.


namespace hometask
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //создаем список клиетов
            // Присвоим им фамилию и сумму денег на депозите
            List<Client> clients = new List<Client>
            {
                new Client { Surname="Иванов",SumMoney=1256},
               new Client { Surname="Федоров",SumMoney=3},
               new Client { Surname="Тимофеев",SumMoney=122},
               new Client { Surname="Василев",SumMoney=12},
               new Client { Surname="Ласточкин",SumMoney=454}
            };

            Bank bank = new Bank();
            foreach (Client item in clients)
             {
                //у всех клиетов снимаем по 23   
                //если отрицательная суммв выходит на депозите, записываем клиента в делегат
                if (item.GetMoney(23) == false)    
                    bank.balanc_otric += item.Show;
                  // в противном случае все у клиента хорошо 
               else item.Show("операция прошла успешно,можете дальше ложить на депозит");
                
            }
            bank.BankP(DateTime.Now.AddMinutes(45)); //передаем время через которое можно положить на депозит
        }
    }
}
