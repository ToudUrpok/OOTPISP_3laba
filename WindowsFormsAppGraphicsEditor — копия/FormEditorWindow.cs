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
        public int CurFigureIndex;
        const string FileName = "SerializedObjects.bin";
        public Graphics tempDrawing, permanentDrawing;
        public Serializer serializer;
        Image image;
        public FormEditorWindow()
        {
            InitializeComponent();
            figuresList = new FiguresList();
            CurFigureIndex = 0;
            serializer = new Serializer();
            tempDrawing = pbPage.CreateGraphics();
            image = new Bitmap(pbPage.Width, pbPage.Height);
            permanentDrawing = Graphics.FromImage(image);
            pen = new Pen(Color.Black);
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
            CurFigureIndex = 0;
            lbFigures.Items.Clear();
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Rectangle(colorBox.BackColor);
            CurFigure.name = "Rectangle";
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Triangle(colorBox.BackColor);
            CurFigure.name = "Triangle";
        }

        private void rbEllipse_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Ellipse(colorBox.BackColor);
            CurFigure.name = "Ellipse";
        }

        private void rbSix_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Hexagon(colorBox.BackColor);
            CurFigure.name = "Six";
        }

        private void pbPage_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                figuresList.ListOfFigures.Add(CurFigureIndex, CurFigure);
                lbFigures.Items.Insert(CurFigureIndex, CurFigure.name);
                CurFigureIndex++;
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
            figuresList.ListOfFigures = null;
            CurFigureIndex = 0;
            serializer.Deserialize(FileName, out figuresList.ListOfFigures);
            DrawAllFigures();
        }

        private void DrawAllFigures()
        {
            CurFigureIndex = 0;
            foreach (var tempFigure in figuresList.ListOfFigures.Values)
            {
                lbFigures.Items.Insert(CurFigureIndex, tempFigure.name);
                CurFigureIndex++;
                tempFigure.DrawFigure(tempDrawing, pen);
                tempFigure.DrawFigure(permanentDrawing, pen);
            }
        }

        private void colorBox_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            colorBox.BackColor = colorDialog.Color;
            pen.Color = colorDialog.Color;
            if (CurFigure != null)
                CurFigure.color = colorDialog.Color;
        }

        private void lbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFigures.SelectedIndex != -1)
            {
                CurFigureIndex = lbFigures.SelectedIndex;
                CurFigure = figuresList.ListOfFigures[CurFigureIndex];
                btCorrect.Visible = true;
                btDelete.Visible = true;
                ActivityWithCorrectPanel(false);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            figuresList.ListOfFigures.Remove(CurFigureIndex);
            lbFigures.Items.RemoveAt(CurFigureIndex);
            RemoveElements(CurFigureIndex);
            CurFigureIndex = 0;
            CurFigure = null;
            clearPictureBox();
            DrawAllFigures();
            btCorrect.Visible = false;
            btDelete.Visible = false;
        }

        private void RemoveElements(int index)
        {
            if (lbFigures.Items.Count > index)
            {
                for(int i = index; i < lbFigures.Items.Count; i++)
                {
                    figuresList.ListOfFigures.Add(i, figuresList.ListOfFigures[i+1]);
                    figuresList.ListOfFigures.Remove(i+1);
                }
            }
            lbFigures.Items.Clear();
        }

        private void btCorrect_Click(object sender, EventArgs e)
        {
            tbX1.Text = CurFigure.X1.ToString();
            tbX2.Text = CurFigure.X2.ToString();
            tbY1.Text = CurFigure.Y1.ToString();
            tbY2.Text = CurFigure.Y2.ToString();
            tbName.Text = CurFigure.name;
            pbColor.BackColor = CurFigure.color;
            ActivityWithCorrectPanel(true);
            btCorrect.Visible = false;
            btDelete.Visible = false;
        }

        private void pbColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            pbColor.BackColor = colorDialog.Color;
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            CurFigure.X1 = Int32.Parse(tbX1.Text);
            CurFigure.X2 = Int32.Parse(tbX2.Text);
            CurFigure.Y1 = Int32.Parse(tbY1.Text);
            CurFigure.Y2 = Int32.Parse(tbY2.Text);
            CurFigure.name = tbName.Text;
            CurFigure.color = pbColor.BackColor;
            ActivityWithCorrectPanel(false);
            CurFigure = null;
            CurFigureIndex = 0;
            clearPictureBox();
            lbFigures.Items.Clear();
            DrawAllFigures();
        }

        private void ActivityWithCorrectPanel(bool val)
        {
            lblX1.Visible = tbX1.Visible = lblY1.Visible = tbY1.Visible = lblX2.Visible = tbX2.Visible = lblY2.Visible = tbY2.Visible
            = lblName.Visible = tbName.Visible = lblColor.Visible = pbColor.Visible = btChange.Visible = val;
        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {
            CurFigure = new Line(colorBox.BackColor);
            CurFigure.name = "Line";
        }
    }
}
