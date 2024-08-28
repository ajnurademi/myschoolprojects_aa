using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R6Operators
{
    public class spielfigur
    {
        // Eigenschaften 

        public string anOderve { get; set; }
        public string name { get; set; }
        public string geschlecht { get; set; }
        public string superkraft { get; set; }

        // Konstruktor 
        public spielfigur (string _anOderve, string _name, string _geschlecht, string _superkraft)
        {
            anOderve = _anOderve;
            name = _name;    
            geschlecht = _geschlecht;
            superkraft = _superkraft;
        }

        // Methode 
        public void kaufen()
        {
            Console.WriteLine("\n\nMöchten Sie diesen Operator kaufen ? [Ja = 1] [Nein = 2]");
            var entscheid = Console.ReadLine();

            if (entscheid == "1")
            {
                Console.WriteLine("\nDer Operator wurde erfolgreich freigeschaltet");     
            }
            
            else 
            {
                Console.WriteLine("\nDanke für's vorbeikommen !!!");

            }
        }
    }
}
