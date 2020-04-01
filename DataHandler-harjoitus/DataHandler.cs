using System;
using System.Collections.Generic;
using System.Text;

namespace DataHandler_harjoitus
{
    public class DataHandler
    {
        List<Person> persons = new List<Person>();
        public int counter;        

        public void AddPersonToList(Person newPersons)
        {
            persons.Add(newPersons);
            Console.WriteLine("Persons added to the list");
        }
        
        public void PrintPersons()
        {
            foreach (var tyypit in persons)
            {
                Console.WriteLine($"{tyypit.name} {tyypit.age}");
            }
        }

        public Person CreatePerson()
        {
            Console.WriteLine("syötä henkilön nimi:");
            string name = Console.ReadLine();
            Console.WriteLine("syötä henkilön ikä:");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person(name, age);
            return person;
        }
    }

}
