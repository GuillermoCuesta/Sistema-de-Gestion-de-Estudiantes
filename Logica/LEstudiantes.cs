using Data;
using LinqToDB;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Logica
{
    public class LEstudiantes : Conexion

    {
        private List<TextBox> listTextBox;
        private List<Label> listLabels;
        private string[] labels = { "ID", "NOMBRE", "APELLDIO", "EMAIL" };
        private PictureBox image;

        private Library libreria;

        public LEstudiantes(List<TextBox> listTextBox, List<Label> listLabels, object[] objectos)
        {
            this.listTextBox = listTextBox;
            this.listLabels = listLabels;
            image = (PictureBox)objectos[0];
            libreria = new Library();

        }

        public void Registar()
        {

            for (int i = 0; i < listLabels.Count; i++)
            {
                if (listTextBox[i].Text.Equals(""))
                {
                    listLabels[i].Text = $"{labels[i]} *campo obligatorio";
                    listLabels[i].ForeColor = Color.Red;
                    listLabels[i].Focus();
                }
            }
            if (listTextBox[3].Text != "")
            {
                if (libreria.textBoxEvent.comprobarFormatoEmail(listTextBox[3].Text))
                {

                }
                else
                {
                    listLabels[3].Text = $"{labels[3]} *invalido";
                    listLabels[3].ForeColor = Color.Red;
                    listLabels[3].Focus();
                }
            }

            var imageArray = libreria.cargarImagen.ImageToByte(image.Image);
            using (var db = new Conexion())
            {
                db.Insert(new Estudiantes()
                {
                    numeroId = Convert.ToInt16(listTextBox[0].Text),
                    nombre = listTextBox[1].Text,
                    apellido = listTextBox[2].Text,
                    email = listTextBox[3].Text

                });
            }


        }
    }
}
