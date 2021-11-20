using GraphicsAssignment.DrawingItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsAssignment
{
    public partial class Form1 : Form
    {
        List<IDrawing> drawingItems = new List<IDrawing>();
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drawingItems.Add(new CoordinateAxis(panelDraw.Width, panelDraw.Height));
        }

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.TranslateTransform(panelDraw.Width / 2, panelDraw.Height / 2);
            Matrix matrix = new Matrix(1, 0, 0, -1, 0, 0);
            graphics.MultiplyTransform(matrix);
            foreach (IDrawing item in drawingItems)
                item.Draw(graphics);
            
        }

        private void btnAddRect_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbRectXCoordinate.Text);
                int y = int.Parse(tbRectYCoordinate.Text);
                int width = int.Parse(tbRectWidth.Text);
                int height = int.Parse(tbRectHeight.Text);
                DrawingItem.Rectangle rectangle = new DrawingItem.Rectangle(x, y, width, height);
                drawingItems.Add(rectangle);
                panelDraw.Invalidate();

                listBoxDrawingItems.Items.Add(rectangle);
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnEllipseAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbEllipseXCoordinate.Text);
                int y = int.Parse(tbEllipseYCoordinate.Text);
                int width = int.Parse(tbEllipseWidth.Text);
                int height = int.Parse(tbEllipseHeight.Text);
                DrawingItem.Ellipse ellipse = new DrawingItem.Ellipse(x, y, width, height);
                drawingItems.Add(ellipse);
                panelDraw.Invalidate();

                listBoxDrawingItems.Items.Add(ellipse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(tbLineX1Coordinate.Text);
                int y1 = int.Parse(tbLineY1Coordinate.Text);
                int x2 = int.Parse(tbLineX2Coordinate.Text);
                int y2 = int.Parse(tbLineY2Coordinate.Text);
                DrawingItem.Line line = new DrawingItem.Line(x1, y1, x2, y2);
                drawingItems.Add(line);
                panelDraw.Invalidate();

                listBoxDrawingItems.Items.Add(line);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void listBoxDrawingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxDrawingItems.SelectedItem is GraphicsAssignment.DrawingItem.Rectangle)
            {
                DrawingItem.Rectangle rectangle = listBoxDrawingItems.SelectedItem as DrawingItem.Rectangle;
                tabControl1.SelectedTab = tabPageRect;
                tbRectHeight.Text = "" + rectangle.Height;
                tbRectWidth.Text = "" + rectangle.Width;
                tbRectXCoordinate.Text = "" + rectangle.XCoordinate;
                tbRectYCoordinate.Text = "" + rectangle.YCoordinate;
            }else if(listBoxDrawingItems.SelectedItem is GraphicsAssignment.DrawingItem.Ellipse)
            {

            }else if(listBoxDrawingItems.SelectedItem is GraphicsAssignment.DrawingItem.Line)
            {

            }
        }

        private void menuRemoveItem_Click(object sender, EventArgs e)
        {
            if(listBoxDrawingItems.SelectedItem != null)
            {
                IDrawing item = listBoxDrawingItems.SelectedItem as IDrawing;
                drawingItems.Remove(item);
                listBoxDrawingItems.Items.Remove(item);
                panelDraw.Invalidate();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }
    }
}
