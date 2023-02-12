using System.Drawing;
using System.Windows.Forms;

namespace Logica.Libreria
{
    public class CargarImagen
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void LoadImage(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg; *.gif; *.png; *.bmp";
            fd.ShowDialog();

            if (fd.FileName != string.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
