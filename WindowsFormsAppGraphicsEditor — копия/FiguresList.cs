using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    public class FiguresList
    {
        public List<Figure> ListOfFigures;

        public FiguresList()
        {
            ListOfFigures = new List<Figure>();
        }
    }
}
