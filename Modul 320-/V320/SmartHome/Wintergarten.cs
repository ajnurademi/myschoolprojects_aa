using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Wintergarten : Zimmer
    {
        public Wintergarten() : base("Wintergarten") 
        {
         
        }   
        public double Sonneneinstrahlung { get; set; }
    }
}
