using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsAppGraphicsEditor
{
    public partial class FormEditorWindow : Form
    {
        static Pen pen;
        private Figure CurFigure;
        private bool IsMouseDown = false;
        public FiguresList figuresList;
        const string FileName = "SerializedObjects.bin";
        public Graphics tempDrawing, permanentDrawing;
        public Serializer serializer;
        Image image;
        public FormEditorWindow()
        {
            InitializeComponent();
            figuresList = new FiguresList();
            serializer = new Serializer();
            tempDrawing = pbPage.CreateGraphics();
            image = new Bitmap(pbPage.Width, pbPage.Height);
            permanentDrawing = Graphics.FromImage(image);
            pen = new Pen(Color.Red);
        }

        public void clearPictureBox()
        {
            tempDrawing.Clear(pbPage.BackColor);
            permanentDrawing.Clear(pbPage.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearPictureBox();
            figuresList = new FiguresList();
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Rectangle();
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Triangle();
        }

        private void rbEllipse_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Ellipse();
        }

        private void rbSix_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Hexagon();
        }

        private void pbPage_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                figuresList.ListOfFigures.Add(CurFigure);
                CurFigure.DrawFigure(permanentDrawing, pen);
                tempDrawing.DrawImage(image, 0, 0);
                IsMouseDown = false;
                rbLine.Checked = rbEllipse.Checked = rbRectangle.Checked = rbSix.Checked = rbTriangle.Checked = false;
            }
        }

        private void pbPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                CurFigure.X2 = e.X;
                CurFigure.Y2 = e.Y;
                
                tempDrawing.Clear(pbPage.BackColor);
                CurFigure.DrawFigure(tempDrawing, pen);
                tempDrawing.DrawImage(image, 0, 0);
            }
        }

        private void pbPage_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) &&
                (rbLine.Checked || rbEllipse.Checked
                || rbRectangle.Checked || rbSix.Checked || rbTriangle.Checked))
            {
                CurFigure.X1 = e.X;
                CurFigure.Y1 = e.Y;
                IsMouseDown = true;
                
            }
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            serializer.Serialize(FileName, figuresList.ListOfFigures);
        }

        private void DrawAllShapesButton_Click(object sender, EventArgs e)
        {
            serializer.Deserialize(FileName, tempDrawing, permanentDrawing, pen, out figuresList.ListOfFigures);
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Line();
        }
    }
}
