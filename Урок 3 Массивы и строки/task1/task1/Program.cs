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
            int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArr("Массив myArr1", myArr1);
            int[] tempArr = (int[])myArr1.Clone();// копирование массива
            Array.Reverse(myArr1, 3, 4);//переворот элементов массива
            PrintArr("Массив myArr1 после реверсирования", myArr1);
            myArr1 = tempArr;
            PrintArr("Массив myArr1 после восстановления", myArr1);

            int[] myArr2 = new int[20];
            PrintArr("Массив myArr2 до копирования", myArr2);
            myArr1.CopyTo(myArr2, 5);
            PrintArr("Массив myArr2 после копирования", myArr2);
            Array.Clear(myArr2, 0, myArr2.GetLength(0));// 2 параметр с какого начинать 3 параметр сколько элементов
            PrintArr("Массив myArr2 после чистки: ", myArr2);
            Array.Resize(ref myArr2, 10);// ref передаем по ссыслке масив и изменяем его размер
            PrintArr("Массив myArr2 после изменения размера: ", myArr2);
            myArr2 = new[] { 1, 5, 3, 2, 8, 9, 6, 10, 7, 4 };
            PrintArr("Несортированый массив myArr2: ", myArr2);
            Array.Sort(myArr2);
            PrintArr("Массив myArr2 после сортировки: ", myArr2);
            Console.WriteLine("Число 5 находится в массиве на " + Array.BinarySearch(myArr2, 5) + " позиции");
            Console.WriteLine("Максимальный элемент в массиве myArr2: " +
            myArr2.Max());
            Console.WriteLine("Минимальный элемент в массиве myArr2: " +
            myArr2.Min());
            Console.WriteLine("Среднее арифмтическое элементов myArr2: " +
            myArr2.Average());
      

            int[,] myArr3 = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Количество измерений массива myArr3: " + myArr3.Rank);


            //    string str = "Простая строка";
            //    char[] chrArr = new char[6];

            //    Console.WriteLine("Реверсирование строки с помощью индексатора");
            //    for (int i = str.Length - 1; i >= 0; --i)
            //        Console.Write(str[i]);

            //    Console.WriteLine("\nКопирование строки в массив символов");
            //    //Копируем шесть символов начиная с восьмой позиции и помещаем в массив
            //    str.CopyTo(8, chrArr, 0, 6);// восьмая позиция строки, записываем в новый масив начиная с нулевой шесть символом
            //    Console.WriteLine(chrArr);

            //string str1 = "Простая строка";
            //string str2 = "Строка";
            //string str3 = "строка";
            //string[] strArr = { "ШАГ", "шагаем", "бежим", "ем", "Играем" };

            //Console.WriteLine("\"" + str1 + "\" equal \"" + str2 + "\" : " + str1.Equals(str2));//проверяет идентичность строк 
            //Console.WriteLine("\"" + str2 + "\" == \"Строка\" : " + (str2 == "Строка"));
            //Console.WriteLine("\"" + str2 + "\".CompareTo(\"" + str3 + "\") : " + str2.CompareTo(str3));

            //Console.WriteLine("Сравнение без учета регистра:");
            //Console.WriteLine("\"" + str2 + "\" equal \"" + str3 + "\" : " + str2.Equals(str3, StringComparison.CurrentCultureIgnoreCase));

            //Console.Write("Слова начинающиеся на \"шаг\": ");
            //foreach (string s in strArr)
            //    if (s.StartsWith("шаг", StringComparison.CurrentCultureIgnoreCase))
            //        Console.Write(s + " ");

            //Console.Write("\nСлова заканчивающиеся на \"ем\": ");
            //foreach (string s in strArr)
            //    if (s.EndsWith("ем", StringComparison.CurrentCultureIgnoreCase))
            //        Console.Write(s + " ");
            //Console.WriteLine();

            //string str1 = "ПолиморфизмНаследованиеИнкапсуляция";
            //string str2 = "АБВГДЕЖЗИКЛМН";

            //Console.WriteLine("Первое вхождение символа \'Н\': " + str1.IndexOf('Н'));
            //Console.WriteLine("Первое вхождение подстроки \"Наследование\" : " + str1.IndexOf('Н'));
            //Console.WriteLine("Последнее вхождение символа \'И\': " + str1.LastIndexOf('И'));
            //Console.WriteLine("Последнее вхождение любого из символов строки " + "\"АБВГДЕЖЗИКЛМН\" : " + str1.LastIndexOfAny(str2.ToCharArray()));
            //Console.WriteLine("Подстрока начиная с 11 символа по 23-й : " + str1.Substring(11, 12));// с символа у которо 11, передаем 12 значений

            //string str1 = "Я ";
            //string str2 = "учу ";
            //string str3 = "C#";
            //string str4 = str1 + str2 + str3;

            //Console.WriteLine("{0} + {1} + {2} = {3}", str1, str2, str3, str4);

            //str4 = str4.Replace("учу", "изучаю");
            //Console.WriteLine(str4);

            //str4 = str4.Insert(2, "упорно ").ToUpper();
            //Console.WriteLine(str4);

            //if (str4.Contains("упорно"))
            //    Console.WriteLine("Учу таки упорно :)");
            //else
            //    Console.WriteLine("Учу как могу");

            //str4 = str4.PadLeft(25, '*');
            //str4 = str4.PadRight(32, '*');
            //Console.WriteLine(str4);
            //str4 = str4.TrimStart("*".ToCharArray());
            //Console.WriteLine(str4);
            //string[] strArr = str4.Split(" *".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //foreach (string str in strArr)
            //    Console.WriteLine(str);
            //str4 = str4.Remove(9);
            //str4 += "учусь";
            //Console.WriteLine(str4);

            //double test1 = 99989.987;
            //int test2 = 99999;

            //Console.WriteLine(string.Format("c format: {0,15:C}", test1));
            //Console.WriteLine(string.Format("D format: {0:D9}", test2));
            //Console.WriteLine(string.Format("E format: {0:E}", test1));
            //Console.WriteLine(string.Format("f format: {0:F2}", test1));
            //Console.WriteLine(string.Format("G format: {0:G}", test1));
            //Console.WriteLine(string.Format("N format: {0,15:N}", test2));
            //Console.WriteLine(string.Format("P format: {0:P}", test1));
            //Console.WriteLine(string.Format("X format: {0:X}", test2));
            //Console.WriteLine(string.Format("x format: {0:x}", test2));


            StringBuilder sb = new StringBuilder();

            //sb = "hello"; Error

            sb.Append("hello"); // добавление строки к существующей
            sb.AppendLine(); // добавление пустой строки к существующей
            sb.AppendLine();
            sb.Append("world");

            Console.WriteLine("\n\tИсходная строка");
            Console.WriteLine(sb);
            Console.WriteLine("Максимальное количество символов " + sb.Capacity);
            Console.WriteLine("Длина текущего объекта " + sb.Length);

            Console.WriteLine("\n\tВставка строки");
            sb.Insert(7, "abracadabra"); // вставка строки в заданную позицию
            Console.WriteLine(sb);
            Console.WriteLine("Максимальное количество символов " + sb.Capacity);
            Console.WriteLine("Длина текущего объекта " + sb.Length);

            Console.WriteLine("\n\tЗамена символов 'a' на 'z'");
            sb.Replace('a', 'z'); // замена символов строки
            Console.WriteLine(sb);

            Console.WriteLine("\n\tУдаление 10 символов начиная с 3");
            sb.Remove(3, 10); // удаление символов из строки
            Console.WriteLine(sb);
            Console.WriteLine("Максимальное количество символов " + sb.Capacity);
            Console.WriteLine("Длина текущего объекта " + sb.Length);




        }




        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        private double[][] resizeArray(double[][] matrixToResize, int maxRow, int maxColumn)
        {
            Array.Resize(ref matrixToResize, maxRow);

            for (int i = 0; i < matrixToResize.Length; i++)
            {
                Array.Resize(ref matrixToResize[i], maxColumn);
            }

            return matrixToResize;
        }
    }
    }

