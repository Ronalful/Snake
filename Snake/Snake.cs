using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake
    {
        public int coordX, coordY;
        public int prevCoordX, prevCoordY;
        public Snake(int x, int y)
        {
            coordX = x;
            coordY = y;
        }

    }
}
