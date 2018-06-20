
using System;
using System.IO;
using System.Text;

namespace CSharp
{
    class Program
    {
        static void BinaryFileWrite(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                BinaryWriter writer = new BinaryWriter(fileStream, Encoding.Unicode);
                try
                {
                    Console.WriteLine("Enter text:");
                    string text = Console.ReadLine();
                    double pi = 3.1415926;
                    int number = 23345;

                    writer.Write(text);
                    writer.Write(pi);
                    writer.Write(number);
                }
                finally
                {
                    writer.Close();
                }

                Console.WriteLine("Ok!");
            }
            finally
            {
                fileStream.Close();
            }
        }
        static string BinaryFileRead(string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (BinaryReader reader = new BinaryReader(stream, Encoding.Unicode))
                {
                    return $"{reader.ReadString()}\n{reader.ReadDouble()}\n{reader.ReadInt32()}";
                }
            }
        }

        static void Main(string[] args)
        {
            string filePath = "test.dat";
            try
            {
                BinaryFileWrite(filePath);

                Console.WriteLine(BinaryFileRead(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}