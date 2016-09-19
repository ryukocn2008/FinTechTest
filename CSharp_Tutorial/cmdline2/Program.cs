using System;

namespace cmdline2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of command line parameter = {0}", args.Length);
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }
    }
}
