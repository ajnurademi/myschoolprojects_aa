using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseSimulator
{
    public class Simulator
    {

        public void Run()
        {
            while (true)
            {
                Console.Write("Geben Sie eine URL ein. (e tippen um zu beenden) ");
                string url = Console.ReadLine();
                if (url == "e")
                {
                    break;
                }
                BrowseUrl(url);
            }


        }

        public void BrowseUrl(string url)
        {
            Console.WriteLine($"Lade... {url}");
        }
    }
}
