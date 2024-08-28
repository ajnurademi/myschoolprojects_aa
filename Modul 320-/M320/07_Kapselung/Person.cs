using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Kapselung
{
    public class Person
    {
        // Istanzvariablen (1-2)
        private bool wuetend;
        private string name;

        public bool isAngry(bool wuetend)
        {
            if(wuetend == true ) {
                Console.WriteLine("Achtung du bist Wütend.");
            }

            return true;
        }



    }
}
