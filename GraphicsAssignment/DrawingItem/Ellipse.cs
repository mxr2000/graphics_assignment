using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsAssignment.DrawingItem.DrawingMethod;
namespace GraphicsAssignment.DrawingItem
{
    class Ellipse : IDrawing
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public IEllipseDrawingMethod DrawingMethod { get; set; }
        public Color BorderColor { get; set; }
        public void Draw(Graphics graphics)
        {
            DrawingMethod.Draw(graphics, BorderColor, XCoordinate, YCoordinate, Width, Height);
        }
        public Ellipse(int xcoordiante, int ycoordinate, int width, int height)
        {
            DrawingMethod = new GDIEllipseDrawingMethod();
            BorderColor = Color.Black;
            XCoordinate = xcoordiante;
            YCoordinate = ycoordinate;
            Width = width;
            Height = height;
            index++;
        }
        static int index;
        public override string ToString()
        {
            return "ellisep #" + index;
        }
    }
}
