using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesLibrary;

namespace WindowsFormsAppGraphicsEditor
{
    [Serializable]
    public class FiguresList
    {
        public Dictionary<int, object> ListOfFigures;

        public FiguresList()
        {
            ListOfFigures = new Dictionary<int, object>();
        }
    }
}
