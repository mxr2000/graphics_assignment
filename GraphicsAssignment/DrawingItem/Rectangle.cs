using System;
using System.Collections.Generic;
using System.Drawing;
using GraphicsAssignment.DrawingItem.DrawingMethod;

namespace GraphicsAssignment.DrawingItem
{
    class Rectangle : IDrawing
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IRectangleDrawingMethod RectangleDrawingMethod { get; set; }
        public Color BorderColor { get; set; }
        public void Draw(Graphics graphics)
        {
            RectangleDrawingMethod.Draw(graphics, BorderColor, XCoordinate, YCoordinate, Width, Height);
        }
        public Rectangle(int xcoordiante, int ycoordinate, int width, int height)
        {
            RectangleDrawingMethod = new GDIPlusRectangleDrawingMethod();
            BorderColor = Color.Black;
            XCoordinate = xcoordiante;
            YCoordinate = ycoordinate;
            Width = width;
            Height = height;
            index++;
        }

        static int index = 0;
        public override string ToString()
        {
            return "rect #" + index;
        }
    }
}
