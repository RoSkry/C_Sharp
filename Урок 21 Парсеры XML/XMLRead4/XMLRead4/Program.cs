
using System;
using System.Xml;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Cars.xml");

                XmlNode root = doc.DocumentElement;
                // удалить первый элемент Cars
                root.RemoveChild(root.FirstChild);
                // создать узлы элементов.
                XmlNode bike = doc.CreateElement("Motorcycle");
                XmlNode elem1 = doc.CreateElement("Nanufactured");
                XmlNode elem2 = doc.CreateElement("Model");
                XmlNode elem3 = doc.CreateElement("Year");
                XmlNode elem4 = doc.CreateElement("Color");
                XmlNode elem5 = doc.CreateElement("Engine");
                // создать текстовые узлы
                XmlNode text1 = doc.CreateTextNode("Harley-Davidson Motor Co. Inc.");
                XmlNode text2 = doc.CreateTextNode("Harley 20J");
                XmlNode text3 = doc.CreateTextNode("1920");
                XmlNode text4 = doc.CreateTextNode("Olive");
                XmlNode text5 = doc.CreateTextNode("37 HP");
                // присоединить текстовые узлы к узлам элементов
                elem1.AppendChild(text1);
                elem2.AppendChild(text2);
                elem3.AppendChild(text3);
                elem4.AppendChild(text4);
                elem5.AppendChild(text5);
                // присоединить узлы элементов к узлу bike
                bike.AppendChild(elem1);
                bike.AppendChild(elem2);
                bike.AppendChild(elem3);
                bike.AppendChild(elem4);
                bike.AppendChild(elem5);
                // присоединить узел bike к корневому узлу
                root.AppendChild(bike);

                doc.Save("Motorcycle.xml"); // сохранить измененный документ

                WriteLine("The Motorcycle.xml file is generated!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
