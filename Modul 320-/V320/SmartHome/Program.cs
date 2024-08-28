namespace SmartHome
{
    public class Program
    {
        static void Main(string[] args)
        {
            var wettersensor = new Wettersensor();
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("BadWC", 24.5);
            wohnung.SetTemperaturvorgabe("Kueche", 22.5);
            wohnung.SetTemperaturvorgabe("Schlafzimmer", 23.00);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 23.5);
            wohnung.SetTemperaturvorgabe("Wintergarten", 18.00);

            wohnung.SetPersonenImZimmer("BadWC", false);
            wohnung.SetPersonenImZimmer("Kueche", false);
            wohnung.SetPersonenImZimmer("Schlafzimmer", true);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);
            wohnung.SetPersonenImZimmer("Wintergarten", false);


            int ZeitInMin = 60;

            for (var i = 0; i< ZeitInMin; i++) {
                wohnung.GenerateWetterdaten();
            }

        }
    }
}
