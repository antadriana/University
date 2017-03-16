using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Figures_Inheritance
{
    class Square:Rectangle

    {
        public Square(double lenghts) : base(lenghts, lenghts) { }
        public override double Area()
        {
            return lengths*lengths ;
        }
        public override double Perimeter()
        {
            return 4 * lengths;
        }
        public override string ToString()
        {
            return "\nSQUARE:\nThe lenghs is: " + lengths + "\nThe width is: " + width + "\nPerimeter is: " + Perimeter() + "\nArea is :" + Area();
        }
    }
}
