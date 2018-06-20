using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public class LooseLeafCalendar // перекидной календарь
        {
            int _year;
            int _month;
            int _day;

            public LooseLeafCalendar()
            {
                _year = DateTime.Today.Year;
                _month = DateTime.Today.Month;
                _day = DateTime.Today.Day;
            }

            public static LooseLeafCalendar operator ++(LooseLeafCalendar calendar)
            {
                DateTime temp = new DateTime(calendar._year, calendar._month, calendar._day);
                DateTime result = temp.AddMonths(1);
                calendar._year = result.Year;
                calendar._month = result.Month;
                calendar._day = result.Day;

                return calendar;
            }
            public static LooseLeafCalendar operator --(LooseLeafCalendar calendar)
            {
                DateTime temp = new DateTime(calendar._year, calendar._month, calendar._day);
                DateTime result = temp.AddMonths(-1);
                calendar._year = result.Year;
                calendar._month = result.Month;
                calendar._day = result.Day;

                return calendar;
            }
            public static LooseLeafCalendar operator +(LooseLeafCalendar calendar, int n)
            {
                DateTime temp = new DateTime(calendar._year, calendar._month, calendar._day);
                DateTime result = temp.AddMonths(n);
                calendar._year = result.Year;
                calendar._month = result.Month;
                calendar._day = result.Day;

                return calendar;
            }
            public static LooseLeafCalendar operator -(LooseLeafCalendar calendar, int n)
            {
                DateTime temp = new DateTime(calendar._year, calendar._month, calendar._day);
                DateTime result = temp.AddMonths(-n);
                calendar._year = result.Year;
                calendar._month = result.Month;
                calendar._day = result.Day;

                return calendar;
            }
            public void Show()
             {
                const int DayWeek = 7, Cursor = 5;
                string[] daysWeekRus = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

                DateTime temp = new DateTime(_year, _month, 1, new GregorianCalendar());

                ConsoleColor foregroundColor = ConsoleColor.White;

                switch (_month)// выбор цвета в зависимости от времени года
                {
                    case 1:
                    case 2:
                    case 12:
                        foregroundColor = ConsoleColor.Blue;
                        break;
                    case 3:
                    case 4:
                    case 5:
                        foregroundColor = ConsoleColor.Green;
                        break;
                    case 6:
                    case 7:
                    case 8:
                        foregroundColor = ConsoleColor.Yellow;
                        break;
                    case 9:
                    case 10:
                    case 11:
                        foregroundColor = ConsoleColor.Red;
                        break;
                }

                Console.ForegroundColor = foregroundColor;

                //Если нужен только месяц, то так: Console.WriteLine(DateTime.Now.ToString("MMMM")); // Июнь

                Console.Clear(); // очищаю консоль
                Console.SetCursorPosition(35, Cursor); // вывод месяца и года
                Console.WriteLine("{0} {1}", temp.ToString("MMMM"), _year); // вывод названия месяца и год числом

                Console.SetCursorPosition(15, Cursor + 2);// вывод дней недели
                foreach (string str in daysWeekRus)
                    Console.Write(str + "\t");

                int start = (int)temp.DayOfWeek; // определяю номер дня недели
                if (start == 0) // (int)temp.DayOfWeek для воскресенья возвращает индекс 0
                    start = 7;
                start--; // считаю от 0, поэтому -1

                // +++++++++++++ вывод дней календаря ++++++++++++++

                Console.SetCursorPosition(15, Cursor + 4);

                // дни предыдущего месяца
                DateTime prev = temp.AddMonths(-1);
                int prevDays = DateTime.DaysInMonth(prev.Year, prev.Month);
                for (int i = start - 1; i >= 0; i--)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(prevDays - i);
                    Console.Write("  \t");
                }
                Console.ForegroundColor = foregroundColor;

                int num = start;
                for (int i = 1, j = 6; i <= DateTime.DaysInMonth(_year, _month); i++)// дней в месяце
                {
                    if (num == DayWeek - 2 || num == DayWeek - 1)// выделяю субботы и воскресенья
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                    if (i == _day)
                        Console.BackgroundColor = ConsoleColor.Magenta;

                    Console.Write(i);

                    Console.BackgroundColor = ConsoleColor.Black;

                    Console.Write(" \t");

                    num++;

                    if (num == DayWeek)
                    { // если количество счётчик равен кол-ву дней в неделе,
                        Console.SetCursorPosition(15, Cursor + j); // переход на новую строку (следующую неделю)
                        j += 2; // увеличиваю для перехода на новую строку
                        num = 0; // и обнуление счётчика
                    }
                }

                // дни следующего месяца
                for (int i = 1; num > 0 && num < DayWeek; num++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(i++);
                    Console.Write("  \t");
                }
            }
        }
        static void Main(string[] args)
        {
            LooseLeafCalendar calendar = new LooseLeafCalendar();

            ConsoleKeyInfo keyInfo;

            try
            {
                do
                {
                    calendar.Show();

                    keyInfo = Console.ReadKey(true);


                    if (keyInfo.Key == ConsoleKey.RightArrow)// клавиша: стрелка вправо
                        calendar++; // на месяц вперед

                    if (keyInfo.Key == ConsoleKey.LeftArrow)// клавиша: стрелка влево
                        calendar--; // на месяц назад

                    if (keyInfo.Key == ConsoleKey.UpArrow) // клавиша: стрелка вверх
                        calendar += 6; // на пол года вперед

                    if (keyInfo.Key == ConsoleKey.DownArrow)// клавиша: стрелка вниз
                        calendar -= 6; // на пол года назад

                    if (keyInfo.Key == ConsoleKey.PageUp) // клавиша: PgUp
                        calendar += 12; // на год вперед

                    if (keyInfo.Key == ConsoleKey.PageDown)// клавиша: PgDown
                        calendar -= 12; // на год назад

                } while (keyInfo.Key != ConsoleKey.Enter);// клавиша: Enter
            }

            catch
            {
            }

            Console.ReadLine();
        }
    }
}
