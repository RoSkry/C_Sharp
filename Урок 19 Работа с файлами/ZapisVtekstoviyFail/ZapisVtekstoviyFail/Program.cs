using System.IO;
using System.Text;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    // получаем данные для записи в файл
                    WriteLine("Enter the data to write to the file:");
                    string writeText = ReadLine();
                    // записываем данные в файл
                    sw.WriteLine(writeText);//записвает весь текст

                    foreach (var item in writeText)//записывает посимвольно
                    {
                        sw.Write($"{item} ");
                    }

                    WriteLine("\nData recorded!");
                }
            }
        }
    }
}
