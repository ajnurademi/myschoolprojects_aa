using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public class Dreieck : Figuren, IRotatable
    {
        private float grundseite { get; set; } = 75;
        private float seiteB { get; set; } = 75;
        private float seiteC { get; set; } = 75;
        private float hoehe { get; set; } = 20;
        private static float winkelSumme { get; set; } = 180;

        public Dreieck(float A, float B, float C, float hoehe, float x, float y)
        {
            Name = "Dreieck";
            this.grundseite = A;
            this.seiteB = B;
            this.seiteC = C;
            this.hoehe = hoehe;
            this.PostitionX = x;
            this.PostitionY = y;
        }

        public override void PrintArea()
        {
            float area = 0.5f * grundseite * hoehe;
            Console.WriteLine($"Die Fläche des {Name} beträgt {area}  ^2");
        }

        public override void PrintUmfang()
        {
            float umfang = grundseite + seiteB + seiteC;
            Console.WriteLine($"Der Umfang des {Name} beträgt {umfang}");
        }

        public void Rotate()
        {
            Console.WriteLine($"{Name} wurde um 90 Grad im Uhrzeigersinn gedreht.");
        }
    }
}
