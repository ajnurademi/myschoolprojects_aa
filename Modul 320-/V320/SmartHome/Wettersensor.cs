using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Wettersensor
    {
        
        private double aktuelleTemperatur;
        private Random random;
        private const int MAX_TEMP = 30; 
        private const int MIN_TEMP = 0;

        private const double TEMPERATURE_WECHSEL_RATE = 5; 


        public Wettersensor()
        {
            random = new Random();
            aktuelleTemperatur = ZufallsTemperatur();
        }

        /// <summary>
        /// ruft Tick auf um die aktuelle Temperatur zu ändern dannach werden die Wetterdaten nochmal Refresht
        /// </summary>
        /// <returns> Wetterdaten Object </returns>
        // implem: weterrdaten all 1 min (realistisch)
        public Wetterdaten GetWetterDaten()
        {
            Tick();

            return new Wetterdaten
            {
                Aussentemperatur = Math.Round(aktuelleTemperatur, 1), 
                Regen = SimuliereRegen(),
                Windgeschwindigkeit = Math.Round(SimuliereWindgeschwindigkeit(), 1) 
            };
        }
        
        /// <summary>
        /// Erstellt eine Random Temperatur
        /// </summary>
        /// <returns>returns random temperature in double</returns>

        private double ZufallsTemperatur()
        {
            return random.NextDouble() * (MAX_TEMP - MIN_TEMP) + MIN_TEMP;
        }

        public void Tick()
        {
            aktuelleTemperatur += random.NextDouble() * TEMPERATURE_WECHSEL_RATE - (TEMPERATURE_WECHSEL_RATE / 2);
            aktuelleTemperatur = Math.Max(MIN_TEMP, Math.Min(MAX_TEMP, aktuelleTemperatur));
        }

        /// <summary>
        /// Simuliert Wetter bis 50% 
        /// </summary>
        private bool SimuliereRegen()
        {
            return random.NextDouble() < 0.5; 
        }

        /// <summary>
        /// Simuliert Windgeschwindigkeit bis zu  40km/h
        /// </summary>
        private double SimuliereWindgeschwindigkeit()
        {
            return random.NextDouble() * 75; 
        }
    }
}
