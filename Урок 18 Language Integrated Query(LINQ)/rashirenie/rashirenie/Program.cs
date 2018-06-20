

using static System.Console;

namespace SimpleProject
{
    static class ExampleExtensions
    {
        public static int NumberWords(this string data)//тип параметра должен совпадать с класом который расширяем
        {
            if (string.IsNullOrEmpty(data))
            {
                return 0;
            }

            data = System.Text.RegularExpressions.Regex.Replace(data.Trim(), @"\s+", " ");

            return data.Split(' ').Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите строку:");

            string str = ReadLine();

            WriteLine($"Количество слов в строке: {str.NumberWords()}");
        }
    }
}
