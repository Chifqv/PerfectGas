using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerfectGas
{
    class Ball : PictureBox
    {
        protected double x, y;//public
        int radius;
        Random random = new Random();
        protected Form form;

        public Ball()
        {
            random = new Random();
            this.x = random.Next(400);
            this.y = random.Next(400);
            this.radius = 20;
            this.Load("images/red_ball.png");
            this.Width = 2 * radius;
            this.Height = 2 * radius;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Ball(int x, int y, Form form) : this()
        {
            this.x = x;
            this.y = y;
            this.form = form;
            this.form.Controls.Add(this);
            Show();
        }

        public void Show()
        {
            this.Top = (int)y - radius;
            this.Left = (int)x - radius;
        }
    }
}