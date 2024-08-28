using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrische_Figuren
{
    public abstract class Figuren
    {
        public string Name { get; set; }
        public float PostitionX { get; set; } = 100;
        public float PostitionY { get; set;} = 100;

        public virtual void PrintPosition()
        {
            Console.WriteLine($"Name: {Name} ---> PositonX = {PostitionX} | PositionY = {PostitionY}");
        }

        public abstract void PrintArea();
        public abstract void PrintUmfang();
    }
}
