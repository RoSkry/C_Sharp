using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //           4.Начальный вклад в банке равен 10000 грн.Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25).
            //Значение Р программа должна получать у пользователя.По данному P определить через сколько месяцев размер вклада превысит 11000 грн.,
            //и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S(вещественное число).
          
            int end = 11000;// конечная сумма вклада
            double percent;// процент
            double increase;// увеличение на percent от имеющейся суммы
            int month=0;// количество месяцев
           
            Console.WriteLine("Enter your percent");
            percent = Double.Parse(Console.ReadLine());
            if (percent > 0 && percent < 25)
            {
                double size1 = 10000;
                while(size1<end)
                {
                    increase = size1 * percent / 100;
                    size1 +=  increase;
                    month++;

                }
                Console.WriteLine("Size of account is {0} number of month which you need {1}", size1, month);

            }
            


        }
    }
}
