using System;

namespace Calculator
{
    /*
    Autor: Ajnur Ademi
    Datum: 02.09.23
    Version: 1.3
    */

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Willkommen zum Calculator");
            Console.WriteLine("-------------------------");

            Methods Methods = new Methods();
            Methods.LastResult = 0;
            int choice = 0;

            while (true)
            {               
                if (Methods.LastResult == 0)
                {
                    Methods.Menu();
                    choice = int.Parse(Console.ReadLine()); // Eingabe in Integer umgewandelt

                    // Programm wird beendet
                    if (choice == 5)
                    {
                        Console.WriteLine("Das Programm wird beendet ...");
                        break;

                    }

                    // Eingabe 2 Rechenzahlen
                    Console.WriteLine("\nGeben Sie mir die 1. Zahl ein");
                    int number1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Geben Sie mir die 2. Zahl ein");
                    int number2 = int.Parse(Console.ReadLine());

                    int result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = Methods.Addition(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 2:
                            result = Methods.Subtraktion(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 3:
                            result = Methods.Multiplikation(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 4:
                            result = Methods.GanzZahlDivision(number1, number2);
                            Console.WriteLine($"\nErgebnis: {result}\n");
                            break;

                        case 5:
                            break;

                        default:
                            Console.WriteLine("\nUngültige Auswahl.");
                            continue;
                    }

                    Methods.LastResult = result;
                }
                if (Methods.LastResult != 0)
                {
                    // Frage
                    Console.WriteLine($"\nMöchtest du mit dem letzten Resulatat weiterrechnen ({Methods.LastResult}) ? [1=ja] [2=nein]");
                    int janein = int.Parse(Console.ReadLine());

                    if (janein == 1)
                    {
                        Methods.Menu();
                        choice = int.Parse(Console.ReadLine()); // Eingabe in Integer umgewandelt

                        // Eingabe 1 Rechenzahl
                        Console.WriteLine("\nGeben Sie mir die 2. Zahl ein");
                        int number2 = int.Parse(Console.ReadLine());

                        int result = 0;

                        switch (choice)
                        {
                            case 1:
                                result = Methods.Addition(Methods.LastResult, number2);
                                Console.WriteLine($"\nErgebnis: {result}\n");
                                break;

                            case 2:
                                result = Methods.Subtraktion(Methods.LastResult, number2);
                                Console.WriteLine($"\nErgebnis: {result}\n");
                                break;

                            case 3:
                                result = Methods.Multiplikation(Methods.LastResult, number2);
                                Console.WriteLine($"\nErgebnis: {result}\n");
                                break;

                            case 4:
                                result = Methods.GanzZahlDivision(Methods.LastResult, number2);
                                Console.WriteLine($"\nErgebnis: {result}\n");
                                break;

                            case 5:
                                break;

                            default:
                                Console.WriteLine("\nUngültige Auswahl.");
                                continue;
                        }
                        Methods.LastResult = result;
                    }
                    else
                    {
                        Console.WriteLine("Drücke Enter");
                        Console.ReadKey();
                        Console.Clear();    
                        Main();             // Enter drücken um wieder zur Main Methode zu kommen
                    }
                }
            }
        }
    }
}