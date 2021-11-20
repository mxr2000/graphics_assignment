using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment.DrawingItem
{
    class CoordinateAxis : IDrawing
    {
        Pen pen = new Pen(Color.Black, 1);
        

        public int Width { get; set; }
        public int Height { get; set; }
        public int TriangleWidth { get; set; } = 20;
        public int TriangleHeight { get; set; } = 10;
        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, - Width / 2, 0, Width / 2, 0);
            graphics.DrawLine(pen, 0, -Height / 2, 0, Height / 2);
            graphics.DrawLine(pen, Width / 2 - TriangleWidth, +TriangleHeight / 2, Width / 2, 0);
            graphics.DrawLine(pen, Width / 2 - TriangleWidth, -TriangleHeight / 2, Width / 2, 0);
            graphics.DrawLine(pen, +TriangleHeight / 2, Height / 2 - TriangleWidth, 0, Height / 2);
            graphics.DrawLine(pen, -TriangleHeight / 2, Height / 2 - TriangleWidth, 0, Height / 2);
        }

        public CoordinateAxis(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }

}
