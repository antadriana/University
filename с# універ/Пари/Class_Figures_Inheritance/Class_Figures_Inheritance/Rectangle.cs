using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Figures_Inheritance
{
    class Rectangle : Shape
    {
        protected double lengths;
        protected double width;
       

        protected double Lengths
        {
            get { return lengths; }
            set { lengths = value; }
        }
        protected double Width
        {
            get { return width; }
            set { width = value; }
        }
        public Rectangle(double lengths, double width)
        {
            this.lengths = lengths;
            this.width = width;
        }

        public override double Area()
        {
            return width * lengths;
        }
        public override double Perimeter()
        {
            return 2 * (lengths + width);
        }
        public override string ToString()
        {
            return "RECTANGLE:\nThe lenghs is: " + lengths + "\nThe width is: " + width+"\nPerimeter is: "+Perimeter()+"\nArea is :"+Area();
        }
      
       
    }
}