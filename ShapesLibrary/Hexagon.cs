using System.Drawing;
using System;

namespace ShapesLibrary
{
    [Serializable]
    public class Hexagon : Polygon
    {
        public Hexagon(Color c) : base(6, c)
        {
        }
        public void ChangeCoords()
        {
            list_of_vertexes_coords[0].X = X1;
            list_of_vertexes_coords[0].Y = Y1 + (Y2 - Y1)/3;
            list_of_vertexes_coords[1].X = X1 + (X2 - X1)/2;
            list_of_vertexes_coords[1].Y = Y1;
            list_of_vertexes_coords[2].X = X2;
            list_of_vertexes_coords[2].Y = list_of_vertexes_coords[0].Y;
            list_of_vertexes_coords[3].X = X2;
            list_of_vertexes_coords[3].Y = list_of_vertexes_coords[0].Y + (Y2 - Y1) / 3;
            list_of_vertexes_coords[4].X = list_of_vertexes_coords[1].X;
            list_of_vertexes_coords[4].Y = Y2;
            list_of_vertexes_coords[5].X = X1;
            list_of_vertexes_coords[5].Y = list_of_vertexes_coords[3].Y;
        }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            ChangeCoords();
            pen.Color = color;
            page.DrawPolygon(pen, list_of_vertexes_coords);
        }
    }
}
