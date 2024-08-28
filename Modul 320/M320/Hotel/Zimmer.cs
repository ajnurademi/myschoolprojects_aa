using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Zimmer
    {
        public int nummer;
        List<Bett> better = new List<Bett>();

        public Zimmer()
        {
            better.Add(new Bett());
        }

        public void AddBett()
        {
            if(better.Count > 0)
            {
                better.Add(new Bett());
            }
            else
            {
                Console.WriteLine("Es gibt schon 2 Better");
            }
        }
    }
}
