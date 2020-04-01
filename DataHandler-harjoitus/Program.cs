using System;
using System.Collections.Generic;

namespace DataHandler_harjoitus
{
    class Program
    {
        static void Main(string[] args)
        {            
            Person tyyppi1 = new Person();
            tyyppi1.name = "Mikko";
            tyyppi1.age = 27;
            tyyppi1.employed = false;
            tyyppi1.hobbies.Add("Jalkapallo, Jääkiekko");
            Person tyyppi2 = new Person();
            tyyppi2.name = "Tommi";
            tyyppi2.age = 19;
            tyyppi2.employed = true;
            tyyppi2.hobbies.Add("Keilaus");
            Person tyyppi3 = new Person();
            tyyppi3.name = "Tiina";
            tyyppi3.age = 31;
            tyyppi3.employed = true;
            tyyppi3.hobbies.Add("Uinti, Taekwondo");
            Person tyyppi4 = new Person();
            tyyppi4.name = "Tero";
            tyyppi4.age = 27;
            tyyppi4.employed = false;
            tyyppi4.hobbies.Add("Piirtäminen");
            Person tyyppi5 = new Person();
            tyyppi5.name = "Kaisa";
            tyyppi5.age = 24;
            tyyppi5.employed = true;
            tyyppi5.hobbies.Add("Kitaran soitto");
            DataHandler dataHandler1 = new DataHandler();
            dataHandler1.AddPersonToList(tyyppi1);
            dataHandler1.AddPersonToList(tyyppi2);
            dataHandler1.AddPersonToList(tyyppi3);
            dataHandler1.AddPersonToList(tyyppi4);
            dataHandler1.AddPersonToList(tyyppi5);
            dataHandler1.PrintPersons();
            dataHandler1.AddPersonToList(dataHandler1.CreatePerson());
            dataHandler1.PrintPersons();
            
        }
    }
}
