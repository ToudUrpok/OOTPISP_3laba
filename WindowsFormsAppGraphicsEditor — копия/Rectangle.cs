using static System.Math;
using System.Drawing;
using System;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    class Rectangle : Polygon
    {
        public Rectangle() : base(4)
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
            page.DrawRectangle(pen, list_of_vertexes_coords[0].X, list_of_vertexes_coords[0].Y, Abs(list_of_vertexes_coords[2].X - list_of_vertexes_coords[0].X), Abs(list_of_vertexes_coords[2].Y - list_of_vertexes_coords[0].Y));
        }
    }
}
