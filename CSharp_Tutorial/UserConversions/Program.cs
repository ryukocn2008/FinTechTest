using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserConversions
{
    struct RomanNumeral
    {
        public RomanNumeral(int value)
        {
            this.value = value;
        }

        static public implicit operator RomanNumeral(int value)
        {
            return new RomanNumeral(value);
        }

        static public explicit operator int(RomanNumeral roman)
        {
            return roman.value;
        }

        static public implicit operator string(RomanNumeral roman)
        {
            return ("Conversion not yet implemented");
        }

        private int value;
    }

    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral numeral;
            numeral = 10;

            Console.WriteLine((int) numeral);

            Console.WriteLine(numeral);

            short s = (short)numeral;
            Console.WriteLine(s);
        }
    }
}
