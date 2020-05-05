using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Line : Figure
    {
        public Line(Color c) : base(c) { }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            pen.Color = color;
            page.DrawLine(pen, X1, Y1, X2, Y2);
        }
    }
}
 