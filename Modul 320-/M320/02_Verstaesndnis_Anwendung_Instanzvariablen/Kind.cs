using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    internal class Kind
    {
        private Vater vater;

        public void SetVater(Vater vater)
        {
            this.vater = vater;
        }
    }
}
