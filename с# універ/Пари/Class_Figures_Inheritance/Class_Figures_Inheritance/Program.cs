using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Figures_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 4);
            Console.WriteLine(rectangle);

            Square square = new Square(4.5);
           Console.WriteLine(square);

            Point point = new Point(1, 4);
            Circle circle = new Circle(5.3, point);
            Console.WriteLine(circle);


            Shape[] array = new Shape[3] { rectangle, square, circle };
            Shop shop = new Shop(array);
            Console.WriteLine("\nTotal area of all Figures in Shop is : "+shop.AreaOfAll());

            Console.WriteLine("\nTotal perimeter of all Figures in Shop is : " + shop.PerimeterOfAll()+"\n");
            shop.Count();
           
        }
    }
}
