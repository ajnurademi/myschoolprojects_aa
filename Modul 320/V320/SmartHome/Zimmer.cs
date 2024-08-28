using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Die abstrakte Klasse Zimmer stellt die Grundlage für verschiedene Räume in der Wohnung dar.
    /// </summary>
    public abstract class Zimmer : IZimmer
    {
        /// <summary>
        /// Verschiedene Eigenschaften des Raums
        /// </summary>
        public string Name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }


        /// <summary>
        /// Initialisiert die grundlegenden Eigenschaften eines Raums.
        /// </summary>
        /// <param name="name">Der Name des Raums.</param>
        /// <param name="temp">Die Temperaturvorgabe für den Raum.</param>
        /// <param name="personTrueOrFalse">Gibt an, ob sich Personen im Raum befinden.</param>
        public Zimmer(string name)
        {
            this.Name = name;
        }
        

        /// <summary>
        /// Verarbeitet die aktuellen Wetterdaten für den Raum.
        /// </summary>
        /// <param name="wetterdaten">Die aktuellen Wetterdaten.</param>
        public virtual void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"Wetterdaten für {this.Name} verarbeitet: Temperaturvorgabe: {this.TemperaturVorgabe}°C, Personen im Zimmer: {(this.PersonenImZimmer ? "ja" : "nein")}.");
        }
    }
}
