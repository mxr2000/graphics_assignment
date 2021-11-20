using GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignmentWPFVersion.DrawingItem.SolidDrawingItem
{
    class Ellipse : AbstractDrawingItem, IEllipseDrawingMethod
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int HorizontalLength { get; set; }
        public int VerticalLength { get; set; }
        public Ellipse()
        {
            ellipseIndex++;
        }
        static int ellipseIndex;
        public override string ToString()
        {
            return "ellipse " + ellipseIndex;
        }
    }
}
