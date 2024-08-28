using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public abstract class superklasse
    {
        public virtual string Name { get; } = "oalf";
        private string vorname = "schutl";

        public virtual string Description { get; set; } = "Hallo";

        public virtual string Methode()
        {
            return $"Mein anem ist {Name}";
        }

        public abstract string methodeabstarct();
        public abstract void methodeabstarct1();


        public superklasse(int a, int result)
        {
            a = 5;
            result = a;
            Console.WriteLine($" {a} +  = {result}");
        }
    }
}
