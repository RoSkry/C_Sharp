
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleApplication1
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }//если не укажем, то не участвует в сериализации
        [DataMember]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name} Возраст: {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            List<Person> people = new List<Person>
            {
                new Person { Name = "Tom", Age = 29 },
                new Person { Name = "Bill", Age = 25 }
            };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Person>));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                List<Person> newPeople = (List<Person>)jsonFormatter.ReadObject(fs);

                foreach (Person p in newPeople)
                {
                    Console.WriteLine(p);
                }
            }

            Console.ReadLine();
        }
    }
}