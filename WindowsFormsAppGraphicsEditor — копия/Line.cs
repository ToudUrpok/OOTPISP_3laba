using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Line : Figure
    {
        public Line() : base() { }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            page.DrawLine(pen, X1, Y1, X2, Y2);
        }
    }
}
 