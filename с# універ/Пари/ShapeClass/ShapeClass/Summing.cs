using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Shop
    {
        protected Shape[] arr;
        public Shop(Shape []arr)
        {
            this.arr = new Shape[arr.Length];
            for(int i=0; i<arr.Length; ++i)
            {
                this.arr[i] = arr[i];
            }
        }
        public double totalArea()
        {
            double count = 0;
            foreach (Shape a in arr)
            {
                count += a.Area();            
            }
            return count;
        }

        public void ShowArr()
        {
            foreach (Shape a in arr)
            {
                a.Show();
            }
        }
}
}
