using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Polygon : Figure
    {
        public Point[] list_of_vertexes_coords;
        public Polygon(int num) : base()
        {
            list_of_vertexes_coords = new Point[num];
            for ( int i = 0; i < num; i++ )
            {
                list_of_vertexes_coords[i] = new Point(0, 0);
            }
        }
        
        public override void DrawFigure(Graphics page, Pen pen)
        {
            page.DrawPolygon(pen, list_of_vertexes_coords);
        }
    }
}
