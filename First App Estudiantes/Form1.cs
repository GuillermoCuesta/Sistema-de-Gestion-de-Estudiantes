using Logica;
using Logica.Libreria;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace First_App_Estudiantes
{
    public partial class Form1 : Form
    {

        private LEstudiantes estudiante;
        private Library libreria;
        public Form1()
        {
            InitializeComponent();

            libreria = new Library();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxId);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxEmail);

            var listLabels = new List<Label>();
            listLabels.Add(labelId);
            listLabels.Add(labelNombre);
            listLabels.Add(labelApellido);
            listLabels.Add(labelEmail);

            Object[] objectos = { pictureBoxImagen };

            estudiante = new LEstudiantes(listTextBox, listLabels, objectos);
        }


        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {
            libreria.cargarImagen.LoadImage(pictureBoxImagen);
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Equals(""))
            {
                labelId.ForeColor = Color.Red;
            }
            else
            {
                labelId.ForeColor = Color.Green;
                labelId.Text = "ID";
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textBoxEvent.numKeyPress(e);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.Red;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "NOMBRE";
            }

        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.Red;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "APELLIDO";
            }

        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            libreria.textBoxEvent.textKeyPress(e);

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.Red;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "EMAIL";
            }

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            estudiante.Registar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
