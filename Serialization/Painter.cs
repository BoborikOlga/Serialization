using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Painter : CultureWorker
    {
        public string Genre { get; set; }
       
        public Painter(string name, string surname, int age, string country, string sex, List<string> pictures, string genre)
            : base(name, surname, age, country, sex, pictures)
        {
            Genre = genre;
                 
        }
    }
}
