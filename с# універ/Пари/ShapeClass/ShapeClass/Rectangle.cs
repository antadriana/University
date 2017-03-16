using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Rectangle : Shape
    {
        private Point pos = new Point(0,0);
        protected double width;
        protected double length;

        protected double Lenght
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        protected double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        protected Point Pos
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
            }
        }

        public override double Area() {
            return length * width;
        }
        public override double Perimeter() {
            return 2 * (length + width);
        }
        public override string ToString()
        {
            return "Length: " + length + " width: " + width;
        }

        public virtual void MoveUp()
        {
            pos.Y++;        
        }
        public virtual void MoveDown()
        {
            pos.Y--;
        }
        public virtual void MoveLeft()
        {
            pos.X--;
        }
        public virtual void MoveRight()
        {
            pos.X++;
        }

        public Rectangle (double length, double width){
            this.length = length;
            this.width = width;
        }
    }
}
