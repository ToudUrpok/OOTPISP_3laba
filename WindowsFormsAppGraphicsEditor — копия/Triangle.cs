using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Triangle : Polygon
    {
        public Triangle () : base(3)
        {
        }
        public void ChangeCoords()
        {
            list_of_vertexes_coords[0].X = X1;
            list_of_vertexes_coords[0].Y = Y2;
            list_of_vertexes_coords[1].X = X2;
            list_of_vertexes_coords[1].Y = Y1;
            list_of_vertexes_coords[2].X = X2;
            list_of_vertexes_coords[2].Y = Y2;
        }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            ChangeCoords();
            page.DrawPolygon(pen, list_of_vertexes_coords);
        }
    }
}
