using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Triangle
    {
        // Attribut
        public string Name { get; set; }
        public Color Color { get; private set; }

        /* read-only 
        public Color Color
        {
            get
            {
                return this.color;
            }
        }*/

        // array
        protected int[] Points { get; private set; }

        /*array --> read only
        public int[] Points
        {
            get
            {
                return this.points;
            }
        }*/

        private Point Center { get; set; }


        public int calcCircumference()
        {
            return 0;
        }

    }
}
