using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5,6);
            Console.WriteLine(rectangle1);
            rectangle1.MoveLeft();
            Console.WriteLine(rectangle1);
            /*Square square1 = new Square(9);
            Point point1 = new Point(1, 0);
            Circle circle1 = new Circle(8, point1);
            Console.WriteLine(rectangle1);
            Console.WriteLine(square1);
            Console.WriteLine(circle1);

            Shape[] arr = new Shape[3] { rectangle1, square1, circle1 };
            Shop sum = new Shop(arr);

            Console.WriteLine(sum.totalArea());
            /*Point[] topsArr1 = new Point[]{ new Point(1, 1), new Point(2, 2), new Point(2, 4) };
            Polygon pol1 = new Polygon(topsArr1);
            Point[] topsArr2 = new Point[] { new Point(3, 1), new Point(7, 2), new Point(9, 5) };
            Polygon pol2 = new Polygon(topsArr2);
            Point[] topsArr3 = new Point[] { new Point(1, 9), new Point(2, 12), new Point(2, 1) };
            Polygon pol3 = new Polygon(topsArr3);
            Polygon[] polygonsArr = new Polygon[] { pol1, pol2, pol3 };

            for (int i = 0; i < polygonsArr.Length; ++i)
            {
                Console.Write(polygonsArr[i].Area() + "  ");
                Console.Write(polygonsArr[i].Perimeter());
                Console.WriteLine();
            }
            sum.ShowArr();*/

        }   
                
    }
}


// sum (Shape[])
// sum (params Shape) подивитися і подумати
// написати клас многокутник, насл від фігура, створити масив полігонів(многокутників) різної розмірності
// абстрактний клас, інтерфейс




 //реалізувати інтерфейс countable,  який буде рахувати кількість створених фігур(статичний метод)
 //і ще, щоб рахувало різні типи окремо
 //клас колекція(повернення номеру фігури)
 //реалізовуємо інтер айнумерайбл, який має номер кріейт намбер, той номер привязаний до моменту створення обєкта
 //здійснити рух для многокутників
 //робота з текстовою інформацією