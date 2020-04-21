using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static WindowsFormsAppGraphicsEditor.FormEditorWindow;

namespace WindowsFormsAppGraphicsEditor
{
    public class Serializer
    {
        public BinaryFormatter formatter;

        public Serializer()
        {
            formatter = new BinaryFormatter();
        }
        public void Serialize(string file, List<Figure> ListOfFigures)
        {

            using (FileStream FileToSerialize = new FileStream(file, FileMode.OpenOrCreate))
            {

                try
                {
                    formatter.Serialize(FileToSerialize, ListOfFigures);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
}

        public void Deserialize(string file, Graphics tempDrawing, Graphics permanentDrawing, Pen pen, out List<Figure> ListOfFigures)
        {
            try
            {
                using (FileStream FileToDeserialize = new FileStream(file, FileMode.Open))
                {
                    ListOfFigures = (List<Figure>)formatter.Deserialize(FileToDeserialize);
                    foreach (var tempFigure in ListOfFigures)
                    {
                        tempFigure.DrawFigure(tempDrawing, pen);
                        tempFigure.DrawFigure(permanentDrawing, pen);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки");
                ListOfFigures = new List<Figure>();
            }
        }
    }
}
