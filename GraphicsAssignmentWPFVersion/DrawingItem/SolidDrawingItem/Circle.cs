using GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsAssignmentWPFVersion.DrawingItem.SolidDrawingItem
{
    class Circle : AbstractDrawingItem, ICircleDrawingMethod
    {
        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int Radius { get; set; }
        public Circle()
        {
            circleIndex++;
        }
        static int circleIndex;
        public override string ToString()
        {
            return "circle " + circleIndex; 
        }
    }
}
