using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Sitzungszimmer
    {
        public int nummer;
        public int anzahlPleatze;
        List<Beamer> beamers = new List<Beamer>();

        public void AddBeamer()
        {
            if(beamers.Count < 3)
            {
                beamers.Add(new Beamer());  
            }
            else
            {
                Console.WriteLine("Es gibt zu viele Beamers im Sitzungszimmer");
            }
        }
        
    }
}
