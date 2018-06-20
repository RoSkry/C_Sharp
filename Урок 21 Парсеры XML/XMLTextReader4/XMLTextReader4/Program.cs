
using System;
using System.Xml;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader("Cars.xml");
                reader.WhitespaceHandling = WhitespaceHandling.None;
                while (reader.Read())
                {
                    WriteLine($"Type={reader.NodeType}\t\tName={reader.Name}\t\tValue={reader.Value}");
                    if (reader.AttributeCount > 0)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            WriteLine($"Type={reader.NodeType}\tName={reader.Name}\tValue={reader.Value}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
