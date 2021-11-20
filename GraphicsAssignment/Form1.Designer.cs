namespace GraphicsAssignment
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRect = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRectXCoordinate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRectYCoordinate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRectWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRectHeight = new System.Windows.Forms.TextBox();
            this.btnAddRect = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Brensenhem = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabPageEllipse = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEllipseXCoordinate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEllipseYCoordinate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEllipseWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEllipseHeight = new System.Windows.Forms.TextBox();
            this.tabPageLine = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tbLineX1Coordinate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLineY1Coordinate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLineX2Coordinate = new System.Windows.Forms.TextBox();
            this.tbLineY2Coordinate = new System.Windows.Forms.TextBox();
            this.listBoxDrawingItems = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.btnEllipseAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRect.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPageEllipse.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPageLine.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(874, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBoxDrawingItems);
            this.splitContainer1.Size = new System.Drawing.Size(263, 592);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRect);
            this.tabControl1.Controls.Add(this.tabPageEllipse);
            this.tabControl1.Controls.Add(this.tabPageLine);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(263, 339);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageRect
            // 
            this.tabPageRect.Controls.Add(this.tableLayoutPanel2);
            this.tabPageRect.Location = new System.Drawing.Point(4, 25);
            this.tabPageRect.Name = "tabPageRect";
            this.tabPageRect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRect.Size = new System.Drawing.Size(255, 310);
            this.tabPageRect.TabIndex = 0;
            this.tabPageRect.Text = "Rectangle";
            this.tabPageRect.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbRectXCoordinate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbRectYCoordinate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbRectWidth, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbRectHeight, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnAddRect, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radioButton1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Brensenhem, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.radioButton2, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(249, 304);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Coordinate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbRectXCoordinate
            // 
            this.tbRectXCoordinate.Location = new System.Drawing.Point(127, 3);
            this.tbRectXCoordinate.Name = "tbRectXCoordinate";
            this.tbRectXCoordinate.Size = new System.Drawing.Size(100, 25);
            this.tbRectXCoordinate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y Coordinate";
            // 
            // tbRectYCoordinate
            // 
            this.tbRectYCoordinate.Location = new System.Drawing.Point(127, 34);
            this.tbRectYCoordinate.Name = "tbRectYCoordinate";
            this.tbRectYCoordinate.Size = new System.Drawing.Size(100, 25);
            this.tbRectYCoordinate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width";
            // 
            // tbRectWidth
            // 
            this.tbRectWidth.Location = new System.Drawing.Point(127, 65);
            this.tbRectWidth.Name = "tbRectWidth";
            this.tbRectWidth.Size = new System.Drawing.Size(100, 25);
            this.tbRectWidth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Height";
            // 
            // tbRectHeight
            // 
            this.tbRectHeight.Location = new System.Drawing.Point(127, 96);
            this.tbRectHeight.Name = "tbRectHeight";
            this.tbRectHeight.Size = new System.Drawing.Size(100, 25);
            this.tbRectHeight.TabIndex = 7;
            // 
            // btnAddRect
            // 
            this.btnAddRect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddRect.Location = new System.Drawing.Point(127, 271);
            this.btnAddRect.Name = "btnAddRect";
            this.btnAddRect.Size = new System.Drawing.Size(119, 30);
            this.btnAddRect.TabIndex = 8;
            this.btnAddRect.Text = "Add";
            this.btnAddRect.UseVisualStyleBackColor = true;
            this.btnAddRect.Click += new System.EventHandler(this.btnAddRect_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Alogrithm";
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "GDI+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Brensenhem
            // 
            this.Brensenhem.AutoSize = true;
            this.Brensenhem.Location = new System.Drawing.Point(3, 177);
            this.Brensenhem.Name = "Brensenhem";
            this.Brensenhem.Size = new System.Drawing.Size(100, 19);
            this.Brensenhem.TabIndex = 11;
            this.Brensenhem.TabStop = true;
            this.Brensenhem.Text = "Brehenhum";
            this.Brensenhem.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 202);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 19);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "GTK";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tabPageEllipse
            // 
            this.tabPageEllipse.Controls.Add(this.tableLayoutPanel3);
            this.tabPageEllipse.Location = new System.Drawing.Point(4, 25);
            this.tabPageEllipse.Name = "tabPageEllipse";
            this.tabPageEllipse.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEllipse.Size = new System.Drawing.Size(255, 310);
            this.tabPageEllipse.TabIndex = 1;
            this.tabPageEllipse.Text = "Ellipse";
            this.tabPageEllipse.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnEllipseAdd, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbEllipseXCoordinate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbEllipseYCoordinate, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbEllipseWidth, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbEllipseHeight, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(249, 304);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "X Coordinate";
            // 
            // tbEllipseXCoordinate
            // 
            this.tbEllipseXCoordinate.Location = new System.Drawing.Point(127, 3);
            this.tbEllipseXCoordinate.Name = "tbEllipseXCoordinate";
            this.tbEllipseXCoordinate.Size = new System.Drawing.Size(100, 25);
            this.tbEllipseXCoordinate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Y Coordinate";
            // 
            // tbEllipseYCoordinate
            // 
            this.tbEllipseYCoordinate.Location = new System.Drawing.Point(127, 34);
            this.tbEllipseYCoordinate.Name = "tbEllipseYCoordinate";
            this.tbEllipseYCoordinate.Size = new System.Drawing.Size(100, 25);
            this.tbEllipseYCoordinate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Width";
            // 
            // tbEllipseWidth
            // 
            this.tbEllipseWidth.Location = new System.Drawing.Point(127, 65);
            this.tbEllipseWidth.Name = "tbEllipseWidth";
            this.tbEllipseWidth.Size = new System.Drawing.Size(100, 25);
            this.tbEllipseWidth.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Height";
            // 
            // tbEllipseHeight
            // 
            this.tbEllipseHeight.Location = new System.Drawing.Point(127, 96);
            this.tbEllipseHeight.Name = "tbEllipseHeight";
            this.tbEllipseHeight.Size = new System.Drawing.Size(100, 25);
            this.tbEllipseHeight.TabIndex = 7;
            // 
            // tabPageLine
            // 
            this.tabPageLine.Controls.Add(this.tableLayoutPanel4);
            this.tabPageLine.Location = new System.Drawing.Point(4, 25);
            this.tabPageLine.Name = "tabPageLine";
            this.tabPageLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLine.Size = new System.Drawing.Size(255, 310);
            this.tabPageLine.TabIndex = 2;
            this.tabPageLine.Text = "Line";
            this.tabPageLine.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tbLineX1Coordinate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tbLineY1Coordinate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.button1, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tbLineX2Coordinate, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tbLineY2Coordinate, 1, 3);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(249, 304);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "X1 Coordinate";
            // 
            // tbLineX1Coordinate
            // 
            this.tbLineX1Coordinate.Location = new System.Drawing.Point(127, 3);
            this.tbLineX1Coordinate.Name = "tbLineX1Coordinate";
            this.tbLineX1Coordinate.Size = new System.Drawing.Size(100, 25);
            this.tbLineX1Coordinate.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Y1 Coordinate";
            // 
            // tbLineY1Coordinate
            // 
            this.tbLineY1Coordinate.Location = new System.Drawing.Point(127, 34);
            this.tbLineY1Coordinate.Name = "tbLineY1Coordinate";
            this.tbLineY1Coordinate.Size = new System.Drawing.Size(100, 25);
            this.tbLineY1Coordinate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(127, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "X2 Coordinate";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Y2 Coordinate";
            // 
            // tbLineX2Coordinate
            // 
            this.tbLineX2Coordinate.Location = new System.Drawing.Point(127, 65);
            this.tbLineX2Coordinate.Name = "tbLineX2Coordinate";
            this.tbLineX2Coordinate.Size = new System.Drawing.Size(100, 25);
            this.tbLineX2Coordinate.TabIndex = 7;
            // 
            // tbLineY2Coordinate
            // 
            this.tbLineY2Coordinate.Location = new System.Drawing.Point(127, 96);
            this.tbLineY2Coordinate.Name = "tbLineY2Coordinate";
            this.tbLineY2Coordinate.Size = new System.Drawing.Size(100, 25);
            this.tbLineY2Coordinate.TabIndex = 8;
            // 
            // listBoxDrawingItems
            // 
            this.listBoxDrawingItems.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxDrawingItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDrawingItems.FormattingEnabled = true;
            this.listBoxDrawingItems.ItemHeight = 15;
            this.listBoxDrawingItems.Location = new System.Drawing.Point(0, 0);
            this.listBoxDrawingItems.Name = "listBoxDrawingItems";
            this.listBoxDrawingItems.Size = new System.Drawing.Size(263, 249);
            this.listBoxDrawingItems.TabIndex = 0;
            this.listBoxDrawingItems.SelectedIndexChanged += new System.EventHandler(this.listBoxDrawingItems_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // menuItemRemove
            // 
            this.menuItemRemove.Name = "menuItemRemove";
            this.menuItemRemove.Size = new System.Drawing.Size(134, 24);
            this.menuItemRemove.Text = "remove";
            this.menuItemRemove.Click += new System.EventHandler(this.menuRemoveItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelDraw, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 598);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDraw.Location = new System.Drawing.Point(10, 10);
            this.panelDraw.Margin = new System.Windows.Forms.Padding(10);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Padding = new System.Windows.Forms.Padding(10);
            this.panelDraw.Size = new System.Drawing.Size(851, 578);
            this.panelDraw.TabIndex = 3;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            // 
            // btnEllipseAdd
            // 
            this.btnEllipseAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEllipseAdd.Location = new System.Drawing.Point(3, 271);
            this.btnEllipseAdd.Name = "btnEllipseAdd";
            this.btnEllipseAdd.Size = new System.Drawing.Size(118, 30);
            this.btnEllipseAdd.TabIndex = 9;
            this.btnEllipseAdd.Text = "Add";
            this.btnEllipseAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorithm";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.radioButton7);
            this.flowLayoutPanel2.Controls.Add(this.radioButton6);
            this.flowLayoutPanel2.Controls.Add(this.radioButton8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(237, 76);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 28);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(124, 19);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(3, 3);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(124, 19);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "radioButton7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(3, 53);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(124, 19);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "radioButton8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRect.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPageEllipse.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPageLine.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRectXCoordinate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRectYCoordinate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRectWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRectHeight;
        private System.Windows.Forms.Button btnAddRect;
        private System.Windows.Forms.TabPage tabPageEllipse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEllipseXCoordinate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEllipseYCoordinate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEllipseWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEllipseHeight;
        private System.Windows.Forms.TabPage tabPageLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbLineX1Coordinate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLineY1Coordinate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLineX2Coordinate;
        private System.Windows.Forms.TextBox tbLineY2Coordinate;
        private System.Windows.Forms.ListBox listBoxDrawingItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemRemove;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Brensenhem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnEllipseAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton8;
    }
}

