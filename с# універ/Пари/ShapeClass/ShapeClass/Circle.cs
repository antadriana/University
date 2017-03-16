using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Circle:Shape
    {
        protected double radius;
        protected Point center;
        public override double Area() {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimeter() {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return "Radius: " + radius;
        }
        public Circle(double radius, Point center) {
            this.radius = radius;
            this.center = center;   
        }
    }
}
