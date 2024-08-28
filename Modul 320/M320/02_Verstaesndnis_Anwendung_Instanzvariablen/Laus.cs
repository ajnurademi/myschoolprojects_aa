using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Laus
    {
        private Hund wirt;

        public Laus(Hund hund)
        { 
            this.wirt = hund;   
            wirt.AddLAus(this);
        }


    }
}
