using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    abstract class Shape: IShowable, IMovable
    {
        public abstract double Area();

        public abstract double Perimeter();

        public void Show()
        {
            Console.WriteLine("Figure");
        }

    }
}
