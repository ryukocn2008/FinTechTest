using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class Factorial
    {
        public static int Calc(int i)
        {
            return ((i <= 1) ? 1 : (i * Calc(i - 1)));
        }

    }

    public class DigitCount
    {
        public static int NumberOfDigits(string theString)
        {
            int count = 0;
            for(int i = 0; i < theString.Length; i++)
            { 
                if (Char.IsDigit(theString[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
