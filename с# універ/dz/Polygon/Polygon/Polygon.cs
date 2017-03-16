using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
   abstract class Polygon:IMovable
    {
       

        public abstract double Area();
        public abstract double Perimeter();
        public abstract void MoveUp();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();

    }
}
