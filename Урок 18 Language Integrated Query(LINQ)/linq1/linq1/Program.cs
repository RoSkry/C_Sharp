using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };

            IEnumerable<int> query = from i in arrayInt
                                     where i % 2 == 0  // where- условие(находит четные)
                                     orderby i descending            //сортировка
                                     //ascending по возрастанию, descending по убыванию
                                     select i;

            List<int> list = query.ToList();

            foreach(int item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();


            IEnumerable<IGrouping<int, int>> query1 = from i in arrayInt
                                                     group i by i % 10;

            foreach (IGrouping<int, int> key in query1)// первый тип ключа, второй тип значения 
            {
                Console.Write($"{key.Key}: ");
                foreach (int item in key)
                {
                    Console.Write($"{item}");
               }
                Console.WriteLine();
            }


            //Console.WriteLine();
            //arrayInt[0] = 30;
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}


            //arrayInt[0] = 23;

            //foreach (int item in query)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
