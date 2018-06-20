
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;

namespace SimpleProject
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        int _identNumber;

        [NonSerialized]
        const string Planet = "Earth";// информация не участвует в процессе сериализации, если случайные значения,фиксированые и кратковременные 

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
            BinaryFormatter binFormat = new BinaryFormatter();//обеспечивает бинарную  сериализацию, перевод обьекта в бинарный вид 
            try
            {
                using (Stream fStream = File.Create("test.bin"))
                {
                    binFormat.Serialize(fStream, person);
                }
                WriteLine("BinarySerialize OK!\n");

                Person p = null;
                using (Stream fStream = File.OpenRead("test.bin"))
                {
                    p = (Person)binFormat.Deserialize(fStream);
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
//сериализация помещение обьектов в поток