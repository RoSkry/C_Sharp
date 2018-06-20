using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilestreamZapisiChitivanie1
{
    class Program
    {
        class Test : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispose");
            }
        }
        static void Main(string[] args)
        {
            using (Test t = new Test())
            { }




            string filePath = "test.bin";

            try
            {
                WriteFile(filePath);
                Console.WriteLine(ReadFile(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void WriteFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Console.WriteLine("Enter text");
                string text = Console.ReadLine();
                byte[] bytes = Encoding.Default.GetBytes(text);//переводим строку в байты 
                stream.Write(bytes, 0, bytes.Length);//0 - с какого начинать
            }
            //stream.Close();
            Console.WriteLine("Ok!");
        }
        private static string ReadFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                byte[] bytes = new byte[(int)stream.Length];
                stream.Read(bytes, 0, bytes.Length);
                return Encoding.Default.GetString(bytes);
                
            }
        }
    }
}
