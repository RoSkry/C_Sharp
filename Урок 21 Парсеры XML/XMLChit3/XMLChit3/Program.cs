
using System;
using System.Xml;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void OutputNode(XmlNode node)
        {
            WriteLine($"Type={node.NodeType}\tName={node.Name}\tValue={node.Value}");
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attr in node.Attributes)
                    WriteLine($"Type= {attr.NodeType}\tName={attr.Name}\tValue={attr.Value}");
            }
            if (node.HasChildNodes)
            {
                foreach (XmlNode child in node.ChildNodes)
                    OutputNode(child);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Cars.xml");
                OutputNode(doc.DocumentElement);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}