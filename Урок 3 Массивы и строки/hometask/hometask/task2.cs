using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask
{
    class task2
    {
        static void Main(string[] args)
        {
            //    2.Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от 0 до 100.
            //       Переформировать массив таким образом, чтобы его столбцы располагались по убыванию их поэлементных сумм.
            int size = 5;
            int[,] arr = new int[size, size];
            int[] sum = new int[size];
            int j = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)        //задаем случайные числа для массива
            {
                for ( j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(0, 101);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)      //печатаем массив
            {
                for ( j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < arr.GetLength(0); i++)    // подсчитываем сумму в каждом столбце
            {
                for (j=0; j < arr.GetLength(1); j++)
                {
                    sum[j] += arr[i,j];
                         
                }
             
            }
            Console.WriteLine("Сумма до изменения массива");
            for (int i=0;i<size;i++)                // печатаем сумму каждого столбца 
            {
                Console.WriteLine("Сумма {0}го столбца{1}",i,sum[i]);
            }
            int temp;   // временная переменная для суммы
            int temp_st;   //   временная переменная для изменения положения столбцов

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (j = 1; j < arr.GetLength(1)-i; j++)
                {
                  if(sum[j-1]<sum[j])
                    {
                        temp = sum[j];
                        sum[j] = sum[j - 1];
                        sum[j - 1] = temp;


                        for (int k = 0; k < arr.GetLength(0); k++)
                        {
                            for (int g = 0; g < arr.GetLength(1); g++)
                            {

                                temp_st = arr[k, j];
                                arr[k, j] = arr[k, j - 1];
                                arr[k, j - 1] = temp_st;
                            }
                        }
                    }


                }

            }
            Console.WriteLine("Сумма после изменения массива");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Сумма {0}го столбца {1}", i, sum[i]);
            }

            Console.WriteLine("Обновленный массив");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
               
                
                for (j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                     
                }
                Console.WriteLine();
            }














        }

        }
}
