using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClasses2
{


    public class Tokens : IEnumerable
    {
        private string[] elements;

        public Tokens(string source, char[] delimiters)
        {
            elements = source.Split(delimiters);
        }

        public IEnumerator GetEnumerator()
        {
            return new TokenEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)new TokenEnumerator(this);
        }

        public class TokenEnumerator : IEnumerator
        {
            private int position = -1;
            private Tokens t;

            public TokenEnumerator(Tokens t)
            {
                this.t = t;
            }

            public object Current
            {
                get
                {
                    return t.elements[position];
                }
            }

            public bool MoveNext()
            {
                if (position < t.elements.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tokens f = new Tokens("This is a well-done program.", new char[] { ' ', '-' });
            foreach (string item in f)
            {
                Console.WriteLine(item);
            }

        }
    }
}
