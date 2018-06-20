using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace SimpleProject
{
    /// <summary>
    /// Вспомогательный класс для профилирования участка кода
    /// выполняет измерения времени выполнения
    /// и подсчет количества сборок мусора
    /// </summary>
    internal sealed class OperationTimer : IDisposable
    {
        long _startTime;
        string _text;
        int _collectionCount;

        public OperationTimer(string text)
        {
            PrepareForOperation();

            _text = text;

            // сохраняется количество сборок мусора, выполненных на текущий момент
            _collectionCount = GC.CollectionCount(0);

            // сохраняется начальное время
            _startTime = Stopwatch.GetTimestamp();
        }

        /// <summary>
        /// Вызывается при разрушении объекта
        /// Выводит:
        /// значение времени, прошедшего с момента создания объекта 
        /// до момента его удаления
        /// количество выполненных сборок мусора, выполненных за это время
        /// </summary>
        public void Dispose()
        {
            WriteLine($"{_text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} секунды (сборок мусора {GC.CollectionCount(0) - _collectionCount})");
        }
        /// <summary>
        ///Метод удаляются все неиспользуемые объекты
        ///Это надо для "чистоты эксперимента",
        ///т.е. чтобы сборка мусора происходила только для объектов,
        ///которые будут создаваться в профилируемом блоке кода
        ///</summary>
        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
    class Program
    {
        /// <summary>
        /// метод для тестирования производительности 
        /// обобщенного и необобщенного списка
        /// </summary>
        private static void ValueTypePerfTest()
        {
            const int COUNT = 10000000;

            //объект OperationTimer 
            //создается перед началом использования коллекции
            //после завершения ее использования 
            //выводит время, затраченное на работу с коллекцией  
            using (new OperationTimer("List"))
            {
                //использование обобщенного списка
                List<int> list = new List<int>(COUNT);
                for (int n = 0; n < COUNT; n++)
                {
                    list.Add(n);
                    int x = list[n];
                }
                list = null; // для гарантированного выполнения сборки мусора
            }

            using (new OperationTimer("ArrayList"))
            {
                //использование необобщенного списка
                ArrayList array = new ArrayList();
                for (int n = 0; n < COUNT; n++)
                {
                    array.Add(n); //выполняется упаковка
                    int x = (int)array[n]; //выполняется распаковка
                }
                array = null; // для гарантированного выполнения сборки мусора
            }
        }
        static void Main(string[] args)
        {
            ValueTypePerfTest();
        }
    }
}