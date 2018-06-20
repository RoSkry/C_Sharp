using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    enum Month
    {
        January=1,february=2,march=3,April=3,May=4,June=5,July=6,August=7,September=8,November=9,december=10
    }
    class Calendar
    {
        private int _day;
        private int _month;
        private int _year;

     public   Calendar()
        {
            _day = DateTime.Today.Day;
            _month = DateTime.Today.Month;
            _year = DateTime.Today.Year;

        }
     public   Calendar(int day,int month,int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public static Calendar operator++(Calendar s)
        {
            s._month++;
            if(s._month==13)
            {
                s._month = 1;
                s._year++;
            }
            return s;
        }
        public static Calendar operator --(Calendar s)
        {
            s._month--;
            if (s._month == 0)
            {
                s._month = 12;
                s._year--;
            }
            return s;
        }

        public static Calendar operator +(Calendar s,int increase)
        {
            s._month += increase;
            if(s._month>12 )
            {
                s._month %= 12;
                if (s._month == 0) s._month = 12;
                s._year++;
            }
            return s;

        }
        public static Calendar operator -(Calendar s, int increase)
        {
            s._month -= increase;
            if (s._month < 1)
            {
                //s._month %=12 ;
                s._month = 12 + s._month;
                s._year--;
            }
            return s;
        }
        public int GetBegin(int n)
        {
            int otstup = 0;
            if (n == 0)
            {
                Console.Write("\t\t\t\t\t\t");
                otstup = 6;
            }
            if (n == 1)
            {

                otstup = 0;
            }
            if (n == 2)
            {
                Console.Write("\t");
                otstup = 1;
            }
            if (n == 3)
            {
                Console.Write("\t\t");
                otstup = 2;
            }
            if (n == 4)
            {
                Console.Write("\t\t\t");
                otstup = 3;
            }
            if (n == 5)
            {
                Console.Write("\t\t\t\t");
                otstup = 4;
            }
            if (n == 6)
            {
                Console.Write("\t\t\t\t\t");
                otstup = 5;
            }
            return otstup;
        }
        public    void coler( int m)
        {

        }
        public void show()
        {
            int count = DateTime.DaysInMonth(_year, _month);
            switch (_month)
            {
                case 1: Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\t\t\t January " + _year);  break;
                case 2: Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\t\t\t February " + _year);  break;
                case 3: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t March " + _year); break;
                case 4: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t April " + _year);  break;
                case 5: Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("\t\t\t May " + _year);  break;
                case 6: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\t\t\t June " + _year); break;
                case 7: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\t\t\t July " + _year); break;
                case 8: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("\t\t\t August " + _year);  break;
                case 9: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\t\t\t September " + _year); break;
                case 10: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\t\t\t October " + _year);  break;
                case 11: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("\t\t\t November " + _year);  break;
                case 12: Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("\t\t\t December " + _year); break;
            }
            Console.WriteLine();
            Console.WriteLine("\tПн\tВт\tСр\tЧт\tПт\tСб\tВс ");
            Console.WriteLine();
            DateTime dt = new DateTime(_year,_month, 1);
            int t = (int)dt.DayOfWeek;
            int r= GetBegin(t);
           
            for (int i=1;i<=count;i++)
            {
                if(i==_day)
                 Console.ForegroundColor = ConsoleColor.Magenta;
                if (_month>=3&_month<=5)
                {
                    if((i+r)%7>=6|| (i + r) % 7 ==0)           
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else Console.ForegroundColor = ConsoleColor.Green;
                }
                if (_month >= 6 & _month <= 8)
                {
                    if ((i + r) % 7 >= 6 || (i + r) % 7 == 0)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (_month >= 9 & _month <= 11)
                {
                    if ((i + r) % 7 >= 6 || (i + r) % 7 == 0)
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    else Console.ForegroundColor = ConsoleColor.Red;
                }
                if (_month >= 12 || _month <= 2)
                {
                    if ((i + r) % 7 >= 6 || (i + r) % 7 == 0)
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    else Console.ForegroundColor = ConsoleColor.Blue;
                }

                if (i == _day)
                { 
                    Console.ForegroundColor = ConsoleColor.Magenta;
                  

                }
                else Console.BackgroundColor = ConsoleColor.Black;

                if ((i+r)%7!=0)
                Console.Write("\t" + i);
                else Console.WriteLine("\t"+i+"\n"); 
                 
            }


            //Console.WriteLine(_day);
            //Console.WriteLine(_month);
            //Console.WriteLine(_year);
       
        }

    }
}
