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
        public Color color { get; set; }
        public string name { get; set; }
        public Figure(Color c)
        {
            X1 = 0;
            Y1 = 0;
            X2 = 0;
            Y2 = 0;
            color = c;
            name = "Unknown";
        }
        public abstract void DrawFigure(Graphics page, Pen pen);
    }
}
