using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace SimpleProject
{
    /// <summary>
    /// Обобщенный интерфейс с методам вычисления суммы
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ICalc<T>
    {
        T Sum(T b);
    }
    class Program
    {
        /// <summary>
        /// Необобщенный класс, реализующий интерфейс ICalc
        /// </summary>
        class CalcInt : ICalc<CalcInt>
        //при наследовании указывается реальный тип данных
        {
            int _number = 0;
            public CalcInt(int n)
            {
                _number = n;
            }

            //при реализации методов вместо обобщенного типа 
            //используется тип CalcInt
            public CalcInt Sum(CalcInt b)
            {
                return new CalcInt(_number + b._number);
            }

            public override string ToString()
            {
                return _number.ToString();
            }
        }
        /// <summary>
        /// Обобщенный класс, который содержит в себе 
        /// коллекцию данных обобщеного типа
        /// и имеет метод вычисления суммы
        /// Для вычисления суммы задается оганичение: 
        /// параметр типа должен реализовать интерфейс ICalc<T>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class MyList<T> where T : ICalc<T>
        {
            //коллекция данных обобщенного типа
            List<T> list = new List<T>();
            //метод добавления данных в коллекцию
            public void Add(T t)
            {
                list.Add(t);
            }
            //метод вычисления суммы
            public T Sum()
            {
                if (list.Count == 0)
                {
                    return default(T);
                }
                T result = list[0];
                //для суммирования используется метод интерфейса ICalc<T>
                for (int i = 1; i < list.Count; i++)
                {
                    result = result.Sum(list[i]);
                }
                return result;
            }
        }

        static void Main(string[] args)
        {
            MyList<CalcInt> myList = new MyList<CalcInt>();
            myList.Add(new CalcInt(10));
            myList.Add(new CalcInt(20));
            myList.Add(new CalcInt(23));
            WriteLine($"Сумма элементов коллекции: {myList.Sum()}");
        }
    }
}