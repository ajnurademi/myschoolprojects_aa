using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalculator
{
    public class FactorialCalculator
    {
        // Unsigend (u) | Long erweiterung von int (long)
        public ulong Calculate(ulong number)
        {
            if (number < 2) 
            {
                return 1; 
            }
            
            else
            {
                return number * Calculate(number-1);
            }
        }
    
    
    
    
    }
}
