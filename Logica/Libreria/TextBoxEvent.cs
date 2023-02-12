using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Solo permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //No permite saltos de linea
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Nos permite usar la tecla Borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Nos permite usar la tecla spacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }


        }

        public void numKeyPress(KeyPressEventArgs e)
        {
            //Solo permite ingresar datos de tipo entero
            if (char.IsNumber(e.KeyChar)) { e.Handled = false; }
            //No permite saltos de linea
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Nos permite usar la tecla Borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Nos permite usar la tecla spacio
            //else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }

        }

        public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
