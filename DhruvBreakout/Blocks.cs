using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DhruvBreakout
{


    class Blocks
    {
        int x;
        int y;
        int width;
        int height;
        Color color;

        public Rectangle Hitbox
        {
            get { return new Rectangle(x, y, width, height); }
        }

        public Blocks(int x, int y, int width, int height, Color color)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.color = color;
        }


    }
}
