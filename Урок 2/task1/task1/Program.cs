using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //       /*при помощи метода GetType() программа возвращает тип данных литералов,
            //                              демонстрируя действие суффиксов*/
            //       Console.WriteLine((10D).GetType()); /*выводит в консоль: System.Double
            //	что соответствует типу данных double*/
            //       Console.WriteLine((10f).GetType()); /*выводит в консоль: System.Single
            //	что соответствует типу данных float*/
            //       Console.WriteLine((10m).GetType()); /*выводит в консоль: System.Decimal
            //	что соответствует типу данных decimal*/
            //       Console.WriteLine((10).GetType()); /*выводит в консоль: System.Int32
            //	что соответствует типу данных int*/
            //       Console.WriteLine((10L).GetType()); /*выводит в консоль: System.Int64
            //	что соответствует типу данных long*/
            //       Console.WriteLine((10UL).GetType()); /*выводит в консоль: System.Uint64
            //	что соответствует типу данных ulong*/
            //       Console.WriteLine(0xFF); /*выводит в консоль: 255 шестнадцатиричное число
            //0xFF соответствует десятичному числу 255*/
            //                                //изменяет заголовок окна консоли



            //       Console.Title = "Пример использования инструментов класса Console";
            //       Console.BackgroundColor = ConsoleColor.White; //изменяет цвет фона
            //       //изменяет цвет текста
            //       Console.ForegroundColor = ConsoleColor.DarkGreen;
            //       //получаем размер самого длинного сообщения в рамках нашей программы
            //       int length = ("Input Encoding:  " + Console.InputEncoding.ToString()).Length + 1;
            //       Console.SetWindowSize(length, 8); //устанавливаем размер окна консоли
            //       /*устанавливаем размер буфера консоли 
            //       (размер окна должен быть соответствующим и должен быть 
            //       установлен до того, как мы изменим размер буфера)*/
            //       Console.SetBufferSize(length, 8);
            //       //выводим информацию о кодировке потока ввода
            //       Console.WriteLine("Input Encoding:  " + Console.InputEncoding.ToString());
            //       //выводим информацию о кодировке потока вывода
            //       Console.WriteLine("Output Encoding: " + Console.OutputEncoding.ToString());
            //       //устанавливает зеначение цвета текста в значение по умолчанию
            //       Console.ResetColor();
            //       //выводим информацию о том, нажат ли NUM LOCK
            //       Console.WriteLine("Is NUM LOCK turned on: " + Console.NumberLock.ToString());
            //       //выводим информацию о том, нажат ли CAPS LOCK
            //       Console.WriteLine("Is CAPS LOCK turned on: " + Console.CapsLock.ToString());
            //       /*выводим пользователю сообщение о том, что программа ожидает ввода некоторой информации*/
            //       Console.Write("Enter a simpe message: ");
            //       //получаем от пользователя текстовое сообщение
            //       string message = Console.ReadLine();
            //       //выводим сообщение, введённое пользователем
            //       Console.WriteLine("Your message is: " + message);


            int a = 10;
            int b = 28;
            int result = a >> b;//деление на 2 в степени второго 
                                //операнда, в данном случае в степени 1, то есть просто на 2
            Console.WriteLine(result); // 10/2=5
            result = a << b;// умножение 2 в степени второго 
                            //операнда, в данном случае в степени 1, то есть просто на 2
            Console.WriteLine(result); //10*2=20
            result = a | 5;
            Console.WriteLine(result); //15
            result = a & 3;
            Console.WriteLine(result);//2
            result = a ^ 6;
            Console.WriteLine(result);//12

            bool k = true;
            if (k)
            {
                Console.WriteLine("true"); 
   
            }
            else Console.WriteLine("false");


            //       int level = Int32.Parse(Console.ReadLine());
            //       switch (level)
            //       {
            //           case 0:
            //               Console.WriteLine("Уровень 0");
            //               break;
            //           case 1:
            //               goto case 2;
            //           case 2:
            //               Console.WriteLine("Уровень от 1 до 2");
            //               goto default;
            //           default:
            //               Console.WriteLine("Пока");
            //               break;
            //       }



            //Console.Clear();
            //message = Console.ReadLine();

            //task 1
            //Console.WriteLine("Enter number");
            //int number = int.Parse(Console.ReadLine());
            //int sum1 = 0;

            //while (number > 0)
            //{
            //    int h = number % 10;
            //    sum1 += h;
            //    number /= 10;
            //}
            //Console.WriteLine("Sum =" + sum1);

            ////        Фирма набирает заказы через Интернет, заказ берется к выполнению, если он больше чем на 300 единиц, иначе отказ от заказа.

            ////Фирма прекращает набирать заказы, если набрано заказов на сумму от 2000 единиц(сообщить о прекращении приёма заказов).
            ////Учесть, что максимальная мощность фирмы 3000 единиц, больше выполнить она не в состоянии.

            ////task2
            //int zakaz = 0;

            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("vvedite zakaz");
            //    zakaz = int.Parse(Console.ReadLine());
            //    if (zakaz < 400)
            //    {
            //        Console.WriteLine("otkaz, malemkiy zakaz");
            //        continue;
            //    }

            //    sum += zakaz;
            //    if (sum < 2000)
            //    {
            //        Console.WriteLine("Vvedite ece");
            //        continue;
            //    }
            //    if (sum > 3000)
            //    {
            //        Console.WriteLine("U vas seicac "+sum + " vi previsili, vvedite norm summu");
            //        sum -= zakaz;
            //    }
            //    if (sum > 2000 && sum < 3000)
            //    {
            //        Console.WriteLine("U vac dostatochno"+sum);
            //        break;


            //    }
            //}
        }
    }
}
