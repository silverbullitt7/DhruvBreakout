using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DhruvBreakout
{
    public partial class Form1 : Form
    {
        Color color;
        Bitmap bitmap;
        Graphics gfx;
        Paddle paddle;
        Ball ball;
        int playerscore = 0;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            gfx = Graphics.FromImage(bitmap);
            ball = new Ball(100, 100, 100, 100, 20, 20, color);
            paddle = new Paddle(0, 150, 40, 280, 0, color);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
