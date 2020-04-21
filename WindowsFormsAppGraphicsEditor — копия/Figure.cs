using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    public abstract class Figure
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public Figure()
        {
            X1 = 0;
            Y1 = 0;
            X2 = 0;
            Y2 = 0;
        }
        public abstract void DrawFigure(Graphics page, Pen pen);
    }
}
