using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //даны целые положительные числа a, b, c.значение этих чисел программа должна запрашивать у пользователя.
            //необходимо найти максимально возможное количество квадратов со стороной c(квадраты не накладываются друг на друга), размещенных на прямоугольнике размера a* b, а также площадь незанятой части прямоугольника.
            //необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни одного квадрата со стороной с (например, если значение с превышает размер сторон прямоугольника).

            int a=5, b=5, c=4;
            int S_squ, S_rec;
            //Console.WriteLine("Enter a rectangle");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b rectangle");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter c square ");
            //c = int.Parse(Console.ReadLine());
            if (c > a || c > b)
            {
               Console.WriteLine("Enter new c ");
              c = int.Parse(Console.ReadLine());
            }
            else { 
            S_squ = c*c;
            S_rec = a * b;
            Console.WriteLine("Ploshad kvadrata={0},Ploshad prymoug={1}",S_squ,S_rec);
              int num1 = a / c;//сколько посещается по вертикали
              int num2 = b / c;//сколько помещается по горизонтали
            int number_of_squares = num1 * num2;// количество квадратов которые можно поместить
            int ostatok = S_rec - number_of_squares*S_squ;//остаток в прямоугольнике
            Console.WriteLine("Number of squares is {0} and ostatok {1}", number_of_squares, ostatok);
                  }
         
        }
    }

   
 }
   

           






      
   
    

