using System;

namespace Auto_uebung
{
    public class Motor
    {
        Benzinpumpe benzinpumpe = new Benzinpumpe();
        Anlasser anlasser = new Anlasser();

        public void Starten()
        {
            Console.WriteLine("Motor starten");
            benzinpumpe.Pumpen();
            anlasser.Starten();
            Regeln();
        }

        private void Regeln()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Motor regeln");
            }
            anlasser.Stoppen();
        }
    }
}
