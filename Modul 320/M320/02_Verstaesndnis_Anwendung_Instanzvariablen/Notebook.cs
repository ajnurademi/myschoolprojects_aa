using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Verstaesndnis_Anwendung_Instanzvariablen
{
    public class Notebook
    {
        List<Festplatte> Festplatten = new List<Festplatte>();

        public Notebook(Festplatte festplatte) 
        { 
            Festplatten.Add(festplatte);
        }



        public void AddFestplatten(Festplatte festplatte)
        {
            if(Festplatten.Count <= 3)
            {
                Festplatten.Add(festplatte);
            }
            else
            {
                throw new Exception("sind schon 3 festplatten eindgebaut");
            }
        }

        public void RemoveFestplatte()
        {
            if(Festplatten.Count > 0)
            {
                Festplatten.RemoveAt(0);

            }
            else { throw new Exception("gibt keine festplatten mehr"); }
        }


    }
}
