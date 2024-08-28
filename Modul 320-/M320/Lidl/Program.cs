namespace Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Person() { Vorname = "Max", Name = "Muster"}; // möchte man eigentlich nicht weil es sollte die klasse person (abstrakt) machen, weil man keine Istanz amcht als Person 
            Lagerist lagerist1 = new Lagerist(2, 3) { Vorname = "Nüller", Name = "irgenwer"};

            // Polymorphie =  Verwendung Objekte unterschiedlichen Datentyps annimmt. --> Geht wegen der Vererbung 
            Person person1 = lagerist1;

            // ein Kinde kann nicht erzeiugt werden von ^lagerist1, weil es nicht Vererbt ist
            // Kind kind2 = lagerist1; 


            var kunde1 = new Kunde(2, 3) { Name = "herbel", Umsatz = 1000 }; // Fehlermeldung weil man protected nicht im Pogramm benutzen kann, sondern nur in anderen Klassen
            var kind1 = new Kind(2, 3) { Vorname = "kleinkind", Name = "olaf", alter = 5};

            kunde1.Kaufe();
            kunde1.Esse();
            kunde1.Trage();
            lagerist1.LagerEin();
            lagerist1.Trage();
            lagerist1.Esse();

            kind1.Trage();
            kind1.Esse();

            // ALle objekte in der Liste personen hinzugefügt
            List<Person> personen = new List<Person>();
            personen.Add(lagerist1);
            personen.Add(kind1);
            personen.Add(kunde1);


            Console.WriteLine("\n\nMehtode Essen für alle Objekte in der Liste");
            // Jedes Objekt Methode Esse aufgerufen 
            foreach(var person in personen)
            {
                person.Esse();
                person.Trage();
                person.Atme();
            }

            var st = new List<Saugetier>();
            st.Add(lagerist1);
            st.Add(kunde1);
            st.Add(kind1);

            Console.WriteLine("\n\nPerson erbt von Säugetier");
            foreach ( var item in st)
            {
                item.Atme();
                //Checken ob es die Vererbung hat 
                if(item is Lagerist lagerist)
                {
                    lagerist1.LagerEin();
                    lagerist.LagerEin();
                }
            }



            Console.WriteLine(kunde1.Vorname);
        }
    }
}