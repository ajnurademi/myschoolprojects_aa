namespace Auto_uebung
{
    public class Program
    {
        /*
            Autor: Ajnur Ademi
            Datum: 12.02.2024
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie 'start' ein, um das Auto zu starten:");
            Console.WriteLine("----------------------------------------------");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "start")
            {
                Auto auto = new Auto();
                auto.Anlassen();
            }
            else
            {
                Console.WriteLine("Das Auto wird nicht gestartet / Ungültige Eingabe!");
            }
        }
    }
}

