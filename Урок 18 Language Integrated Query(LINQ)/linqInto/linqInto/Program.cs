using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqInto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };
            IEnumerable<IGrouping<int, int>> query1 = from i in arrayInt
                                                      group i by i % 10 into res// промежуточный идентификатор,
                                                      //из того что выбрали выбираем еще
                                                      where res.Count() > 1 //количество в группе больше одного
                                                      select res;
            foreach (IGrouping<int, int> key in query1)// первый тип ключа, второй тип значения 
            {
                Console.Write($"{key.Key}: ");
                foreach (int item in key)
                {
                    Console.Write($"{item}");
                }
                Console.WriteLine();
            }
        }
    }
}
