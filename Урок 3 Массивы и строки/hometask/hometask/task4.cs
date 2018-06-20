using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class task4
    {

        static void Main(string[] args)
        {
            string b = " ,-:";// для разбтения строки на слова
            char[] razdel = b.ToCharArray();   //преобразуем в массив char
            // 4.Поменять местами соседние слова во введённом предложении.
            Console.WriteLine("Vvvedite stroku");
            string str = Console.ReadLine();

            string[] substrings = str.Split(razdel); // разбиваем строку на слова

            string temp;
            int count = substrings.Length;    // определяем количество слов

            if (count % 2 == 0)    //если количество слов четное то меняем соседние местами
            {

                for (int i = 0; i < substrings.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        temp = substrings[i + 1];
                        substrings[i + 1] = substrings[i];
                        substrings[i] = temp;
                    }

                }
            }
            // если нечетное, то меняем 1 с 3,затем 3 с 5 и т.д (решил поэксперементировать)
            else
            {
               
                for (int i = 1; i < substrings.Length ; i+=2)
                {
                    
                    temp = substrings[i+1];
                        substrings[i+1] = substrings[i-1];
                       substrings[i-1] = temp;
                    
                }
                
          

            }



            string newstr = string.Join(" ", substrings);


            Console.WriteLine(newstr);
                      
                     
                               



            
             

            }

        }
    }

