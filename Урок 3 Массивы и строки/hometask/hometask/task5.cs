using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class task5
    {
        static void Main(string[] args)
        {
             string b = " ,-:";// для разбтения строки на слова
            char[] razdel = b.ToCharArray();   //преобразуем в массив char
            char n = ' ';
            char[] l = { 'а', 'и', 'о', 'у', 'ж','э'};  //гласные буквы
            Console.WriteLine("Vvvedite stroku");

            
            string str = Console.ReadLine().ToLower();
                   
                string[] substrings = str.Split(razdel);
           
                // разбиваем строку на слова
            int count = 0; // подсчет слов заканчивающихся на гласную букву
            
            for (int i = 0; i < substrings.Length; i++)
            {
                if (substrings[i].Length > 1)  //  если слово больше одной буквы, одна буква не слово
                { 
                for (int j = substrings[i].Length; j > 0; j++)
                {

                    n = substrings[i][j - 1];// последняя буква
                     for(int v=0;v<l.Length;v++)
                    {
                        if (n == l[v])  // если есть добавляем
                        {
                            count++;
                        }
                    }
                    break;



                }
                }

            }
              Console.WriteLine(count);

        }
    }
}
