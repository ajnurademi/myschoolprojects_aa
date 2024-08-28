using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public class Rechteck : Figuren, IRotatable
    {
        private float height { get; set; } = 75;
        private float width { get; set; } = 50;
        private float diganoalenleange { get; set; } = 90.13f;
        private float umfang { get; set; } = 250;
        private int winkelABCD { get; set; } = 90;

        public Rechteck(float A, float B, float x, float y)
        {
            this.Name = "Rechteck";
            this.height = A;
            this.width = B;
            this.PostitionX = x;
            this.PostitionY = y;
        }

        public override void PrintPosition()
        {
            float untereRechteX = PostitionX + height;
            float untereRechteY = PostitionY + width;
            Console.WriteLine($"Die Position der oberen linken Ecke des {Name} ist bei X={PostitionX}, Y={PostitionY}");
            Console.WriteLine($"Die Position der unteren rechten Ecke des {Name} ist bei X={untereRechteX}, Y={untereRechteY}");
        }

        public override void PrintArea()
        {
            float area = height * width;
            Console.WriteLine($"Die Fläche des {Name} beträgt {area} ^2"); 
        }

        public override void PrintUmfang()
        {
            float umfang = height * 2 + width * 2;
            Console.WriteLine($"Der Umfang des {Name} beträgt {umfang}"); 
        }

        public void Diagonalenleange(float A, float B)
        {
            float diganoalenleange = (float)Math.Sqrt(A * A + B * B);
            Console.WriteLine($"Die Länge der Diagonale des {Name} beträgt {diganoalenleange}");
        }

        public void Rotate()
        {
            Console.WriteLine($"{Name} wurde um 90 Grad im Uhrzeigersinn gedreht.");
        }
    }
}
