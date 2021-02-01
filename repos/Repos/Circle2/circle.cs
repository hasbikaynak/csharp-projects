using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle2
{
    public class circle
    {
        Point startxy;
        Point endxy;
        public void draw(Graphics toolfordrawing)
        {
            toolfordrawing.DrawEllipse(Pens.Blue, Math.Min(startxy.X, endxy.X),
                    Math.Min(startxy.Y, endxy.Y), Math.Abs(endxy.X - startxy.X),
                    Math.Abs(endxy.Y - startxy.Y));
        }
    }
}
