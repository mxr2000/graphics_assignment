using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    interface ILineDrawingMethod
    {
        int X1 { get; set; }
        int Y1 { get; set; }
        int X2 { get; set; }
        int Y2 { get; set; }
    }
}
