using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public class Kind : Person
    {
        public int alter { get; set; }

        public Kind (int a, int b) : base(a)
        {

        }

        public override void Trage()
        {
            Console.WriteLine($"Kind: {Vorname} {Name} wird getragen");
        }

        public override void Esse()
        {
            Console.WriteLine($"Kind {Vorname} {Name} isst ein loli");
        }
    }
}
