using System;

namespace Auto_uebung
{
    public class Auto
    {
        Motor motor = new Motor();

        public void Anlassen()
        {
            Console.WriteLine("Auto anlassen");
            motor.Starten();
        }
    }
}
