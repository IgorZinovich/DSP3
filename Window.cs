using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
          
        }
        void draw(PointF[] points, ref PictureBox box, Color c)
        {
            int N = points.Length;
            PointF[] p;
            p = new PointF[2 * N + 3];
            points.CopyTo(p, 0);
            for (int i = N; i < 2 * N + 3; i++)
            {
                p[i].X = p[1].X + p[i - 1].X;
                p[i].Y = p[i % N].Y;
            }
            Graphics g = box.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 1.0F);
            float y = 75;
            float x = 20;
            g.DrawLine(pen1, 0, y, 200, y);
            g.DrawLine(pen1, x - 20, 0, x - 20, 150);

            Pen pen = new Pen(c, 2.0F);
            for (int i = 0; i < 2 * N + 3; i++)
            {
                p[i].X = p[i].X * 15 + x - 20;
                p[i].Y = -p[i].Y * 15 + y;
            }
            g.DrawCurve(pen, p);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PointF[] p = Fun.getPoints();
            draw(p, ref func, Color.Black);
            float[] X = Fun.getY(p);

            var c = new WT().DWT(X);
            for (int i = 0; i < c.Length; i++) c[i] /= c.Length;
            var newP = Fun.setY(c, p);
            draw(newP, ref dwt, Color.Blue);
            var newX = new WT().DWT(c);
            newP = Fun.setY(newX, p);
            draw(newP, ref odwt, Color.Blue);


            
            var c1 = WT.FWT(X);
            for (int i = 0; i < c1.Length; i++) c1[i] /= c1.Length;
            var newP1 = Fun.setY(c1, p);
            draw(newP1, ref fwt, Color.Red);
            var newX1 = WT.FWT(c1);
            newP1 = Fun.setY(newX1, p);
            draw(newP1, ref ofwt, Color.Red);


        }
    }
}
