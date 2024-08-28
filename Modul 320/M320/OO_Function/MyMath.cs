using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OO_Function
{
    public class MyMath
    {
        // ggT berechnen
        public static int Calc_ggT(int a, int b)    // int a = num1 | int b = num2
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // ggT rekursiv
        public static int Calc_ggT_r(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Calc_ggT_r(b, a % b);
        }

        // kgv berechnen
        public static int Calc_kgV(int a, int b)
        {
            int gcd = Calc_ggT(a, b);
            return (a * b) / gcd;
        }

        // fragt nach positive Zahl + einliest
        public static int ReadInt(string message)
        {
            int number;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);  // Solange die Eingabe nicht erfolgreich in eine GANZZAHL umgewandelt werden kann oder die Zahl negativ oder null ist,
                                                                                     // wird die Schleife fortgesetzt.
            return number;
        }

        // Zeigt das Resultat an
        public static void ShowResult(string operation, int a, int b, int result)
        {
            Console.WriteLine($"{operation} von {a} und {b} ist {result}");
        }

        // Array wird umgedreht
        public static void ReverseArray(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;    // das letzte Element des Arrays zeigt       array[0], array[1], array[2], array[3],....
            while (left < right)
            {
                int temp = numbers[left];  // left Position zu speichern
                numbers[left] = numbers[right];  // left" Position wird von right Position überschrieben
                numbers[right] = temp;  // right Position von temp (ursprünlgichen left-Element)
                left++;  // left Zeiger nach rechts verschoben 
                right--;  // right Zeiger nach links verschoben 
            }
        }

        // Array sortieren
        public static void SortArray(int[] numbers)
        {
            Array.Sort(numbers);
        }

        // arithmetischer Mittelwert
        public static double CalculateMean(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double sum = 0;
            foreach (int num in numbers)        // bei jedem Durchlauf enthält die Variable num den Wert des Arrays (array[0]=2) 
            {
                sum += num;
            }
            return sum / numbers.Length;       // Den Summand mit der Array grösse dividieren = Durchschnitt
        }

        // kleinster Wert
        public static int FindSmallest(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int smallest = numbers[0];
            foreach (int num in numbers)    //bei jedem Durchlauf enthält die Variable num den Wert des Arrays(array[0])
            {                               
                if (num < smallest)         // checkt ob die nummer kleiner ist das array[0]
                {
                    smallest = num;
                }
            }
            return smallest;
        }

        // groesster Wert
        public static int FindLargest(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int largest = numbers[0];
            foreach (int num in numbers)   //bei jedem Durchlauf enthält die Variable den Wert des Arrays(array[0])
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            return largest;
        }

        // 2 Variablen vertauscht
        public static void Swap(ref int a, ref int b)
        {
            int temp = 1;
            a = b;
            b = temp;
        }
    }
}
