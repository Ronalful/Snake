using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Apple
    {
        public int coordX, coordY;
        public SolidBrush apple = new SolidBrush(Color.Red);
        public Random random = new Random();       

        public void Build(Graphics g)
        {
            g.FillRectangle(apple, coordX + 1, coordY + 1, 49, 49);
        }

        public void SetCoord(Snake[] s)
        {
            int x, y;
            bool check;

            while (true)
            {
                check = true;
                x = random.Next(0, 10) * 50;
                y = random.Next(0, 10) * 50;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].coordX == x && s[i].coordY == y)
                    {
                        check = false;
                        break;
                    }
                }

                if (check)
                    break;
            }

            coordX = x;
            coordY = y;
        }
    }
}
