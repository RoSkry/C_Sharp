
using System;
using System.Xml;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter("Cars.xml", System.Text.Encoding.Unicode);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Cars");
                writer.WriteStartElement("Car");
                writer.WriteAttributeString("Image", "MyCar.jpeg");
                writer.WriteElementString("Manufactured", "La Hispano Suiza de Automovils");
                writer.WriteElementString("Model", "Alfonso");
                writer.WriteElementString("Year", "1912");
                writer.WriteElementString("Color", "Black");
                writer.WriteElementString("Speed", "130");
                writer.WriteEndElement();
                writer.WriteEndElement();
                WriteLine("The Cars.xml file is generated!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}

