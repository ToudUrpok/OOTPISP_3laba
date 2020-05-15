using static System.Math;
using System.Drawing;
using System;

namespace ShapesLibrary
{
    [Serializable]
    public class Rectangle : Polygon
    {
        public Rectangle(Color c) : base(4, c)
        {
        }
        public void ChangeCoords()
        {
            list_of_vertexes_coords[0].X = X1;
            list_of_vertexes_coords[0].Y = Y1;
            list_of_vertexes_coords[1].X = X2;
            list_of_vertexes_coords[1].Y = Y1;
            list_of_vertexes_coords[2].X = X2;
            list_of_vertexes_coords[2].Y = Y2;
            list_of_vertexes_coords[3].X = X1;
            list_of_vertexes_coords[3].Y = Y2;
        }
        public override void DrawFigure(Graphics page, Pen pen)
        {
            ChangeCoords();
            pen.Color = color;
            page.DrawRectangle(pen, list_of_vertexes_coords[0].X, list_of_vertexes_coords[0].Y, Abs(list_of_vertexes_coords[2].X - list_of_vertexes_coords[0].X), Abs(list_of_vertexes_coords[2].Y - list_of_vertexes_coords[0].Y));
        }
    }
}
