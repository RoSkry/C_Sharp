using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> groups = new Dictionary<string, int>();
            //groups["GR1"] = 1;
            //groups.Add("GR2", 2);
            //groups.Add("GR3", 3);
            //groups["GR2"] = 5;
            //groups.Remove("GR2");
            //foreach (KeyValuePair<string,int> item in groups)
            //{
            //    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            //}
            //try
            //{
            //    groups.Add("GR1", 5);//пытаемя добавить существующий ключ
            //}
            //catch (ArgumentException a)
            //{

            //    Console.WriteLine(a.Message);
            //}
            //try
            //{
            //    Console.WriteLine(groups["GR5"]);//нет такого ключа
            //}
            //catch(KeyNotFoundException k)
            //{
            //    Console.WriteLine(k.Message);
            //}
            //int n;
            //if(groups.TryGetValue("GR5",out n))//поиск по ключа, попытка получения значения
            //{
            //    Console.WriteLine(n);
            //}
            //else Console.WriteLine("Error");
            Dictionary<string, int> groups = new Dictionary<string, int>()
            {
                ["GR1"] = 1,
                ["GR2"] = 2,
                ["GR3"] = 4
            };

           



;        }
    }
}
