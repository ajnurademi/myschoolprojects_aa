using System;
using System.Security.Cryptography.X509Certificates;

namespace R6Operators
{
    class Program
    {
        static void Main() 
        {
            // Kleines Programm von einem Spiel namens Rainbow six Siege || Mehr dazu --> https://www.ubisoft.com/en-gb/game/rainbow-six/siege/game-info/operators
            // Made by Ajnur
            // 10.01.2023



            // Array zu  den ANGREIFER

            spielfigur[] angreifer = new spielfigur[3];
            angreifer[0] = new spielfigur("[Angreifer]", "ASH", "Weiblich ", "BREACHING ROUNDS");
            angreifer[1] = new spielfigur("[Angreifer]", "SLEDGE", "Männlich", "TACTICAL BREACHING HAMMER");
            angreifer[2] = new spielfigur("[Angreifer]", "BANDIT", "MÄNNLICH", "SHOCK WIRE");

            //Array zu den VERTEIDIGER

            spielfigur[] verteidiger = new spielfigur[3];
            verteidiger[0] = new spielfigur("[Verteidiger]", "CEVAIRE", "Weiblich", "SILENT STEP");
            verteidiger[1] = new spielfigur("[Verteidiger]", "ZOFIA", "Weiblich", "KS79 LIFELINE");
            verteidiger[2] = new spielfigur("[Verteidiger]", "TWITCH", "Weiblich", "SHOCK DRONES");



            // Eingabe des Operators

            Console.WriteLine("Für welche Seite kämpfst du? [Angreifer oder Verteidiger]\n");
            string angreiferoderverteidiger = Console.ReadLine();



            // Verarbeitung des ausgwählten Operators

            if (angreiferoderverteidiger == "Angreifer")
            {
                Console.WriteLine("\nEntscheide dich zwischen diesen 3 Operatoern ! (Geben Sie den Namen ein GROSS) \n");
                Console.WriteLine("    ANGREIFER |  NAME | GESCHLECHT | SUPERKRAFT                  ");
                Console.WriteLine("---------------------------------------------------------------\n");
                Console.WriteLine("|  [Angreifer]  ASH     Weiblich   BREACHING ROUNDS           |\n");
                Console.WriteLine("|  [Angreifer]  SLEDGE  Männlich   TACTICAL BREACHING HAMMER  |\n");
                Console.WriteLine("|  [Angreifer]  BANDIT  MÄNNLICH   SHOCK WIRE                 |\n");
                Console.WriteLine("-------------------------------------------------------------- \n");

            }


            if (angreiferoderverteidiger == "Verteidiger")
            {
                Console.WriteLine("\nEntscheide dich zwischen diesen 3 Operatoern ! (Geben Sie den Namen ein GROSS) \n");
                Console.WriteLine("    verteidiger  |  NAME |   GESCHLECHT | SUPERKRAFT       ");
                Console.WriteLine("---------------------------------------------------------\n");
                Console.WriteLine("|  [Verteidiger]   CEVAIRE    Weiblich   SILENT STEP    |\n");
                Console.WriteLine("|  [Verteidiger]   ZOFIA      Weiblich   KS79 LIFELINE  |\n");
                Console.WriteLine("|  [Verteidiger]   TWITCH     Weiblich   SHOCK DRONES   |\n");
                Console.WriteLine("---------------------------------------------------------\n");
            }

            string operatorauswahl = Console.ReadLine();


            foreach (spielfigur mais in angreifer)
            {
                if(mais.name.Contains(operatorauswahl))
                {
                    Console.WriteLine("\nIhr Operator wurde ausgewählt \n\n| Kämpfe um zu GEWINNEN¨!!! | \n");
                    Console.WriteLine("\n\nFolgender Operator wurde ausgewählt: \n");
                    Console.WriteLine(mais.anOderve);
                    Console.WriteLine(mais.name);
                    Console.WriteLine(mais.geschlecht);
                    Console.WriteLine(mais.superkraft);
                    
                }
            }

            foreach (spielfigur mais in verteidiger)
            {
                if (mais.name.Contains(operatorauswahl))
                {
                    Console.WriteLine("\nIhr Operator wurde ausgewählt \n\n| Kämpfe um zu GEWINNEN¨!!! | \n");
                    Console.WriteLine("\n\nFolgender Operator wurde ausgewählt: \n");
                    Console.WriteLine(mais.anOderve);
                    Console.WriteLine(mais.name);
                    Console.WriteLine(mais.geschlecht);
                    Console.WriteLine(mais.superkraft);
                    
                }
            }


            // Methode aufrufen

            spielfigur peter = new spielfigur("", "", "", "");
            peter.kaufen();


            // Alles wieder von vorne

            Console.ReadKey();
            Console.Clear();
            Main();


        }


    }

}
