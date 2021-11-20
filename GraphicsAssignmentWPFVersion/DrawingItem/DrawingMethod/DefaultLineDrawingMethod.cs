using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    class DefaultLineDrawingMethod : AbstractDrawingMethod
    {
        public ILineDrawingMethod LineDrawingMethod { get; set; }
        bool hasDrawn;
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

        public override void SingleDraw(DrawingContext context)
        {
            //context.DrawEllipse(new SolidColorBrush(Colors.Black), new Pen(new SolidColorBrush(Colors.Black), 1), new Point(0, timeSegment.CurrentIndex), 0.5, 0.5);
            context.DrawLine(new Pen(new SolidColorBrush(Colors.Black), 1), new Point(LineDrawingMethod.X1, LineDrawingMethod.Y1), new Point(LineDrawingMethod.X2, LineDrawingMethod.Y2));

        }
    }
}
