using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyDrawing
{
    public partial class Form1 : Form
    {
        Bitmap bitmap, bitmapClone;

    Color color;
    bool mouseDown = false;
    int x0, y0, x1, y1;

        private void pictureBox1_MouseUp_Click(object sender, EventArgs e)
        {
            if (mouseDown)
            {
                x1 = e.X; y1 = e.Y;
                MyDrawing.drawLine(x0, y0, x1, y1, bitmap, pictureBox1, color);
                mouseDown = false;
            }
        }

        private void pictureBox1_MouseMove_Click(object sender, EventArgs e)
        {
            if(mouseDown)
            {
                bitmapClone = (Bitmap)bitmap.Clone();
                x1 = e.X; y1 = e.Y;
                MyDrawing.drawline(x0, y0, x1, y1, bitmap, pictureBox1, color);
                bitmap = bitmapClone;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDrawing.drawline(50, 20, 200, 20, bitmap, pictureBox1, Color.Green);
        }

        private void pictureBox1_MouseDown_Click(object sender, EventArgs e)
        {
            x0 = e.X; y0 = e.Y;
            mouseDown = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Widht, pictureBox1.Height);
            color = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
