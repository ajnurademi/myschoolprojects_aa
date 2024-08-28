using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    /*
        Autor: Ajnur Ademi
        Datum: 08.09.2023
        Version: 1.2
    */

    public class Wasserfass
    {
        private int minimalPegel;
        private int maximalPegel;
        private int fuellstand;
        private int kapiziteat;

        public Wasserfass(int minimalPegel, int maximalPegel, int kapititeat) 
        { 
            this.minimalPegel = minimalPegel;
            this.maximalPegel = maximalPegel;
            this.kapiziteat = kapititeat;
        }

        private int MinimalPegel
        {
            get
            {
                return minimalPegel;
            }
        }

        private int MaximalPegel
        {
            get
            {
                return maximalPegel;
            }
        }

        public int Fuellstand
        {
            get 
            { 
                return fuellstand; 
            }
        }

        public int Kapiziteat
        {
            get
            {
                return kapiziteat;
            }
        }

        public void Befuellen(int menge)
        {
            if (fuellstand + menge <= kapiziteat)
            {
                fuellstand += menge;
            }
            else
            {
                fuellstand = kapiziteat;
            }
        }

        public void Entnehmen(int menge)
        {
            if (fuellstand - menge >= minimalPegel)
            {
                fuellstand -= menge;
            }
            else
            {
                fuellstand = minimalPegel;
            }
        }

        public void Entleeren()
        {
            fuellstand = 0;
        }
    }
}
