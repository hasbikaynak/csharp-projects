using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point startxy;
        Point endxy;
        Boolean ismousedown;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.DrawEllipse(Pens.Blue, 0, 0, 120, 100);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == true )
            {
                endxy = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            startxy = e.Location;
            ismousedown = true;
            Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            endxy = e.Location;
            ismousedown = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            
                e.Graphics.DrawEllipse(Pens.Blue, Math.Min(startxy.X, endxy.X), 
                    Math.Min(startxy.Y, endxy.Y), Math.Abs(endxy.X - startxy.X), 
                    Math.Abs(endxy.Y - startxy.Y));
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
