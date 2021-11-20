using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod
{
    class DDALineDrawingMethod : AbstractDrawingMethod
    {
        public ILineDrawingMethod DrawingMethod { get; set; }
        private int smallX, largeX, smallY, largeY;
        private double slope;

        public override void InitializeTimeSegment()
        {
            smallX = DrawingMethod.X1 < DrawingMethod.X2 ? DrawingMethod.X1 : DrawingMethod.X2;
            largeX = DrawingMethod.X1 > DrawingMethod.X2 ? DrawingMethod.X1 : DrawingMethod.X2;
            smallY = DrawingMethod.Y1 < DrawingMethod.Y2 ? DrawingMethod.Y1 : DrawingMethod.Y2;
            largeY = DrawingMethod.Y1 > DrawingMethod.Y2 ? DrawingMethod.Y1 : DrawingMethod.Y2;
            slope = (DrawingMethod.Y2 - DrawingMethod.Y1) * 1.0 / (largeX - smallX);
            if (Math.Abs(slope) < 1)
            {
                timeSegment = new Utils.TimeSegment() { Setp = 1, CurrentIndex = smallX };
                valueK = DrawingMethod.X1 < DrawingMethod.X2 ? DrawingMethod.Y1 : DrawingMethod.Y2;
            }
            else
            {
                timeSegment = new Utils.TimeSegment() { Setp = 1, CurrentIndex = smallY };
                valueK = DrawingMethod.Y1 < DrawingMethod.Y2 ? DrawingMethod.X1 : DrawingMethod.X2;
            }
        }

        public override bool IsFinished()
        {
            return timeSegment.CurrentIndex > largeX;
        }

        public override void OperationOnSingleStep()
        {
            timeSegment.CurrentIndex++;
        }

        private double valueK;
        public override void SingleDraw(DrawingContext context)
        {
            if (Math.Abs(slope) < 1)
            {
                context.DrawEllipse(new SolidColorBrush(Colors.Black), new Pen(new SolidColorBrush(Colors.Black), 1), new Point(timeSegment.CurrentIndex, (int)(valueK)), 0.5, 0.5);
                valueK += slope;
            }
            else
            {
                context.DrawEllipse(new SolidColorBrush(Colors.Black), new Pen(new SolidColorBrush(Colors.Black), 1), new Point((int)(valueK), timeSegment.CurrentIndex), 0.5, 0.5);
                valueK += 1 / slope;
            }
            
        }
    }
}
