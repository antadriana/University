using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
           // RegularPolygon r1 = new RegularPolygon(3, 12);
           // Console.WriteLine(r1);


            float[,] coord = { { -3, -2 }, { -1, 4 }, { 6, 1 }, { 3, 10 }, { -4, 9 }  };
           // float [,] coord ={{-1,1},{1,1},{1,-1},{-1,-1}};
                IrregularPolygon ir1 = new IrregularPolygon(coord.Length/2, coord);
            Console.WriteLine(ir1);
            ir1.MoveLeft();
            ir1.MoveUp();
        }
    }
}
