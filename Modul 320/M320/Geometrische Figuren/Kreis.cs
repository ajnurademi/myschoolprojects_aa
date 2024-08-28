using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public class Kreis : Figuren
    {
        private float radius { get; set; } = 50;
        private float durchmesser { get; set; } = 100;
        private float umfang;
        private static float Pi = 3.141f;

        public Kreis(float radius, float x, float y)
        {
            this.Name = "Kreis";
            this.radius = radius;
            this.PostitionX = x;
            this.PostitionY = y;

            durchmesser = 2 * radius;
        }

        public override void PrintPosition()
        {
            float mittelpunktX = PostitionX + radius;
            float mittelpunktY = PostitionY + radius;
            Console.WriteLine($"Der Mittelpunkt des {Name} ist bei X={mittelpunktX}, Y={mittelpunktY}");
        }

        public override void PrintArea()
        {
            float fleache = Pi * radius * radius;
            Console.WriteLine($"Die Fläche des {Name} beträgt {fleache} ^2");
        }

        public override void PrintUmfang()
        {
            float umfang = Pi * 2 * Pi;
            Console.WriteLine($"Der Umfang des {Name} beträgt {umfang}");
        }
    }
}
