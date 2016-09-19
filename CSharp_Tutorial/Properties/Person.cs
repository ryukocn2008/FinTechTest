using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {
        private string myName = "N/A";
        private int myAge = 0;

        public string Name
        {
            get { return myName; }
            set { myName = value; }
        }

        public int Age
        {
            get { return myAge; }
            set { myAge = value; }
        }

        public override string ToString()
        {
            return "Name = " + Name + ", Age = " + Age;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Properties");

            Person person = new Person();
            Console.WriteLine("Person details - {0}", person);

            person.Name = "Joe";
            person.Age = 99;
            Console.WriteLine("Person details - {0}", person);

            person.Age += 1;
            Console.WriteLine("Person details - {0}", person);

        }

    }
}
