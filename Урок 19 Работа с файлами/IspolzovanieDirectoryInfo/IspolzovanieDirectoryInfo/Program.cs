﻿using System.IO;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("."); // текущий каталог
            WriteLine($"Full path to the directory:\n{dir.FullName}");
            WriteLine($"Time of creation: {dir.CreationTime}");

            WriteLine("\n\tAll directory files:");
            FileInfo[] files = dir.GetFiles(); // все файлы в каталоге
            foreach (FileInfo f in files)
            {
                WriteLine(f.Name);
            }
            WriteLine();
        }
    }
}
