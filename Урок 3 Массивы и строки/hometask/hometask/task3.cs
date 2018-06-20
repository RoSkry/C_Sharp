using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class task3
    {
        static void Main(string[] args)
        {
            //3. Пользователь вводит строку.Проверить, является ли эта строка палиндромом.
            Console.WriteLine("Vvvedite stroku");
            string str = Console.ReadLine().ToLower();//делаем всю строку маленькими буквами
            bool d = true;
            char e = ' ';
            char a = ',';
            for (int i = 0, j = str.Length-1; i < j; j--, i++)
            {
                if (str[i] == e||str[i]==a) //если есть пробел или запятая
                {
                    j++;
                    continue;
                }
                if (str[j] == e || str[j] == a)
                {
                    i--;
                    continue;
                }
                    if (str[i] == str[j])   // если все элементы совпадут 
                    d = true;
                else
                {
                    d = false;
                    break;
                }

            }
            if (d == true) Console.WriteLine("palindrom");  // является полиндромом
          
           

        }
    }
}
  

