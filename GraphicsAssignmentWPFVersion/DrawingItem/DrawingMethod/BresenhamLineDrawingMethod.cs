using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    class BresenhamLineDrawingMethod : AbstractDrawingMethod
    {
        public ILineDrawingMethod DrawingMethod { get; set; }
        int x0, y0;
        int deltaX, deltaY;
        int value;
        float p;
        float slope;
        public override void InitializeTimeSegment()
        {
            slope = (DrawingMethod.Y2 - DrawingMethod.Y1) * 1.0f / (DrawingMethod.X2 - DrawingMethod.X1);
            if (Math.Abs(slope) < 1)
            {
                timeSegment = new Utils.TimeSegment() { Setp = 1, CurrentIndex = x0 };
                p = 2 * deltaY - deltaX;
                if (DrawingMethod.X1 < DrawingMethod.X2)
                {
                    x0 = DrawingMethod.X1;
                    y0 = DrawingMethod.Y1;
                    deltaX = DrawingMethod.X2 - DrawingMethod.X1;
                    deltaY = DrawingMethod.Y2 - DrawingMethod.Y1;
                }
                else
                {
                    x0 = DrawingMethod.X2;
                    y0 = DrawingMethod.Y2;
                    deltaX = DrawingMethod.X1 - DrawingMethod.X2;
                    deltaY = DrawingMethod.Y1 - DrawingMethod.Y2;
                }
                value = y0;
            }
            else
            {
                timeSegment = new Utils.TimeSegment() { Setp = 1, CurrentIndex = y0 };
                p = 2 * deltaX - deltaY;
                if (DrawingMethod.Y1 < DrawingMethod.Y2)
                {
                    x0 = DrawingMethod.X1;
                    y0 = DrawingMethod.Y1;
                    deltaX = DrawingMethod.X2 - DrawingMethod.X1;
                    deltaY = DrawingMethod.Y2 - DrawingMethod.Y1;
                }
                else
                {
                    x0 = DrawingMethod.X2;
                    y0 = DrawingMethod.Y2;
                    deltaX = DrawingMethod.X1 - DrawingMethod.X2;
                    deltaY = DrawingMethod.Y1 - DrawingMethod.Y2;
                }
                value = x0;
            }
        }

        public override bool IsFinished()
        {
            if (Math.Abs(slope) < 1)
                return timeSegment.CurrentIndex == x0 + deltaX + 1;
            else
                return timeSegment.CurrentIndex == y0 + deltaY + 1;
        }

        public override void OperationOnSingleStep()
        {
            Console.WriteLine("current p = " + p);
            timeSegment.CurrentIndex += timeSegment.Setp;
            if(Math.Abs(slope) < 1)
            {
                if(p < 0)
                {
                    p += 2 * deltaY;
                }
                else
                {
                    value++;
                    p = p + 2 * deltaY - 2 * deltaX;
                }
            }
            else
            {
                if(p < 0)
                {
                    p += 2 * deltaX;
                }
                else
                {
                    value++;
                    p = p + 2 * deltaX - 2 * deltaY;
                }
            }
        }

        public override void SingleDraw(DrawingContext context)
        {
            if (Math.Abs(slope) < 1)
                DrawPoint(context, timeSegment.CurrentIndex, value);
            else
                DrawPoint(context, value, timeSegment.CurrentIndex);
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.Black);
        Pen pen = new Pen(new SolidColorBrush(Colors.Black), 1);
        private void DrawPoint(DrawingContext context, int x, int y)
        {
            context.DrawEllipse(brush, pen, new Point(x, y), 0.5, 0.5);
        }
    }
}
