using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    internal class Shape
    {
        private float length;
        private float width;

        public float Length
        {
            set
            {
                if (value>0)length = value;
            }
            get { return length; }
        }

        public float Width
        {
            set
            {
                if (value > 0) width = value;
            }
            get { return width; }
        }
        public Shape(float length, float width)
        {
            Length = length;
            Width = width;
        }

        public string Check()
        {
            if (width == length) return "square";
            else return "rectangle";
        }

        public static Shape operator +(Shape x, Shape y)
        {
            return new Shape((x.Length)+(y.length),(x.Width)+(y.Width));
        }
    }
}
