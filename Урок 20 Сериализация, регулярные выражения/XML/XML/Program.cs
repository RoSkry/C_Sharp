
using System;
using System.IO;
using System.Xml.Serialization;
using static System.Console;

namespace SimpleProject
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        int _identNumber;

        [NonSerialized]
        const string Planet = "Earth";

        public Person() { }

        public Person(int number)
        {
            _identNumber = number;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Identification number: { _identNumber}, Planet: {Planet}.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(346875) { Name = "Jack", Age = 34 };

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Person));
            try
            {
                using (Stream fStream = File.Create("test.xml"))
                {
                    xmlFormat.Serialize(fStream, person);
                }
                WriteLine("XmlSerialize OK!\n");

                Person p = null;
                using (Stream fStream = File.OpenRead("test.xml"))
                {
                    p = (Person)xmlFormat.Deserialize(fStream);
                }
                WriteLine(p);
            }
            catch (Exception ex)
            {
                WriteLine(ex);
            }
        }
    }
}
