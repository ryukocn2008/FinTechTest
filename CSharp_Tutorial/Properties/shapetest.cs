using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class TestClass
    {
        public static void Main()
        {
            Shape[] shapes =
                {
                    new Square(5, "Square #1"),
                    new Circle(3, "Circle #1"),
                    new Rectangle(4, 5, "Rentangle #1")
                };

            Console.WriteLine("Shape Collection");
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            
            }
        }
    }
}
