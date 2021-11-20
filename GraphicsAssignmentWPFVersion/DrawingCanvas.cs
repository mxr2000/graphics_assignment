using GraphicsAssignmentWPFVersion.DrawingItem;
using GraphicsAssignmentWPFVersion.DrawingItem.DrawingMethod;
using GraphicsAssignmentWPFVersion.DrawingItem.SolidDrawingItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace GraphicsAssignmentWPFVersion
{
    class DrawingCanvas : System.Windows.Controls.Canvas
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public List<AbstractDrawingItem> DrawingItems { get; set; } = new List<AbstractDrawingItem>();
        public DrawingCanvas()
        {
            InvalidateVisual();
            //Line line = new Line() { X1 = 0, Y1 = 0, X2 = 200, Y2 = 100};
            //DDALineDrawingMethod lineDrawingMethod = new DDALineDrawingMethod { DrawingMethod = line, IsDrawingAnimation = true };
            //line.DrawingMethod = lineDrawingMethod;
            //DrawingItems.Add(line);
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(500000);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach(AbstractDrawingItem drawingItem in DrawingItems)
            {
                if (drawingItem.DrawingMethod.IsDrawingAnimation)
                {
                    InvalidateVisual();
                    break;
                }
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            
            TranslateTransform translate = new TranslateTransform(ActualWidth / 2, ActualHeight / 2);
            ScaleTransform scale = new ScaleTransform(1, -1);
            drawingContext.PushTransform(translate);
            drawingContext.PushTransform(scale);
            DrawAxixes(drawingContext);
            foreach (AbstractDrawingItem drawingItem in DrawingItems)
            {
                if (drawingItem.DrawingMethod.IsDrawingAnimation)
                    drawingItem.DrawingMethod.DrawInAnimation(drawingContext);
                else
                    drawingItem.DrawingMethod.Draw(drawingContext);

            }
        }

        private void DrawPoint(DrawingContext context, int x, int y)
        {
            context.DrawEllipse(new SolidColorBrush(Colors.Black), new Pen(new SolidColorBrush(Colors.Black), 1), new Point(x, y), 0.5, 0.5);
        }
        Pen pen = new Pen(new SolidColorBrush(Colors.Black), 1);
        private void DrawAxixes(DrawingContext context)
        {
            context.DrawLine(pen, new Point(-ActualWidth / 2, 0), new Point(ActualWidth / 2, 0));
            context.DrawLine(pen, new Point(0, -ActualHeight / 2), new Point(0, ActualHeight / 2));
            context.DrawLine(pen, new Point(10, ActualHeight / 2 - 20), new Point(0, ActualHeight / 2));
            context.DrawLine(pen, new Point(-10, ActualHeight / 2 - 20), new Point(0, ActualHeight / 2));
            context.DrawLine(pen, new Point(ActualWidth / 2 - 20, 10), new Point(ActualWidth / 2, 0));
            context.DrawLine(pen, new Point(ActualWidth / 2 - 20, -10), new Point(ActualWidth / 2, 0));
        }

    }

}
