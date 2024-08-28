using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseSimulator
{
    public class StringStack
    {
        string[] stringUrls;
        int index { get; set; }

        public StringStack()
        {
            stringUrls = new string[10];
        }

        public string Push(string value)
        {
            if (IsFull)
            {
                Console.WriteLine("Fehler: Stack ist voll.");
                return null;
            }

            return stringUrls[index++] = value;
        }

        public string Pop()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Fehler: Stack ist leer.");
                return null;
            }

            return stringUrls[--index];
        }

        public string Peak()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Fehler: Stack ist leer.");
                return null;
            }

            return stringUrls[index - 1];
        }

        public void Clear()
        {
            Array.Clear(stringUrls, 0, stringUrls.Length);
            index = 0;
        }

        public bool IsEmpty
        {
            get { return index == 0; }
        }

        public int Count
        {
            get { return index; }
        }

        public bool IsFull
        {
            get { return index == stringUrls.Length; }
        }
    }
}
