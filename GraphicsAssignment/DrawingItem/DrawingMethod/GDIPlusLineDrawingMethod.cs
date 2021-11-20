using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignment.DrawingItem.DrawingMethod
{
    class GDIPlusLineDrawingMethod : ILineDrawingMethod
    {
        public void Draw(Graphics graphics, Color color, int x1, int y1, int x2, int y2)
        {
            graphics.DrawLine(new Pen(color), x1, y1, x2, y2);
        }
    }
}
