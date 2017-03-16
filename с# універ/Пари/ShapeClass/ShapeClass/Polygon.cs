using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Polygon: Shape
    {
        protected int numbOfTops;
        protected Point[] arrOfTops;

        public Polygon(Point[] arrOfTops)
        {
            numbOfTops = arrOfTops.Length;
            this.arrOfTops = new Point[arrOfTops.Length];
            for (int i = 0; i < arrOfTops.Length; ++i)
                this.arrOfTops[i] = arrOfTops[i];         
        }

        protected int NumbOfTops
        {
            get
            {
                return numbOfTops;
            }
        }

        public override double Area()
        {
            double area = 0;
            for (int i = 0; i < numbOfTops; ++i)
            {
                int n = numbOfTops;
                area += arrOfTops[i].X* arrOfTops[(i + 1) % n].Y - arrOfTops[(i + 1) % n].X * arrOfTops[i].Y;
            }
            area = Math.Abs(area);
            area *= 0.5;
            return area;
        }

        public override double Perimeter()
        {
            int n = numbOfTops;
            double p = 0;
            for (int i = 0; i < n - 1; ++i)
                p += Math.Sqrt((arrOfTops[i].X - arrOfTops[i + 1].X) * (arrOfTops[i].X - arrOfTops[i + 1].X) + (arrOfTops[i].Y - arrOfTops[i + 1].Y) * (arrOfTops[i].Y - arrOfTops[i + 1].Y));
            p += Math.Sqrt((arrOfTops[0].X - arrOfTops[n - 1].X) * (arrOfTops[0].X - arrOfTops[n - 1].X) + (arrOfTops[0].Y - arrOfTops[n - 1].Y) * (arrOfTops[0].Y - arrOfTops[n - 1].Y));
            return p;
        }
    }
}
