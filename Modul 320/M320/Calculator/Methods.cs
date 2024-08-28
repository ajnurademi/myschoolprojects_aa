using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Methods
    {
        public int LastResult { get; set; }

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraktion(int a, int b)
        {
            return a - b;
        }

        public static int Multiplikation(int a, int b)
        {
            return a * b;
        }

        public static int GanzZahlDivision(int a, int b)
        {
            if (a != 0)
            {
                return a / b;
            }
            if (a % b != 0 && a % b == 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Keine Ganzzahl oder Null");
                return -1;
            }
        }

        public static void Menu()
        {
            // Menü
            Console.WriteLine("\n[1] Addition");
            Console.WriteLine("[2] Subtraktion");
            Console.WriteLine("[3] Multiplikation");
            Console.WriteLine("[4] GanzZahlDivision");
            Console.WriteLine("[5] Beenden");
            Console.WriteLine("\nWählen Sie den gewünschten Rechenoperator aus:");
        }
    }
}
