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
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace GraphicsAssignmentWPFVersion
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Line line = new Line();
            try
            {
                line.X1 = Int32.Parse(tbLineX1.Text);
                line.Y1 = Int32.Parse(tbLineY1.Text);
                line.X2 = Int32.Parse(tbLineX2.Text);
                line.Y2 = Int32.Parse(tbLineY2.Text);
            }catch(Exception ex)
            {
                
            }
            Console.WriteLine(line.X1 + " " + line.Y1 + " " + line.X2 + " " + line.Y2);
            AbstractDrawingMethod lineDrawingMethod = null;
            if (rbLineBresenham.IsChecked.Value)
            {
                lineDrawingMethod = new BresenhamLineDrawingMethod { DrawingMethod = line };
            }
            else if (rbLineDDA.IsChecked.Value)
            {
                lineDrawingMethod = new DDALineDrawingMethod { DrawingMethod = line};
            }
            else
            {
                lineDrawingMethod = new DefaultLineDrawingMethod { LineDrawingMethod = line };
            }
            line.DrawingMethod = lineDrawingMethod;
            if (cbLineAnimation.IsChecked.Value)
                lineDrawingMethod.IsDrawingAnimation = true;
            else
                lineDrawingMethod.IsDrawingAnimation = false;
            canvas.DrawingItems.Add(line);
            canvas.InvalidateVisual();
            drawingItemsListBox.Items.Add(line);
        }

        private void BtnDrawCircle_Click(object sender, RoutedEventArgs e)
        {
            Circle circle = new Circle();
            try
            {
                circle.CenterX = Int32.Parse(tbCircleCenterX.Text);
                circle.CenterY = Int32.Parse(tbCircleCenterY.Text);
                circle.Radius = Int32.Parse(tbRadius.Text);
            }catch(Exception ex)
            {

            }
            AbstractDrawingMethod drawingMethod = null;
            if (rbCircleDefault.IsChecked.Value)
            {
                cbCircleAnimation.IsChecked = false;
                drawingMethod = new DefaultCircleDrawingMethod() { DrawingMethod = circle };
            }
            else
            {
                drawingMethod = new MidPointCircleDrawingMethod() { DrawingMethod = circle };
            }
            circle.DrawingMethod = drawingMethod;
            if (cbCircleAnimation.IsChecked.Value)
                drawingMethod.IsDrawingAnimation = true;
            else
                drawingMethod.IsDrawingAnimation = false;
            canvas.DrawingItems.Add(circle);
            canvas.InvalidateVisual();
            drawingItemsListBox.Items.Add(circle);
        }

        private void BtnDrawEllipse_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse = new Ellipse();
            try
            {
                ellipse.CenterX = Int32.Parse(tbEllipseCenterX.Text);
                ellipse.CenterY = Int32.Parse(tbEllipseCenterY.Text);
                ellipse.HorizontalLength = Int32.Parse(tbEllipseRadiusX.Text);
                ellipse.VerticalLength = Int32.Parse(tbEllipseRadiusY.Text);
            }catch(Exception ex)
            {
                
            }
            AbstractDrawingMethod drawingMethod = null;
            if (rbEllipseDefault.IsChecked.Value)
            {
                drawingMethod = new DefaultEllipseDrawingMethod() { DrawingMethod = ellipse};
            }else
            {
                drawingMethod = new MidPointEllipseDrawingMethod() { DrawingMethod = ellipse };
            }
            if (cbEllipseAnimation.IsChecked.Value)
                drawingMethod.IsDrawingAnimation = true;
            ellipse.DrawingMethod = drawingMethod;
            canvas.DrawingItems.Add(ellipse);
            canvas.InvalidateVisual();
            drawingItemsListBox.Items.Add(ellipse);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            List<Object> items = new List<object>();
            foreach (var item in drawingItemsListBox.SelectedItems)
                items.Add(item);
            foreach(Object item in items)
            {
                drawingItemsListBox.Items.Remove(item);
                if (item is AbstractDrawingItem)
                    canvas.DrawingItems.Remove(item as AbstractDrawingItem);
            }
            canvas.InvalidateVisual();
        }
    }
}
