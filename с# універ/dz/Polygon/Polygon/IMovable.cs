using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon
{
    interface IMovable
    {
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
    }
}
