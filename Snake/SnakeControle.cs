using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class SnakeControle
    {

        public SolidBrush body = new SolidBrush(Color.Green);
        public SolidBrush head = new SolidBrush(Color.LightGreen);
        public Apple myApple;

        public SnakeControle(Apple apple)
        {
            myApple = apple;
        }

        public void BuildSnake(Graphics g, Snake[] s)
        {
            g.FillRectangle(head, s[0].coordX + 1, s[0].coordY + 1, 49, 49);
            for (int i = 1; i < s.Length; i++)
            {
                g.FillRectangle(body, s[i].coordX + 1, s[i].coordY + 1, 49, 49);
            }
        }       

        public void Move(ref Snake[] s, int turn)
        {
            s[0].prevCoordX = s[0].coordX;
            s[0].prevCoordY = s[0].coordY;
            switch (turn)
            {
                case 1:
                    s[0].coordY -= 50;
                    break;
                case 2:
                    s[0].coordX -= 50;
                    break;
                case 3:
                    s[0].coordY += 50;
                    break;
                case 4:
                    s[0].coordX += 50;
                    break;
            }
            
            if ((s[0].coordX == s[1].coordX) && (s[0].coordY == s[1].coordY))
            {
                switch (turn)
                {
                    case 1:
                        s[0].coordY = s[0].prevCoordY + 50;
                        break;
                    case 2:
                        s[0].coordX = s[0].prevCoordX + 50;
                        break;
                    case 3:
                        s[0].coordY = s[0].prevCoordY - 50;
                        break;
                    case 4:
                        s[0].coordX = s[0].prevCoordX - 50;
                        break;
                }
            }
            

            for (int i = 1; i < s.Length; i++)
            {
                s[i].prevCoordX = s[i].coordX;
                s[i].prevCoordY = s[i].coordY;
                s[i].coordX = s[i-1].prevCoordX;
                s[i].coordY = s[i-1].prevCoordY;
            }            
                
        }

        public bool Eat(Snake[] s)
        {
            if (myApple.coordX == s[0].coordX && myApple.coordY == s[0].coordY)
                return true;
            else
                return false;
            
        }

        public bool MoveControle(Snake[] s, int turn)
        {
            int nextX = s[0].coordX, nextY = s[0].coordY;
            switch (turn)
            {
                case 1:
                    nextY -= 50;
                    break;
                case 2:
                    nextX -= 50;
                    break;
                case 3:
                    nextY += 50;
                    break;
                case 4:
                    nextX += 50;
                    break;
            }

            if ((nextX == s[1].coordX) && (nextY == s[1].coordY))
            {
                switch (turn)
                {
                    case 1:
                        nextY = s[0].coordY + 50;
                        break;
                    case 2:
                        nextX = s[0].coordX + 50;
                        break;
                    case 3:
                        nextY = s[0].coordY - 50;
                        break;
                    case 4:
                        nextX = s[0].coordX - 50;
                        break;
                }
            }

            if (nextX < 0 || nextX >= 500 || nextY < 0 || nextY >= 500)
                return true;
            for (int i = 2; i < s.Length - 1; i++)
            {
                if (nextX == s[i].coordX && nextY == s[i].coordY)
                    return true;
            }

            return false;
        }

        public void Grow(ref Snake[] s)
        {
            Array.Resize(ref s, s.Length + 1);
            s[s.Length - 1] = new Snake(s[s.Length - 2].prevCoordX, s[s.Length - 2].prevCoordY);       
        }

       
    }
}
