using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace SimpleProject
{
    class NamedIterator
    {
        const int LIM = 10;
        int _limit;
        public NamedIterator(int limit)
        {
            _limit = limit;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _limit; i++)
            {
                if (i == LIM)
                {
                    yield break; // прерывание итератора по условию
                }
                yield return i;
            }
        }

        public IEnumerable<int> GetRange(int start)
        {
            for (int i = start; i <= _limit; i++)
            {
                yield return i;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите начальное значение: ");
            int start = int.Parse(ReadLine());

            Write("\nВведите конечное значение: ");
            int end = int.Parse(ReadLine());
            NamedIterator namedIterator = new NamedIterator(end);

            Write("\nВсе значения: ");
            foreach (int item in namedIterator)
            {
                Write($"{item} ");
            }

            Write("\n\nЗначения в заданном диапазоне: ");
            foreach (int item in namedIterator.GetRange(start))
            {
                Write($"{item} ");
            }
            WriteLine();
        }
    }
}

