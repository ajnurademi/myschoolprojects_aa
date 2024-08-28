using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Kunde_k
    {
        List<Konto> konten = new List<Konto>();

        public void AddKonten(Konto konto)
        {
            if(konten.Count < 5)
            {
                konten.Add(konto);
            }
            else
            {
                Console.Write("Sie haben das Limit von 5 Konten erreicht");
            }
        }   



    }
}
