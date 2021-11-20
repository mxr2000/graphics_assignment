using GraphicsAssignmentWPFVersion.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Threading;

namespace GraphicsAssignmentWPFVersion.DrawingItem
{
    abstract class AbstractDrawingMethod
    {
        protected TimeSegment timeSegment;
        private int timeExtent;
        private bool isDrawingAnimation;
        public bool IsDrawingAnimation
        {
            get
            {
                return isDrawingAnimation;
            }
            set
            {
                isDrawingAnimation = value;
                DrawAnimation();
            }
        }
        public void Draw(DrawingContext context)
        {
            DrawToExtent(context, -1);
        }
        public void DrawAnimation()
        {
            InitializeTimeSegment();
            timeExtent = 0;
        }
        public void DrawInAnimation(DrawingContext context)
        {
            DrawToExtent(context,timeExtent);
            timeExtent++;
            if (IsFinished())
                IsDrawingAnimation = false;
        }


        public void DrawToExtent(DrawingContext context, int extent)
        {
            InitializeTimeSegment();
            while (!IsFinished() && (extent <= -1 || extent > 0))
            {
                SingleDraw(context);
                OperationOnSingleStep();
                extent--;
            }
            
        }
        public abstract void InitializeTimeSegment();
        public abstract bool IsFinished();
        public abstract void SingleDraw(DrawingContext context);
        public abstract void OperationOnSingleStep();

    }
}
