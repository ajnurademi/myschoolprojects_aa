using System.Drawing;

namespace Geometrische_Figuren
{
    public class Program
    {
        public static void Main()
        {
            /*
                Geometrische Figuren     
                Autor: Ajnur Ademi
                Version: 0.7
            */

            List<Figuren> figures = new List<Figuren>();

            Figuren kreis = new Kreis(150, 100, 100);
            Figuren rechteck = new Rechteck(200, 250, 6, 8);
            Figuren dreieck = new Dreieck(100, 100, 100, 30, 40, 40);
            Quadrat quadrat = new Quadrat(4, 100, 100);

            figures.Add(kreis);
            figures.Add(rechteck);
            figures.Add(dreieck);
            figures.Add(quadrat);

            foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.Name}");
                Console.WriteLine($"------------------");
                figure.PrintPosition();
                figure.PrintArea();
                figure.PrintUmfang();
                //figure.Rotate();  Der entscheidende Teil ist if (figure is IRotatable rotatable) und dann das Aufrufen von rotatable.Rotate(). Dies stellt sicher, dass nur Objekte, die die IRotatable-Schnittstelle implementieren, die Rotate-Methode aufrufen können. 

                if (figure is IRotatable rotatable)
                {
                    rotatable.Rotate();
                }

                Console.WriteLine();
            }
        }
    }
}