using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Torwart
    {
        public string Name { get; private set; }

        public string SchussHalten()
        {
            return $"{Name} hält den Schuss vom Gegner!";
        }

        public string Abstoss()
        {
            return $"{Name} macht einen Abstoss!";
        }

        public Torwart(string name)
        {
            Name = name;
        }
    }
}
