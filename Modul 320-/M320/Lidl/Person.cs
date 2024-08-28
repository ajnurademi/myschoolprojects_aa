using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lidl
{
    public abstract class Person : Saugetier
    {
        public string Name { get; set; }
        public string Vorname { get; set;} 
        protected int Id { get; set; }

        public Person(int a)
        {
            Console.WriteLine(a);
            Console.WriteLine("print ddddPERSONconstrukctor");
        }

        public virtual void Esse()
        {
            Console.WriteLine($"Person: { Vorname } { Name } {Id} isst mit Messer und Gabel");
        }

        //public virtual void Trage() // virtuel kanne eine Implementierung haben 
        //{
        //    Console.WriteLine($"Person {Vorname} {Name} trägt mit ...");
        //}

        public abstract void Trage(); // abstrakte methode können nur in einer abstrakten Klass sein und haben keine iMpelmentierung
    
        public override void Atme()
        {
            Console.WriteLine($"person: {Vorname} atmet");
        }
    
    
    }
}
