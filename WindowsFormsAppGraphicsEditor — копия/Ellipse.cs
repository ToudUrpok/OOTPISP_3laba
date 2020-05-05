using static System.Math;
using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Ellipse : Figure
    {
        public Ellipse(Color c) : base(c) { }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            pen.Color = color;
            page.DrawEllipse(pen, X1, Y1, Abs(X2 - X1), Abs(Y2 - Y1));
        }
    }
}
