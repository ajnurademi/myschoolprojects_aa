using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Jalousiesteuerung : ZimmerDecorator
    {
        private bool jalousienOffen { get; set; }

        public Jalousiesteuerung(IZimmer zimmer) : base(zimmer)
        {

        }

        /// <summary>
        /// Verarbeitet die Wetterdaten für Jalousiesteuerung
        /// </summary>
        /// <param name="wetterdaten">wetterdaten für die verarbeitung</param>

        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"{this.Name}: VerarbeiteWetterdaten aufgerufen.\n");
            // Rest des Codes

            if (wetterdaten.Aussentemperatur > this.Zimmer.TemperaturVorgabe)
            {
                // Jalousie schließen
                if (!this.jalousienOffen)
                {
                    Console.WriteLine($"{this.Name}: Jalousie SCHLIESSEN.\n");
                    jalousienOffen = true;
                }
            }
            else
            {
                // Jalousie öffnen
                if (this.jalousienOffen)
                {
                    Console.WriteLine($"{this.Name}: Jalousie ÖFFNEN.\n");
                    jalousienOffen = false;
                }
            }

            base.VerarbeiteWetterdaten(wetterdaten);
        }


    }
}
