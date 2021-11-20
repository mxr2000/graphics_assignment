using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    class DefaultCircleDrawingMethod : AbstractDrawingMethod
    {
        public ICircleDrawingMethod DrawingMethod { get; set; }
        private bool hasDrawn;
        public override void InitializeTimeSegment()
        {
            hasDrawn = false;
        }

        public override bool IsFinished()
        {
            return hasDrawn;
        }

        public override void OperationOnSingleStep()
        {
            hasDrawn = true;
        }

        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        Pen pen = new Pen(new SolidColorBrush(Colors.Black), 1); 
        public override void SingleDraw(DrawingContext context)
        {
            context.DrawEllipse(null, pen, new System.Windows.Point(DrawingMethod.CenterX, DrawingMethod.CenterY), DrawingMethod.Radius, DrawingMethod.Radius);
        }
    }
}
