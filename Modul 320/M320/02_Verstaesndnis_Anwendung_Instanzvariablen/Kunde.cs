using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Kunde
    {
       //List<Konto> KontoListe = new List<Konto>();

       // public Kunde()
       // {
       //     KontoListe.Add(new Konto());
       // }

       // public void AddKonto()
       // {
       //     KontoListe.Add(new Konto());
       // }

        List<Buch> Buecher = new List<Buch>();

        public void AddBuch(Buch buch)
        {
            Buecher.Add(buch);
        }






    }
}
