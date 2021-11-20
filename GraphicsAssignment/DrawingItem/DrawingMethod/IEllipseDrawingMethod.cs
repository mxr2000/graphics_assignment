using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment.DrawingItem.DrawingMethod
{
    interface IEllipseDrawingMethod
    {
        void Draw(Graphics graphics, Color color, int xcoordinate, int ycoordinate, int width, int height);
    }
}
