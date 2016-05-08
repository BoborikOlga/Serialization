using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public abstract class Person
    {
        public string Name {get; set;}
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Sex { get; set; }
        
        public Person(string name, string surname, int age, string country, string sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Country = country;
            Sex = sex;
        }
    }
}
