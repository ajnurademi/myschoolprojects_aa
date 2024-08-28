using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public abstract class ZimmerDecorator : IZimmer
    {
        /// <summary>
        /// Vererbung von IZimmer
        /// </summary>
        protected IZimmer Zimmer { get; set; }
        public string Name
        {
            get
            {
                return this.Zimmer.Name;
            }
            set
            {
                this.Zimmer.Name = value;
            }
        }
        public double TemperaturVorgabe
        {
            get
            {
                return this.Zimmer.TemperaturVorgabe;
            }
            set
            {
                this.Zimmer.TemperaturVorgabe = value;
            }
        }
        public bool PersonenImZimmer
        {
            get
            {
                return this.Zimmer.PersonenImZimmer;
            }
            set
            {
                this.Zimmer.PersonenImZimmer = value;
            }
        }



        /// <summary>
        /// Konstruktor für die ZimmerDecorator-Klasse.
        /// </summary>
        /// <param name="zimmer">Das zu dekorierende Zimmer-Objekt.</param>
        public ZimmerDecorator(IZimmer zimmer)
        {
            this.Zimmer = zimmer;
        }

        /// <summary>
        /// Verarbeitet die Wetterdaten für das dekorierte Zimmer.
        /// </summary>
        /// <param name="wetterdaten">Die aktuellen Wetterdaten.</param>
        public virtual void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Zimmer.VerarbeiteWetterdaten(wetterdaten);
        }
    }
}
