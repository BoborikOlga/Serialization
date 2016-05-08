using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Sportsman : Person
    {
        public string SportKind {get; set;}
        public string Rank { get; set; }
        public string Team { get; set; }

        public Sportsman(string name, string surname, int age, string country, string sex, string sport, string rank, string team )
            : base(name, surname, age, country, sex)
        {
            SportKind = sport;
            Rank = rank;
            Team = team;
        }

    }
}
