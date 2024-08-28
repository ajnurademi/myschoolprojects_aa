namespace SmartHome
{
    /// <summary>
    /// Die Klasse Wohnung repräsentiert eine Smart-Home-Umgebung mit verschiedenen Räumen und Geräten.
    /// Sie verwaltet die Verarbeitung von Wetterdaten für jeden Raum.
    /// </summary>
    public class Wohnung
    {
        private List<IZimmer> zimmerList = new List<IZimmer>();
        private Wettersensor wettersensor;

        /// <summary>
        /// Konstruktor für die Wohnungsklasse. Initialisiert die Wohnung mit einem Wettersensor und verschiedenen Räumen.
        /// </summary>
        /// <param name="wettersensor">Der Wettersensor, der für die Wetterdaten in der Wohnung verwendet wird.</param>
        public Wohnung(Wettersensor wettersensor)
        {
            this.wettersensor = wettersensor;

            this.zimmerList.Add(new Heizungsventil(new BadWC()));
            this.zimmerList.Add(new Jalousiesteuerung(new Heizungsventil(new Wohnzimmer())));
            this.zimmerList.Add(new Jalousiesteuerung(new Heizungsventil(new Schlafzimmer())));
            this.zimmerList.Add(new Jalousiesteuerung(new Heizungsventil(new Kueche())));
            this.zimmerList.Add(new Jalousiesteuerung(new Markisensteuerung(new Wintergarten())));
        }

        /// <summary>
        /// Generiert und verarbeitet die aktuellen Wetterdaten für alle Räume in der Wohnung.
        /// </summary>
        public void GenerateWetterdaten()
        {
            this.wettersensor.Tick();
            Wetterdaten wetterdaten = this.wettersensor.GetWetterDaten();

            Console.WriteLine("\n\n|------------------------------------------------------------------|:");
            Console.WriteLine("| Verarbeite Wetterdaten:                                          ");
            Console.WriteLine("| --------------------------                                       ");
            Console.WriteLine($"| Aussentemperatur: {wetterdaten.Aussentemperatur}°C              ");
            Console.WriteLine($"| Windgeschwindigkeit: {wetterdaten.Windgeschwindigkeit}km/h      ");
            Console.WriteLine($"| Regen: {(wetterdaten.Regen ? "ja" : "nein")}                    ");
            Console.WriteLine("|------------------------------------------------------------------|:\n");

            foreach (var zimmer in this.zimmerList)
            {
                zimmer.VerarbeiteWetterdaten(wetterdaten);
            }
        }

        /// <summary>
        /// Setzt die Anzahl der Personen in einem bestimmten Raum.
        /// </summary>
        /// <param name="zimmername">Der Name des Raums, in dem die Anzahl der Personen gesetzt werden soll.</param>
        /// <param name="personenImZimmer">Die Anzahl der Personen im Raum (true, wenn Personen vorhanden sind, false, wenn nicht).</param>
        public void SetPersonenImZimmer(string zimmername, bool personenImZimmer)
        {
            var zimmer = this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if (zimmer != null)
            {
                zimmer.PersonenImZimmer = personenImZimmer;
            }
        }

        /// <summary>
        /// Setzt die Temperaturvorgabe für einen bestimmten Raum.
        /// </summary>
        /// <param name="zimmername">Der Name des Raums, für den die Temperaturvorgabe gesetzt werden soll.</param>
        /// <param name="temperaturvorgabe">Die gewünschte Temperaturvorgabe für den Raum.</param>
        public void SetTemperaturvorgabe(string zimmername, double temperaturvorgabe)
        {
            var zimmer = this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if (zimmer != null)
            {
                zimmer.TemperaturVorgabe = temperaturvorgabe;
            }
        }
    }
}
