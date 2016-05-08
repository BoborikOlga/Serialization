using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Politician : Person
    {
        public string Сonsignment { get; set; }

        public Politician(string name, string surname, int age, string country, string sex, string consignment)
            : base(name, surname, age, country, sex)
        {
            Сonsignment = consignment;
        }

    }
}
