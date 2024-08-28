using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Heizungsventil : ZimmerDecorator
    {
        private bool heizungsventilOffen { get; set; }
        private IZimmer zimmer; 

        public Heizungsventil(IZimmer zimmer): base(zimmer)
        {
            this.zimmer = zimmer;
        }

        /// <summary>
        /// Verarbeitet die Wetterdaten für Heizungsventil
        /// </summary>
        /// <param name="wetterdaten"></param>
        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (wetterdaten.Aussentemperatur < this.zimmer.TemperaturVorgabe)
            {
                // Ventil öffnen
                if (!this.heizungsventilOffen)
                {
                    Console.WriteLine($"{this.Name}: Heizungsventil ÖFNNEN.\n");
                    heizungsventilOffen = true;
                }
            }
            else
            {
                // Ventil schliessen
                if (this.heizungsventilOffen)
                {
                    Console.WriteLine($"{this.Name}: Heizungsventil SCHLIESSEN.\n");
                    heizungsventilOffen = false;
                }
            }

            base.VerarbeiteWetterdaten(wetterdaten);
        }

    }
}
