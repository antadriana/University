using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Figures_Inheritance
{
    class Shop
    {
        private Shape[] obj;

        public Shop(Shape [] obj)
        {
            this.obj = new Shape[obj.Length];
            for (int i=0; i<obj.Length; i++)
            {
                this.obj[i] = obj[i];
            }

        }

        public double AreaOfAll()
        { double sum = 0.0;
            for (int i=0; i<obj.Length; i++)
            {
                sum += obj[i].Area();
            }
            return sum;
        }
       public double PerimeterOfAll()
        {
            double sum = 0.0;
            for(int i=0; i<obj.Length; i++)
            {
                sum += obj[i].Perimeter();
            }
            return sum;
        }
        public void Count()
        {
            int numb1 = 0;
           // Rectangle k;
            for(int i=0; i<obj.Length; i++)
            {
                if (obj[i] == (Rectangle)obj[i]) { numb1++; Console.WriteLine(numb1 + " numb"); }
                else Console.WriteLine("hjk");
            }
            
        }

    }
}
