using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class Fun
    {
        private static int N = 8;
        static public PointF[] getPoints()
        {
            PointF[] points = new PointF[8];
            float step = 2.0f * (float)Math.PI / 8.0f;
            for (int i = 0; i < N; i++)
            {
                points[i].X = step * i;
                points[i].Y = (float)(Math.Cos(3 * points[i].X) + Math.Sin(2 * points[i].X));
            }
            return points;
        }
        static public float[] getY(PointF[] p)
        {
            float[] y = new float[p.Length];
            for (int i = 0; i < p.Length; i++)
            {
                y[i] = p[i].Y;
            }
            return y;
        }
        static public PointF[] setY(float[] y, PointF[] p)
        {
            PointF[] newP = new PointF[y.Length];
            for (int i = 0; i < p.Length; i++)
            {
                newP[i].X = p[i].X;
                newP[i].Y = y[i];
            }
            return newP;
        }
    }
}
