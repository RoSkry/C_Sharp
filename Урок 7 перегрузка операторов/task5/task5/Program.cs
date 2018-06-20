using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Реализовать класс «Перекидной календарь».

            //Объект класса отображает календарь выбранного месяца.
            //По умолчанию – текущий месяц. Перегрузить для класса «Перекидной календарь» операторы++(перейти на следующий месяц), --(перейти на предыдущий месяц), +(перейти на N месяцев вперед), -(перейти на N месяцев назад).
            //Программа предоставляет пользователю возможность «перелистывать» календарь с помощью клавиатуры (стрелка вправо – на месяц вперед, влево – на месяц назад, PgUp – на 12 месяцев вперед, PgDn – на 12 месяцев назад, стрелка вверх – на 6 месяцев вперед, стрелка вниз – на 6 месяцев назад).
            //Календарь отображать на экране консоли в виде таблицы, с использованием цветов для рабочих и выходных (суббота, воскресенье) дней.Названия месяцев отображаются соответствующим времени года цветом(Зима – синий, Весна – Зеленый, Лето – Желтый, Осень – Красный).
            //Минимальная дата, которую способен отобразить календарь – 1.01.1990г., максимальная – 31.12.2020

            //   ConsoleKeyInfo info = Console.ReadKey()// принимает булевское значение(true)
            //if (info.Key == ConsoleKey.RightArrow)

            DateTime current = DateTime.Today;
            int year = DateTime.Today.Year;
            int month = DateTime.Today.Month;
            //     int n = DateTime.DaysInMonth(year, month);


            // определение первого дня в месяце
            // DateTime dt = new DateTime(year, month, 1);
            //   int t= (int)  dt.DayOfWeek;
            //Console.WriteLine(t);



            Calendar s = new Calendar(3,12,2017);
            s.show();

            
                while (true)
                {
                    ConsoleKeyInfo info = Console.ReadKey(true);

                       Console.Clear();
                    if (info.Key == ConsoleKey.RightArrow)
                    {
                        s++;
                        s.show();
                   
                    }
                    if (info.Key == ConsoleKey.LeftArrow)
                    {
                        s--;
                        s.show(); 
                }

                    if (info.Key == ConsoleKey.UpArrow)
                    {
                        s += 6;
                        s.show();
                }
                if (info.Key == ConsoleKey.DownArrow)
                {
                    s -= 6;
                    s.show(); 

                }
                if (info.Key == ConsoleKey.PageUp)
                    {
                        s += 12;
                        s.show(); 
                }
                if (info.Key == ConsoleKey.PageDown)
                {
                    s -= 12;
                    s.show(); 
                }

            }

            










        }
    }
}
