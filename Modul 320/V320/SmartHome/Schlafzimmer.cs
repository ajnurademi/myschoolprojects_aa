using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Schlafzimmer : Zimmer
    {
        public Schlafzimmer() : base("Schlafzimmer")
        {

        }
        public DateTime Weckzeit {  get; set; }

    }
}
