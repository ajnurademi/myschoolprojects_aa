
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    internal class Rectangle
    {
        // Property mit Zugriffsmodifizierer
        // read-write
        

        // Static wird für alle Objekte geändert und haben den gleichen Wert !!!
        
        private int width { get; set; }
        private int height { get; set; }
        private double widthd { get; set; }
        private double heightd { get; set; }
        private int corners { get; }
        private Color color { get; set; }


        /*
        // ohne Wert ändern | read only 
        public int Area
        {
            get
            {
                return this.width * this.height;
            }
        }

        public int Area2 => this.width * this.height;

        // stadart Wert
        private string name = "Rechteck";

        // read-write 
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        // write-only 
        public Color Color
        {
            set
            {
               this.Color = value;
            }
        }*/

        // Konstruktoren
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        // Kontruktor Verkettung
        public Rectangle(int width, int heigth, Color lineColor) : this(width, heigth)
        {
            this.color = lineColor;
        } 

        public Rectangle(int width, int heigth, Color lineColor, int corners) : this(width, heigth, lineColor)
        {
            this.corners = corners;
        }

        public Rectangle(double width, double height)
        {
            this.widthd = width;
            this.heightd = height;
        }
         


        // ÜBUNG 1


    }
}
