using static System.Math;
using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Ellipse : Figure
    {
        public Ellipse() : base() { }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            page.DrawEllipse(pen, X1, Y1, Abs(X2 - X1), Abs(Y2 - Y1));
        }
    }
}
