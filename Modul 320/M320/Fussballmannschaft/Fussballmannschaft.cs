using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fussballmannschaft
{
    public class Fussballmannschaft
    {
        public string Name { get; private set; }
        public List<Feldspieler> FeldspielerListe { get; set; }
        public List<Torwart> TorwartListe { get; set; }
        private Random random;

        public Fussballmannschaft(string name)
        {
            Name = name;
            FeldspielerListe = new List<Feldspieler>();
            TorwartListe = new List<Torwart>();
            random = new Random();
        }

        public int Spielzug()
        {
            int tore = 0;

            // Wählt einen zufälligen Feldspieler/Torwart aus der Liste aus
            var randomFeldspieler = FeldspielerListe.OrderBy(x => random.Next()).Take(5).ToList();
            var randomTorwart = TorwartListe.OrderBy(x => random.Next()).Take(2).ToList();

            foreach (Feldspieler feldspieler in randomFeldspieler)
            {
                int zufallsAktion = random.Next(3);

                switch (zufallsAktion)
                {
                    case 0:
                        Console.WriteLine(feldspieler.AufsTorSchiessen(feldspieler.Name));
                        break;
                    case 1:
                        Console.WriteLine(feldspieler.Graetschen(feldspieler.Name));
                        break;
                    case 2:
                        Console.WriteLine(feldspieler.Dribbeln(feldspieler.Name));
                        break;
                }
            }

            foreach (Torwart torwart in randomTorwart)
            {
                int zufallAktion = random.Next(0,1);

                switch (zufallAktion)
                {
                    case 0:
                        Console.WriteLine(torwart.SchussHalten());
                        break;
                    case 1:
                        Console.WriteLine(torwart.Abstoss());
                        break;
                }
            }

            tore = random.Next(6);

            return tore;
        }
    }
}
