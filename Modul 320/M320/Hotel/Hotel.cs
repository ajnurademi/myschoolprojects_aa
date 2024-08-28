using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hotel
    {
        public string name;
        public string adresse;

        Reception reception;
        List<Zimmer> zimmerList = new List<Zimmer>();
        List<Sitzungszimmer> sitzungszimmern = new List<Sitzungszimmer>();

        public Hotel(Zimmer zimmer)
        {
            zimmerList.Add(zimmer);
        }

        public void AddZimmer(Zimmer zimmer)
        {
            if(zimmerList.Count < 10)
            {
                zimmerList.Add(zimmer);
            }
            else
            {
                Console.WriteLine("Es gibt zu viele Zimmer");
            }
        }

        public void AddSitzungszimmer(Sitzungszimmer sitzungszimmer)
        {
            if(sitzungszimmern.Count < 3)
            {
                sitzungszimmern.Add(sitzungszimmer);
            }
            else
            {
                Console.WriteLine("Es gibt zu viele Sitzungszimmer");
            }
        }

   



    }
}
