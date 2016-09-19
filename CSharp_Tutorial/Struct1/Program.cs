using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct1
{
    struct SimpleStruct
    {
        private int xval;
        public int X
        {
            get { return xval; }
            set { if (value < 100) xval = value; }
        }

        public void DisplayX()
        {
            Console.WriteLine("The stored value is: {0}", xval);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            SimpleStruct ss = new SimpleStruct();
            ss.X = 5;
            ss.DisplayX();
        }
    }
}
