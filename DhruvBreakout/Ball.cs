using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhruvBreakout
{
     
    class Ball
    {
        int x;
        int y;
        int width;
        int height;
        int speedX;
        int speedY;
        Color color;

        public Ball(int x, int y, int width, int height, int speedX, int speedY, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.speedX = speedX;
            this.speedY = speedY;
            this.color = color;
        }








    }
}
