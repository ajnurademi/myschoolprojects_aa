namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zimmer zimmer1 = new Zimmer();
            Zimmer zimmer2 = new Zimmer();
            Zimmer zimmer3 = new Zimmer();
            Zimmer zimmer4 = new Zimmer();
            Zimmer zimmer5 = new Zimmer();
            Zimmer zimmer6 = new Zimmer();
            Zimmer zimmer7 = new Zimmer();
            Zimmer zimmer8 = new Zimmer();
            Zimmer zimmer9 = new Zimmer();
            Zimmer zimmer10 = new Zimmer();
            Zimmer zimmer11 = new Zimmer();

            Hotel hotelFrankenstein = new Hotel(zimmer1);

            hotelFrankenstein.AddZimmer(zimmer2);
            hotelFrankenstein.AddZimmer(zimmer3);
            hotelFrankenstein.AddZimmer(zimmer4);
            hotelFrankenstein.AddZimmer(zimmer5);
            hotelFrankenstein.AddZimmer(zimmer6);
            hotelFrankenstein.AddZimmer(zimmer7);
            hotelFrankenstein.AddZimmer(zimmer8);
            hotelFrankenstein.AddZimmer(zimmer9);
            hotelFrankenstein.AddZimmer(zimmer10);
            hotelFrankenstein.AddZimmer(zimmer11);

            Sitzungszimmer sitzungszimmer1 = new Sitzungszimmer();

            hotelFrankenstein.AddSitzungszimmer(sitzungszimmer1);

            Reception reception = new Reception();




        }
    }
}