﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Hund
    {
        List<Laus> leuse = new List<Laus>();

        public void AddLAus(Laus laus)
        {
            leuse.Add(laus);
        }
        
    }
}
