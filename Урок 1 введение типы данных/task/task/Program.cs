using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal devidend = decimal.One;
            //нижеследующая строка выводит в консоль 1
            Console.WriteLine(devidend);
            decimal devisor = 3;
            devidend = devidend / devisor;
            //нижеследующая строка выводит в консоль //0.3333333333333333333333333333
            Console.WriteLine(devidend);
            //нижеследующая строка выводит в консоль //0.9999999999999999999999999999
            //из чего можно сделать вывод, что ошибки округления привели к потере данных
            Console.WriteLine(devidend * devisor);
            double doubleDevidend = 1;
            //нижеследующая строка выводит в консоль 1
            Console.WriteLine(doubleDevidend);
            double doubleDevisor = 3;/*в данной строке объявлена переменная типа double. Использование выражения System.Double идентично использованию ключевого слова double. Отличие состоит в том, что мы явно указываем структуру (тип данных).*/
            doubleDevidend = doubleDevidend / doubleDevisor;
            //нижеследующая строка выводит в консоль //0.33333333333333
            Console.WriteLine(doubleDevidend);
            //нижеследующая строка выводит в консоль 1
            Console.WriteLine(doubleDevidend * doubleDevisor); //при использовании типа double мы получаем потерю информации в обоих направлениях

            Console.WriteLine(int.MinValue);
            Console.WriteLine("Hello c#");// вывод текста
            Console.ReadLine();//считывает информацию из консоли

            /*Описание действия метода:					Результат:*/
            //определяет является ли символ управляющим
            Console.WriteLine(char.IsControl('\t'));                //True
                                                                    //определяет является ли символ цифрой
            Console.WriteLine(char.IsDigit('5'));                   //True
                                                                    //определяет является ли символ бувенным
            Console.WriteLine(char.IsLetter('x'));                  //True
                                                                    //определяет находится ли символ в нижнем регистре
            Console.WriteLine(char.IsLower('m'));                   //True
                                                                    //определяет находится ли символ в верхнем регистре
            Console.WriteLine(char.IsUpper('P'));                   //True
                                                                    //определяет является ли символ числом
            Console.WriteLine(char.IsNumber('2'));                  //True
                                                                    //определяет является ли символ разделителем
            Console.WriteLine(char.IsSeparator('.'));               //False
                                                                    //определяет является ли символ специальным символом
            Console.WriteLine(char.IsSymbol('<'));                  //True
                                                                    //определяет является ли символ пробелом
            Console.WriteLine(char.IsWhiteSpace(' '));              //True
                                                                    //переводит символ в нижний регистр
            Console.WriteLine(char.ToLower('T'));                   //t
                                                                    //переводит символ в верхний регистр
            Console.WriteLine(char.ToUpper('t'));       			//T

            int? nullInt = null;
            nullInt = nullInt ?? 50;// ессли null присваивается 50
            Console.WriteLine(nullInt); // 50
            
           

 nullInt = null;
            if (nullInt == null)
            {
                nullInt = 50;
            }


            int n = 10;
            n=n>> 1;
            Console.WriteLine(n);

        }
    }
}
