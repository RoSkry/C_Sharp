
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using static System.Console;

namespace SimpleProject
{
    [Serializable]
    public class Person : ISerializable
    {
        public string Name { get; set; }

        public DateTime DateBirth { get; set; }

        public Person() { }

        private Person(SerializationInfo info, StreamingContext context)//для дессириализации
        {
            Name = info.GetString("PersonName").ToUpper();
            DateBirth = info.GetDateTime("DateBirth").ToUniversalTime();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("PersonName", Name.ToLower());
            info.AddValue("DateBirth", DateBirth.ToLocalTime());
        }

        public override string ToString()
        {
            return $"Name: {Name}, Date of Birth: {DateBirth}.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Jack", DateBirth = new DateTime(1995, 11, 5) };

            SoapFormatter soapFormat = new SoapFormatter();
            try
            {
                using (Stream fStream = File.Create("test.soap"))
                {
                    soapFormat.Serialize(fStream, person);
                }
                WriteLine("SoapSerialize OK!\n");

                Person p = null;
                using (Stream fStream = File.OpenRead("test.soap"))
                {
                    p = (Person)soapFormat.Deserialize(fStream);
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