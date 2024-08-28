using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Schulhaus
    {
        List<Zimmer> zimmerList = new List<Zimmer>();

        public Schulhaus()
        {
            zimmerList.Add(new Zimmer());
        }
    }
}
