using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    interface IEllipseDrawingMethod
    {
        int CenterX { get; set; }
        int CenterY { get; set; }
        int HorizontalLength { get; set; }
        int VerticalLength { get; set; }
    }
}
