using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    class MidPointEllipseDrawingMethod : AbstractDrawingMethod
    {
        public IEllipseDrawingMethod DrawingMethod { get; set; }
        float p;
        int phase;
        int value;
        int lengthX, lengthY;
        public override void InitializeTimeSegment()
        {
            timeSegment = new Utils.TimeSegment();
            timeSegment.Setp = 1;
            timeSegment.CurrentIndex = 0;
            
            lengthX = DrawingMethod.HorizontalLength;
            lengthY = DrawingMethod.VerticalLength;
            phase = 1;
            value = lengthY;
            p = lengthY * lengthY - lengthX * lengthX * lengthY + lengthX * lengthX / 4.0f;
        }

        public override bool IsFinished()
        {
            return phase == 2 && timeSegment.CurrentIndex == 0;
        }

        public override void OperationOnSingleStep()
        {
            timeSegment.CurrentIndex += timeSegment.Setp;
            if (phase == 1)
            {
                if (p < 0)
                {
                    p = p + 2 * lengthY * lengthY * timeSegment.CurrentIndex + lengthY * lengthY;
                }
                else
                {
                    value--;
                    p = p + 2 * lengthY * lengthY * timeSegment.CurrentIndex  - 2 * lengthX * lengthX * value + lengthY * lengthY;
                }
                if (lengthY * lengthY * timeSegment.CurrentIndex >= lengthX * lengthX * value)
                {
                    phase = 2;
                    p = lengthY * lengthY * (timeSegment.CurrentIndex + 0.5f) * (timeSegment.CurrentIndex + 0.5f)
                        + lengthX * lengthX * (value - 1) * (value - 1) - lengthX * lengthX * lengthY * lengthY;
                    int temp = timeSegment.CurrentIndex;
                    timeSegment.CurrentIndex = value;
                    value = temp;
                    timeSegment.Setp = -1;
                }
            }
            else
            {
                if(p > 0)
                {
                    p = p - 2 * lengthX * lengthX * timeSegment.CurrentIndex + lengthX * lengthX;
                }
                else
                {
                    value++;
                    p = p + 2 * lengthY * lengthY * value - 2 * lengthX * lengthX * timeSegment.CurrentIndex + lengthX * lengthX;
                }
            }

        }

        public override void SingleDraw(DrawingContext context)
        {
            if (phase == 1)
            {
                Draw4Points(context, timeSegment.CurrentIndex, value);
            }
            else
            {
                Draw4Points(context, value, timeSegment.CurrentIndex);
            }
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        Pen pen = new Pen(new SolidColorBrush(Colors.Black), 1);
        private void DrawPoint(DrawingContext context, int x, int y)
        {
            context.DrawEllipse(brush, pen, new Point(x, y), 0.5, 0.5);
        }

        private void Draw4Points(DrawingContext context, int x, int y)
        {
            int cx = DrawingMethod.CenterX;
            int cy = DrawingMethod.CenterY;
            DrawPoint(context, cx + x, cy + y);
            DrawPoint(context, cx + x, cy - y);
            DrawPoint(context, cx - x, cy + y);
            DrawPoint(context, cx - x, cy - y);

        }
    }
}
