using System;
using System.Collections.Generic;
using System.Text;

namespace DataHandler_harjoitus
{
    public class Person
    {
        public string name;
        public int age;
        public bool employed;
        public List<string> hobbies = new List<string>();
       

        public Person()
        {

        } 

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, bool employed, List<string> hobbies)
        {
            this.name = name;
            this.age = age;
            this.employed = employed;
            this.hobbies = hobbies;
        }
        
    }
}
