using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class BadWC: Zimmer
    {
        public BadWC() : base("BadWC")
        {

        }
        public double Feuchtigkeit { get; set; }
        
    }
}
