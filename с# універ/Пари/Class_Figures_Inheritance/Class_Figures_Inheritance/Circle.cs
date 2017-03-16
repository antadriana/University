using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Figures_Inheritance
{
    class Circle:Shape
    {
        private double radius;
        private Point center;


        public Circle(double radius,Point center)
        {
            this.radius = radius;
            this.center = center;
        }
        protected double Radius
        {
            get { return radius;}
            set {radius = value; }
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius; }
        public override string ToString()
        {
            return "\nCIRCLE:\nRadius is :" + radius +"\nCeneter is: "+center+"\nArea is: " + Area() + "\nPerimeter is: " + Perimeter();
        }



    }
}
