using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array Declaration
            int[] numbers = new int[5];
            string[,] names = new string[5, 4];

            // jagged array
            byte[][] scores = new byte[5][];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            for (int i = 0; i< scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }

            // Array Declaration
            int[,,] buttons = new int[4, 5, 3];
            int[][,,][,] numbers2 = new int[3][,,][,];

            // Array Initializaing
            numbers = new int[5] { 1, 2, 3, 4, 5 };
            string[][] names2 = new string[3][] { new string[]{ "Mart" }, new string[] { "Joanne" }, new string[] { "Robert" } };

            Console.WriteLine(names2.Length);

             


        }
    }
}
