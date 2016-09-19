using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Functions;

namespace FunctionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Function Client");

            if (args.Length == 0)
            {
                Console.WriteLine("Usage: FunctionTest...");
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                int num = Int32.Parse(args[i]);
                Console.WriteLine(
                        "The Digit Count for String [{0}] is [{1}]",
                        args[i],
                        DigitCount.NumberOfDigits(args[i])
                    );
                Console.WriteLine(
                        "The Factorial for [{0}] is [{1}]",
                        num,
                        Factorial.Calc(num)
                    );
            }
        }
    }
}
