using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmannschaft
{
    public class Feldspieler
    {
        public string Name { get; set; }

        public string AufsTorSchiessen(string name)
        {
            return $"{name} schiesst aufs Tor!";
        }

        public string Graetschen(string name)
        {
            return $"{name} macht eine Blutgraetsche!";
        }

        public string Dribbeln(string name)
        {
            return $"{name} dribbelt den Gegner schwindlig!";
        }
    }
}
