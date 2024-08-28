using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Firma
    {
        public List<Mitarbeiter> Mitarbeiter = new List<Mitarbeiter>();

        public void AddMitarbeiter(Mitarbeiter mitarbeiter)
        {
            Mitarbeiter.Add(mitarbeiter);
        }

        public void RemoveMitarbeiter()
        {
            if(Mitarbeiter.Count > 1)
            {
                Mitarbeiter.RemoveAt(0);
            }
        }

    }
}
