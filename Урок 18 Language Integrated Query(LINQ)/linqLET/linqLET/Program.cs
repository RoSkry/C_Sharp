using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqLET
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] poem = { "В этой сказке", "Нет порядка:", "Что ни слово -", "То загадка!" };
            IEnumerable<string> query = from p in poem
                                        let words = p.Split(' ', '-') //разделяем слова,дополнительная переменная   
                                        from w in words
                                        where w.Count() > 5 
                                        select w;     
           
                foreach (string item in query)
                {
                    Console.Write($"{item}");
                }
                Console.WriteLine();
            }
        }
    }

