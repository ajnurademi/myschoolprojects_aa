using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Markisensteuerung : ZimmerDecorator
    {
        private IZimmer zimmer;
        private bool markisenOffen { get; set; }

        public Markisensteuerung(IZimmer zimmer) : base(zimmer)
        {
            this.zimmer = zimmer;
        }

        /// <summary>
        /// Verarbeitet die Wetterdaten für Markisensteuerung
        /// </summary>
        /// <param name="wetterdaten"></param>
        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (wetterdaten.Aussentemperatur > this.Zimmer.TemperaturVorgabe)
            {
                if (!markisenOffen && wetterdaten.Windgeschwindigkeit <= 30)
                {
                    // Markise öffnen
                    Console.WriteLine($"{this.Name}: Markise ÖFFNEN.\n");
                    markisenOffen = true;
                }
            }
            else
            {
                // Markise schliessen
                if (markisenOffen)
                {
                    Console.WriteLine($"{this.Name}: Markise SCHLIESSEN.\n");
                    markisenOffen = false;
                }
            }

            base.VerarbeiteWetterdaten(wetterdaten); // Aufruf der Methode in der Basisklasse
        }
    }
}

