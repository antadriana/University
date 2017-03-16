using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Square: Rectangle
    {
        public override double Area()
        {
            return length * width;
        }
        public override double Perimeter()
        {
            return 4*length;
        }
        public override string ToString()
        {
            return "Length: " + length + " width: " + width;
        }
        public Square(double length): base(length, length)
        {
        }
    }
}
