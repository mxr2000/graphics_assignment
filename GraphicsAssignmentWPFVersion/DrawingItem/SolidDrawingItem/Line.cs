using GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GraphicsAssignmentWPFVersion.DrawingItem.SolidDrawingItem
{
    class Line : AbstractDrawingItem, ILineDrawingMethod
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Line()
        {
            DrawingMethod = new DefaultLineDrawingMethod() { LineDrawingMethod = this };
            lineIndex++;
        }

        static int lineIndex;
        public override string ToString()
        {
            return "line " + lineIndex;
        }
    }
}
