using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyCollectionsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration Method 1
            int[] square1;
            square1 = new int[3];
            // Declaration Method 2
            int[] square2 = new int[3];
            // Declaration Method 3 
            Array square3 = Array.CreateInstance(typeof(int), 10);
            // Multiple dimensions
            int[,] square4 = new int[3,4];
            int[, ,] square5 = new int[1,2,3];


            // Initialize Method 1
            int[] square11 = { 3, 4, 5 , 4, 5};
            int[] square21 = new int[3] { 2, 4, 6};
            Array square31 = Array.CreateInstance(typeof(int), 10);
            int[,] square41 = {
                        {1, 2, 3, 4},
                        {11, 21, 31, 41},
                        {21, 32, 33, 34},
                        {14, 24, 34, 44},
                      };

            
            foreach(int square in square11) {
                Console.WriteLine(square);
            }

            // Array Methods

            // BinarySearch
            int result;
            result = Array.BinarySearch(square11, 4);
            Console.WriteLine(result);
            // IndexOf
            result = Array.IndexOf(square11, 5);
            Console.WriteLine(result);
            // LastIndexOf
            result = Array.LastIndexOf(square11, 5);
            Console.WriteLine(result);
            // Exists


            // Clear
            // ConvertAll
            // Copy 
            // Resize

            // Sort
            // Reverse

            ArrayList squareal1 = new ArrayList();


        }
    }
}
