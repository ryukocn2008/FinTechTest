using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class abstractshape
    {

    }

    public abstract class Shape
    {
        private string myId;

        public Shape(string s)
        {
            Id = s;
        }

        public string Id
        {
            get { return myId; }
            set { myId = value; }
        }

        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }


}
