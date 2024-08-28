using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StringCalculator.Tests
{
    public class StringCalculator
    {
        private int calledCount;

        public int CalledCount
        {
            get
            {
                return calledCount;
            }
        }

        public int Add(string numbers)
        {
            calledCount++;

            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char[] defaultDelimiters = { ',', '\n' };

            int indexOfNewLine = numbers.IndexOf('\n');
            char[] customDelimiters;

            if (indexOfNewLine == 1 && !char.IsDigit(numbers[0]))
            {
                //  Zeichen vor '\n' als benutzerdefinierte Delimiter konventieren
                customDelimiters = numbers.Substring(0, indexOfNewLine).ToCharArray();

                // '\n' überspringen.
                indexOfNewLine++;
            }
            else
            {
                customDelimiters = defaultDelimiters;

                //  kein '\n' 
                indexOfNewLine = 0;
            }

            // Standarddelimitern & benutzerdefinierten Delimiter zu einem einzigen Array.
            char[] allDelimiters = defaultDelimiters.Concat(customDelimiters).ToArray();

            // Spaltet die Zeichenkette ab dem Index nach '\n' mit den kombinierten Delimitern auf.
            string[] numberArray = numbers.Substring(indexOfNewLine).Split(allDelimiters);

            int sum = 0;
            List<int> negativeList = new List<int>();

            foreach (string number in numberArray)
            {
                int num = int.Parse(number);

                if (num < 0)
                {
                    negativeList.Add(num);
                }
                else if (num <= 1000)
                {
                    sum += num;
                }
            }

            if (negativeList.Count > 0)
            {
                // Alle Elemente mit (,) trennen
                throw new InvalidOperationException($"Negatives not allowed: {string.Join(", ", negativeList)}");
            }
            else
            {
                return sum;
            }
        }
    }
}
