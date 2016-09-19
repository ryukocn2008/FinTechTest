using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct2
{
    class TheClass
    {
        public int x;
    }

    struct TheStruct
    {
        public int x;
    }
    class Program
    {
        public static void structtaker(TheStruct c)
        {
            c.x = 5;
        }

        public static void classtaker(TheClass s)
        {
            s.x = 5;
        }
        static void Main(string[] args)
        {
            TheStruct a = new TheStruct();
            TheClass b = new TheClass();
            a.x = 1; 
            b.x = 1; 
            structtaker(a); // because it was passed by value, so the out value doesn't change
            classtaker(b);  // because it was passed by reference, so the value was changed inside the function.
            Console.WriteLine("a.x = {0}", a.x);
            Console.WriteLine("b.x = {0}", b.x);

        }
    }
}
