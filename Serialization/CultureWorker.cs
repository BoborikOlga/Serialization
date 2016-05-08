using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class CultureWorker : Person
    {
        public List<string> Works { get; set; }

        public CultureWorker(string name, string surname, int age, string country, string sex, List<string> works)
            : base(name, surname, age, country, sex)
        {
            foreach (string s in works)
            {
                Works.Add(s);
            }        
        }
    }
}
