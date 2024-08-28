using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class subklasse : superklasse
    {

        public override string Description { get; set; } = "wie gehts";

        public subklasse(int a,int b, int result) : base(a, result)
        {   
            a = 5;
            b = 5;
            result = a + b;
            Console.WriteLine($" {a} + {b} = {result}");
        }

        public override void methodeabstarct1()
        {
            Console.WriteLine(Name);
            return "";
        }


        public override string Methode()
        {
            return $"Mein name ist namenlos";
            
        }

        public override string methodeabstarct()
        {
            return "";
        }

    }
}
