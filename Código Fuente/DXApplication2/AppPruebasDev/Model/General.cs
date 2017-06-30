using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPruebasDev.Model
{
    public class General
    {
        private DialogResult Mensajes(Char Accion, String Informacion)
        {
            DialogResult Mensaje;
            String MSG = "Ha ocurrido un error inesperado.";
            MessageBoxButtons Botones = MessageBoxButtons.OK;
            MessageBoxIcon Icono = MessageBoxIcon.Information;

            switch (Accion)
            {
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
                default:
                    MSG = "Ha ocurrido un error inesperado.";
                    Botones = MessageBoxButtons.OK;
                    Icono = MessageBoxIcon.Warning;
                    break;
            }

            Mensaje = MessageBox.Show(MSG, "Información", Botones, Icono);

            return Mensaje;
        }
    }
}