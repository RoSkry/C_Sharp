using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        {
        //    1.Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от -100 до 100.
        //        Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.
            int[,] arr = new int[5, 5];
            Random rand = new Random();
            for(int i=0;i<arr.GetLength(0);i++)   //задаем случайные числа для массива
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    arr[i, j] = rand.Next(-100, 101);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)    //печатаем массив
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine();
            }
            int max = arr[0, 0];  //  максимальное значение в массиве
            int min = arr[0, 0]; // минимальное значение в массиве 
            int iMin=0;   // Строка, где находиться минимальное значение   
            int jMin=0;   // Столбец, где находиться минимальное значение
            int iMax=0; // Строка, где находиться максимальное значение   
            int jMax=0;     // Столбец, где находиться максимальное значение

            for (int i = 0; i < arr.GetLength(0); i++)      // ищем максимальное и минимальное значение, а также их координаты
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    { 
                        max = arr[i,j];
                        iMax=i;
                        jMax=j;
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        iMin = i;
                        jMin = j;
                    }
                }
            }
            Console.WriteLine("Максимальное значение {0} на позиции {1} и {2}",max,iMax,jMax);
            Console.WriteLine("Минимальное значение {0} на позиции {1} и {2}", min, iMin, jMin);
            bool a = false;
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i==iMin && j==jMin)||(i==iMax&j==jMax))  // если выполняется условие, то а меняется на true и подчитывается сумма пока не закончиться диапазон
                    {
                        if (a)
                        {
                            a = false;
                            continue;
                        }
                        else
                        {
                            a = true;
                            continue;
                        }
                        
                    }
                    if(a)      //подсчитываем сумму в диапазоне
                    {
                        sum += arr[i, j];
                    }
                }
            }
            Console.WriteLine(sum);

                }
    }
}
