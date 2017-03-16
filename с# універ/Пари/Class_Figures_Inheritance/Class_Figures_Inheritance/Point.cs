using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Figures_Inheritance
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value;}
         }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "X="+x+" Y=" + y;
        }

       
    }
}
