/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class RegularPolygon:Polygon
    {
        private float side;
        protected int nOfSides;

        protected float Side
        {
            get { return side; }
            set  {side = value;}
         }



        protected int NOfSides
        {
            get { return nOfSides; }
            set { nOfSides = value; }
        }

        public RegularPolygon(float side, int nOfSides)
        {
            this.side = side;
            this.nOfSides = nOfSides;
        }


       public override double Area()
        {
            return (nOfSides * (Math.Pow(side, 2))) / (4* (Math.Tan( (180 / nOfSides)*(Math.PI/180))));
        }
        public override double Perimeter()
        {
            float counter = 0f;
            return (counter+=side)*nOfSides ;
        }

        public override string ToString()
        {
            return "\nLengths of a side : " + side + "\nNumber of sides: " + nOfSides + "\nArea of this Polygon: " + Area()+"\nPerimeter: "+Perimeter();
        }
        
    }
}
*/