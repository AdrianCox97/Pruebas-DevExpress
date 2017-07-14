using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CeramicaCarrillo.Model
{
    public class ArchivosLocales
    {
        OpenFileDialog abrirDialog;
        SaveFileDialog guardarDialog;

        public ArchivosLocales()
        {
            abrirDialog = new OpenFileDialog();
            guardarDialog = new SaveFileDialog();
        }

        public void buscarImagen(TextBox nombreImagen, PictureBox imagen)
        {
            abrirDialog.Filter = "Tipo imagen|*.jpg;*.jpeg;*.png";
            abrirDialog.Title = "Buscar imagen";
            abrirDialog.Multiselect = false;
            if (abrirDialog.ShowDialog() == DialogResult.OK)
            {
                nombreImagen.Text = abrirDialog.FileName;
                imagen.Image = Image.FromFile(nombreImagen.Text);
            }
        }

        public Byte[] arregloFoto(PictureBox imagen)
        {
           using (var ms = new MemoryStream())
            {
                imagen.Image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public void recuperarImagen(Byte[] byteArray, PictureBox imagen)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArray, 0, byteArray.Length);
                ms.Write(byteArray, 0, byteArray.Length);
                imagen.Image = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
        }

        public void Numeros(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public void Letras(object sender, KeyPressEventArgs e)
        {
            String txtName = ((TextBox)sender).Name;

            switch (txtName)
            {
                case "txtNombres":
                case "txtApellidos":
                    if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (Char)Keys.Space && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;

                case "txtPuesto":
                    if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (Char)Keys.Space && e.KeyChar != (Char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        public DialogResult Mensajes(Char Accion, String Informacion)
        {
            DialogResult Mensaje;
            String MSG = "Ha ocurrido un error inesperado.\r" +
                         "     Esto se puede ocacionar por una falta de conexión a la red." +
                         "     Compruebe que esté conectado a la red.\r\r\r" +
                         "Si el problema persiste pongase en contacto con el proveedor del sistema.";
            MessageBoxButtons Botones = MessageBoxButtons.OK;
            MessageBoxIcon Icono = MessageBoxIcon.Information;

            switch (Accion)
            {
                case 'A':
                    MSG = Informacion + " al reportar la anomalía.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Information;
                    break;
                case 'B':
                    MSG = Informacion + " al registrar la compra.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Information;
                    break;
                case 'S':
                    MSG = Informacion + " al guardar los datos.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Information;
                    break;
                case 'U':
                    MSG = Informacion + " al editar el registro.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Information;
                    break;
                case 'D':
                    MSG = Informacion + " al eliminar el registro.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Information;
                    break;
                case 'C':
                    MSG = "Se descartaran los cambios realizados ¿Desea continuar?";
                    Botones = MessageBoxButtons.YesNo;
                    Icono = MessageBoxIcon.Question;
                    break;
                case 'X':
                    MSG = "Se eliminará el registro seleccionado ¿Desea continuar?";
                    Botones = MessageBoxButtons.YesNo;
                    Icono = MessageBoxIcon.Warning;
                    break;
                case '<':
                    MSG = "Se cerrará la sesión actual, ¿Desea continuar?";
                    Botones = MessageBoxButtons.YesNo;
                    Icono = MessageBoxIcon.Question;
                    break;
                default:
                    MSG = "Ha ocurrido un error inesperado.\r" +
                          "     Esto se puede ocacionar por una falta de conexión a la red." +
                          "     Compruebe que esté conectado a la red.\r\r\r" +
                          "Si el problema persiste pongase en contacto con el proveedor del sistema.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Warning;
                    break;
            }

            //Mensaje = MessageBox.Show(MSG, "Información", Botones, Icono);
            Mensaje = DevExpress.XtraEditors.XtraMessageBox.Show(MSG, "Información", Botones, Icono);

            return Mensaje;
        }
    }
}