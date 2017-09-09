using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DhruvBreakout
{
    
    class Paddle
    {
        int x;
        int y;
        int width;
        int height;
        int SpeedX;
        Color color;
        public Rectangle Hitbox
        {
            get { return new Rectangle(x, y, width, height); }
        }

        public Paddle(int x, int y, int width, int height, int SpeedX, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.SpeedX = SpeedX;
            this.color = color;
        }










    }
}
