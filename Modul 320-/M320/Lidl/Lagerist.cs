using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Lagerist : Person
    {
        public int Grousse { get; set; }


        public Lagerist(int a, int b) : base (a)
        {
            Console.WriteLine("print LAGERISTconstrukctor");
        }

        public void LagerEin()
        {
            Console.WriteLine($"Lagerist: {Vorname} {Name} lagert ein");
        }

        public override void Trage()
        {
            Console.WriteLine($"Lagerist: {Vorname} {Name} {Id} trägt ein Stapler");
        }
    }
}
