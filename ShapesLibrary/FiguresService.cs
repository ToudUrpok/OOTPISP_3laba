using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    static public class FiguresService
    {
        static public Figure CurFigure; 
        static public void DrawAllFigures(Dictionary<int, object> dictionary, ref int curFigureIndex, ref Graphics tempDrawing, ref Graphics permanentDrawing, Pen pen, out Dictionary<int, string> figuresNamesDictionary)
        {
            curFigureIndex = 0;
            figuresNamesDictionary = new Dictionary<int, string>(); 
            foreach (Figure tempFigure in dictionary.Values)
            {
                figuresNamesDictionary.Add(curFigureIndex, tempFigure.name);
                curFigureIndex++;
                tempFigure.DrawFigure(tempDrawing, pen);
                tempFigure.DrawFigure(permanentDrawing, pen);
            }
        }

        public static void SetValue(object value)
        {
            CurFigure = (Figure)value;
        }
    }
}
