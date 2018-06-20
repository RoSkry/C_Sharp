
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
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "Car" && reader.AttributeCount > 0)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            if (reader.Name == "Image")
                            {
                                WriteLine(reader.Value);
                                break;
                            }
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