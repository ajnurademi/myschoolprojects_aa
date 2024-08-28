using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IZimmer
    {
        string Name { get; set;  }
        bool PersonenImZimmer { get; set; }
        double TemperaturVorgabe { get; set; }

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {

        }
    }
}
