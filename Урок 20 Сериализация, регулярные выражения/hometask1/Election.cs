using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
   public delegate void StarElection();
   public enum Candedates
    {
        Ivanov=1,Petrov=2,Sidorov=3,Fedorov=4,Noone=0
    }
    class Election
    {

       public int population = 200000;
        public event StarElection st;

        public bool Show()
        {   int first = 0;
                int second = 0;
                int third = 0;
                int fourth = 0;
                int noone = 0;
            Random rand = new Random();
           for(int i=0;i<population;i++)
            {                
              int a=rand.Next(1,6);
              switch(a)
                {
                    case 1:first++;break;
                    case 2: second++; break;
                    case 3: third++; break;
                    case 4:fourth++;break;
                    default:noone++;break;
                } 
            }
            results(first, second, third, fourth, noone);
             if (population * 0.15 > noone) return false;    //если явка меньше 85%
            if (first > second && first > third && first > fourth && first > noone)
            {
                Console.WriteLine($"Первый кандидат {Enum.GetName(typeof(Candedates), 1)} победил с количеством {first} голосов");
                return true;
            }                                            
            else if (second > first && second > third && second> fourth && second> noone)
            { 
                Console.WriteLine($"Второй кандидат {Enum.GetName(typeof(Candedates), 2)} победил с количеством {second} голосов");
                return true;
            }
            else if (third>first &&  third>second && third> fourth && third > noone)
            { 
                Console.WriteLine($"Третий кандидат  {Enum.GetName(typeof(Candedates), 3)} победил с количеством {third} голосов");
                return true;
              }
          else  if (fourth > first && fourth > third && fourth > second && fourth > noone)
            { 
                Console.WriteLine($"Четвертый кандидат  {Enum.GetName(typeof(Candedates), 4)} победил с количеством {fourth} голосов");
                return true;
            }
            else  return false;              
        }

        public void results(int first,int second,int third,int fourth, int noone)
        {
            Console.WriteLine("Результаты:");
            Console.WriteLine($"{Enum.GetName(typeof(Candedates), 1)} набрал {first} голосов");
            Console.WriteLine($"{Enum.GetName(typeof(Candedates), 2)} набрал {second} голосов");
            Console.WriteLine($"{Enum.GetName(typeof(Candedates), 3)} набрал {third} голосов");
            Console.WriteLine($"{Enum.GetName(typeof(Candedates), 4)} набрал {fourth} голосов");
            Console.WriteLine($"Не пришли на выборы  {noone} голосов");
        }

       public void Congratulation()
        {

        }
    }
}
