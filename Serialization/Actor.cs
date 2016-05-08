using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Actor: CultureWorker
    {

        public Actor(string name, string surname, int age, string country, string sex, List<string> films)
            : base(name, surname, age, country, sex, films)
        {
            
        }
    }
}
