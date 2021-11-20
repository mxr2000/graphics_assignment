using System;
using System.Collections.Generic;
using System.Drawing;
using GraphicsAssignment.DrawingItem.DrawingMethod;

namespace GraphicsAssignment.DrawingItem
{
    class Line : IDrawing
    {
        public int XCoordinate1 { get; set; }
        public int YCoordinate1 { get; set; }
        public int XCoordinate2 { get; set; }
        public int YCoordinate2 { get; set; }
        public ILineDrawingMethod DrawingMethod { get; set; }
        public Color BorderColor { get; set; }
        public void Draw(Graphics graphics)
        {
            DrawingMethod.Draw(graphics, BorderColor, XCoordinate1, YCoordinate1, XCoordinate2, YCoordinate2);
        }
        public Line(int x1, int y1, int x2, int y2)
        {
            XCoordinate1 = x1;
            YCoordinate1 = y1;
            XCoordinate2 = x2;
            YCoordinate2 = y2;
            BorderColor = Color.Black;
            DrawingMethod = new GDIPlusLineDrawingMethod();
            index++;
        }

        static int index = 0;
        public override string ToString()
        {
            return "line #" + index;
        }
    }
}
