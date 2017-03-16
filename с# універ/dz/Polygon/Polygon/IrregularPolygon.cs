using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class IrregularPolygon : Polygon,IMovable
    {
        protected int nOfSides;
        protected float[,] coordinates;

        protected float[,] Coordinates
        {
            get
            { return coordinates; }
           set { coordinates = value;}
        }

        protected int NOfSides
        {
            get { return nOfSides; }
           set { nOfSides = value; }
        }

        public IrregularPolygon(int nOfSides, float[,] coordinates)
        {
            this.nOfSides = nOfSides;
             this.coordinates = coordinates;
          /*  for (int i=0; i<nOfSides; i++)
            {
                Console.WriteLine(coordinates[i,0]);
            }*/

            // Area();
        }
        public override double Area()
        {
            float lengthX = 0f;
            float lengthY = 0f;
            for (int i = 0; i <coordinates.GetLength(0)-1; i++)

            {
              //Console.Write(coordinates[i, 0]+" * "+ coordinates[i+1, 1]+" " );
                
               // Console.Write(coordinates[i, 1]+"*"+ coordinates[i + 1, 0]+" ");
               // Console.Write(coordinates[i+1, 0] + "k ");

                lengthX += (coordinates[i,0] * coordinates[ i + 1,1]);
                lengthY +=( coordinates[i, 1] * coordinates[ i + 1,0]);
            }
            lengthX += coordinates[0, 1] * coordinates[coordinates.GetLength(0)-1, 0];
            lengthY += coordinates[0, 0] * coordinates[coordinates.GetLength(0) - 1, 1];
           // Console.WriteLine("\nlengthX is :"+ lengthX);
           // Console.WriteLine("\nlengthY is :"+ lengthY);
            return Math.Abs((lengthY - lengthX) / 2);
        }
        public override double Perimeter()
        {
            double perimeter = 0;
            double [] lengthOfSide = new double [nOfSides+1];
            double [] coordX = new double[nOfSides];
            double[] coordY = new Double[nOfSides];
            for (int i = 0; i < coordinates.GetLength(0)-1 ; i++)
            {
                coordX[i] = (double)coordinates[i + 1, 0] -(double) coordinates[i, 0];
                coordY[i] = (double)coordinates[i + 1, 1] -(double) coordinates[i, 1];
              //  Console.Write(coordinates[i + 1, 0]+"-"+ coordinates[i, 0]+"="+ coordX[i]+  "  ");
            }
            coordX[nOfSides-1]=(double)coordinates[coordinates.GetLength(0)-1,0]- (double)coordinates[0, 0];
            coordY[nOfSides-1] = (double)coordinates[coordinates.GetLength(0)-1, 1] -(double) coordinates[0, 1];

             /*for (int i = 0; i < coordinates.GetLength(0) ; i++)
             {
                 Console.Write(coordX[i]+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                Console.Write(coordY[i]+" ");
            }*/
            for (int i = 0; i < nOfSides; i++)
            {
                lengthOfSide[i] = Math.Abs(Math.Sqrt(Math.Pow(coordX[i], 2) + Math.Pow(coordY[i], 2)));
            }
            for (int i = 0; i < nOfSides; i++)
            {
                perimeter += lengthOfSide[i];
            }

            return perimeter;
        }
        public override void  MoveUp()
        {
            for(int i=0;i<coordinates.GetLength(0); i++)
            {
                coordinates[i, 1]++;
            }
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {Console.Write(" {"+coordinates[i, 0] +" ");
                Console.Write(coordinates[i, 1]+"} " );
                
            }
        }
        public override void MoveDown() {
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                coordinates[i, 1]--;
            }
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                Console.Write(" {" + coordinates[i, 0] + " ");
                Console.Write(coordinates[i, 1] + "} ");

            }

        }
        public override void MoveLeft() {
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                coordinates[i, 0]--;
            }
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                Console.Write(" {" + coordinates[i, 0] + " ");
                Console.Write(coordinates[i, 1] + "} ");

            }
        }
        public override void MoveRight() {
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                coordinates[i, 0]++;
            }
            for (int i = 0; i < coordinates.GetLength(0); i++)
            {
                Console.Write(" {" + coordinates[i, 0] + " ");
                Console.Write(coordinates[i, 1] + "} ");

            }
        }


        public override string ToString()
        {
            return "\nNumber of sides : " + nOfSides + "\nArea of this Polygon: " + Area() + "\nPerimeter: " + Perimeter();

        }
    }
}
