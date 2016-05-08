using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Anchorman : Person
    {
        public string TVProgramName {get; set;}
        public string TVChannel { get; set; }

        public Anchorman(string name, string surname, int age, string country, string sex, string program, string channal )
            : base(name, surname, age, country, sex)
        {
            TVProgramName = program;
            TVChannel = channal;
        }
    }
}
