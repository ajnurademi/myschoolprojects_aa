using System;
using System.Collections.Generic;

namespace Fussballmannschaft
{
    class Program
    {
        static void Main(string[] args)
        { 
            Fussballmannschaft heimMannschaft = new Fussballmannschaft("Heim");
            Fussballmannschaft gastMannschaft = new Fussballmannschaft("Gast");

            for (int i = 1; i <= 10; i++)
            {
                heimMannschaft.FeldspielerListe.Add(new Feldspieler { Name = $"HeimSpieler {i}" });
                gastMannschaft.FeldspielerListe.Add(new Feldspieler { Name = $"GastSpieler {i}" });
            }

            heimMannschaft.TorwartListe.Add(new Torwart("Heim Torwart"));
            gastMannschaft.TorwartListe.Add(new Torwart("Gast Torwart"));

            Resultat resultat = new Resultat();

            resultat.ToreHeimMannschaft = heimMannschaft.Spielzug();
            resultat.ToreGastMannschaft = gastMannschaft.Spielzug();

            Console.WriteLine($"Ergebnis: {heimMannschaft.Name} {resultat.ToreHeimMannschaft} - {resultat.ToreGastMannschaft} {gastMannschaft.Name}");
        }
    }
}
