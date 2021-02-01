using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circle_deneme_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static void myline(int x0, int y0, int yk, int xk, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int dl;
            decimal m = 0, dx, dy, xi, yi;
            int widht = bitmap.Width - 1;
            int height = bitmap.Height - 1;

            //linia pozioma
            if (y0 == yk)
            {
                dl = Math.Abs(x0 - xk);
                int xii = x0;
                int dxii;
                if (x0 < xk) dxii = 1; else dxii = -1;
                for (int i = 0; i < dl; i++)
                {
                    if ((xii > 1) && (xii < widht) && (y0 > 1) && (y0 < height))
                        bitmap.SetPixel(xii, y0, color);
                    xii += dxii;
                }
                pictureBox.Image = bitmap;
                return;

            }
            //linia piniowa 
            if (x0 == xk)
            {
                dl = Math.Abs(y0 - yk);
                int yii = y0;
                int dyii;
                if (y0 < yk) dyii = 1; else dyii = -1;
                for (int i = 0; i < dl; i++)
                {
                    if ((x0 > 1) && (x0 < widht) && (yii > 1) && (yii < height))
                        bitmap.SetPixel(x0, yii, color);
                    yii += dyii;
                }
                pictureBox.Image = bitmap;
                return;
            }
            //linia ukośna
            if (x0 != xk) m = (decimal)(yk - y0) / (xk - x0); //współczynnik kierunkowy prostej
            xi = x0; yi = y0;
            if (Math.Abs(xk - x0) >= Math.Abs(yk - y0))
            {
                dl = Math.Abs(xk - x0);
                if (xk >= x0) dx = 1; else dx = -1;
                dy = m * dx;
            }
            else
            {
                dl = Math.Abs(yk - y0);
                if (yk >= y0) dy = 1; else dy = -1;
                dx = dy / m;
            }
            for (int i = 0; i <= dl; i++)
            {
                if ((xi > 1) && (xi < widht) && (yi > 1) && (yi < height))
                    bitmap.SetPixel((int)Math.Round(xi), (int)Math.Round(yi), color);
                xi += dx; yi += dy;
            }
            pictureBox.Image = bitmap;
        }
        public static void mycircle(int x0, int y0, int r, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int xi = x0 + r;
            int yi = y0;
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;
            int angle = 0;
            for (int i = 0; i < 360; i++)
            {
                angle += 1;
                if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                    bitmap.SetPixel(xi, yi, color);
                xi = (int)Math.Round(x0 + r * Math.Cos(angle * Math.PI / 180));
                yi = (int)Math.Round(x0 + r * Math.Sin(angle * Math.PI / 180));
            }
            pictureBox.Image = bitmap;
        }
        public static void mycirclev2(int x0, int y0, int r, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int xi = x0 + r;
            int yi = y0;
            int xii, yii;
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;
            float angle = 0;
            for (int i = 0; i < 360; i++)
            {
                angle += 1;


                xii = (int)Math.Round(x0 + r * Math.Cos(angle * Math.PI / 180));
                yii = (int)Math.Round(x0 + r * Math.Sin(angle * Math.PI / 180));
                myline(xi, yi, xii, yii, bitmap, pictureBox, color);
                xi = xii;
                yi = yii;
            }
            pictureBox.Image = bitmap;
        }
        public static void mylineb(int x0, int y0, int xk, int yk, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int deltax = xk - x0;
            int deltay = yk - y0;
            int xi = x0;
            int yi = y0;

            int pi = 2 * deltay - deltax;
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;
            bitmap.SetPixel(xi, yi, color);
            for (int i = 0; i < xk - x0; i++)
            {
                if (pi < 0)
                {
                    if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                        bitmap.SetPixel(xi++, yi, color);
                    pi = pi + 2 * deltay;

                }
                else
                {
                    if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                        bitmap.SetPixel(xi++, yi++, color);
                    pi = pi + 2 * deltay - 2 * deltax;
                }

            }
            pictureBox.Image = bitmap;
        }
        public static void mylinebver2(int x0, int y0, int xk, int yk, Bitmap bitmap, PictureBox pictureBox, Color color)
        {
            int dl, pi;
            int deltax = xk - x0;
            int deltay = yk - y0;
            int xi = x0;
            int yi = y0;
            int width = bitmap.Width - 1;
            int height = bitmap.Height - 1;

            if (Math.Abs(xk - x0) >= Math.Abs(yk - y0))
            {
                dl = Math.Abs(xk - x0);
                bitmap.SetPixel(xi, yi, color);
                pi = 2 * deltay - deltax;

                for (int i = 0; i < dl; i++)
                {
                    if (pi < 0)
                    {
                        if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                            bitmap.SetPixel(xi++, yi, color);
                        pi = pi + 2 * deltay;

                    }
                    else
                    {
                        if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                            bitmap.SetPixel(xi++, yi++, color);
                        pi = pi + 2 * deltay - 2 * deltax;
                    }

                }
            }
            else
            {
                dl = Math.Abs(yk - y0);
                bitmap.SetPixel(xi, yi, color);
                pi = 2 * deltax - deltay;
                for (int i = 0; i < dl; i++)
                {
                    if (pi < 0)
                    {
                        if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                            bitmap.SetPixel(xi, yi++, color);
                        pi = pi + 2 * deltax;

                    }
                    else
                    {
                        if ((xi > 1) && (xi < width) && (yi > 1) && (yi < height))
                            bitmap.SetPixel(xi++, yi++, color);
                        pi = pi + 2 * deltax - 2 * deltay;
                    }

                }
                pictureBox.Image = bitmap;

            }
        }
        public static int toplama(int firstnumber, int secondnumber)
        {
            return firstnumber + secondnumber;
        }

        private void btnlinia_Click(object sender, EventArgs e)
        {
            //Form1. toplama(3,5)
           
           this.Text = Convert.ToString(toplama(3, 4));
        }
    }
}
