using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Singer : CultureWorker
    {
        public string MusicStyle { get; set; }
        public string Group { get; set; }

        public Singer(string name, string surname, int age, string country, string sex,  List<string> albums, string style, string group)
            : base(name, surname, age, country, sex, albums)
        {
            MusicStyle = style;
            Group = group;
        }


    }
}
