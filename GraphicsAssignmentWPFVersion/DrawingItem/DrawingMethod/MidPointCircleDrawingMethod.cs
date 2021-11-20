using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    class MidPointCircleDrawingMethod : AbstractDrawingMethod
    {
        public ICircleDrawingMethod DrawingMethod { get; set; }
        private int p;
        private int currentY;
        public override void InitializeTimeSegment()
        {
            p = 1 - DrawingMethod.Radius;
            currentY = DrawingMethod.Radius;
            timeSegment = new Utils.TimeSegment() {Setp = 1, CurrentIndex = 0 };
        }

        public override bool IsFinished()
        {
            return timeSegment.CurrentIndex > currentY;
        }

        public override void SingleDraw(DrawingContext context)
        {
            Draw8Points(context, timeSegment.CurrentIndex, currentY);
        }

        public override void OperationOnSingleStep()
        {
            timeSegment.CurrentIndex += timeSegment.Setp;
            if(p < 0)
            {
                p = p + 2 * timeSegment.CurrentIndex + 1;
            }
            else
            {
                currentY--;
                p = p + 2 * timeSegment.CurrentIndex + 1 - 2 * currentY;
            }
        }

        private void Draw8Points(DrawingContext context, int x, int y)
        {
            int cx = DrawingMethod.CenterX;
            int cy = DrawingMethod.CenterY;
            int radius = DrawingMethod.Radius;
            DrawPoint(context, cx + x, cy + y);
            DrawPoint(context, cx + x, cy - y);
            DrawPoint(context, cx - x, cy + y);
            DrawPoint(context, cx - x, cy - y);
            DrawPoint(context, cx + y, cy + x);
            DrawPoint(context, cx + y, cy - x);
            DrawPoint(context, cx - y, cy + x);
            DrawPoint(context, cx - y, cy - x);

        }

        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        Pen pen = new Pen(new SolidColorBrush(Colors.Black), 1);
        private void DrawPoint(DrawingContext context, int x, int y)
        {
            context.DrawEllipse(brush, pen, new Point(x, y), 0.5, 0.5);
        }
    }
}
