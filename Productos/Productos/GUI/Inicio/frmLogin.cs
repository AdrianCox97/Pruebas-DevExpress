using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CeramicaCarrillo.Model;
using CeramicaCarrillo.Model.Mensajes;

namespace CeramicaCarrillo.GUI.Inicio
{
    public partial class frmLogin : Form
    {
        BDCarrilloEntities bdCarrillo = new BDCarrilloEntities();
        Sesiones sesion = new Sesiones();
        String strNombreUsuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var Usuario = (from tbUsuarios in bdCarrillo.Personal
                               where tbUsuarios.Usuario == txtUsuario.Text/*"administrador"*/
                                     && tbUsuarios.Contrasena == txtContraseña.Text/*"p0nc14n0"*/
                               select tbUsuarios).FirstOrDefault();

                if (Usuario != null)
                {
                    frmXtraPrincipal.bdCarrillo = bdCarrillo;
                    strNombreUsuario = Usuario.Usuario;

                    sesion.Admin = (Usuario.Puesto.Trim() == "Administrador") ? true : false;
                    sesion.Usuario = strNombreUsuario;
                    sesion.Id = Usuario.IdPersonal;

                    frmXtraPrincipal.sesion = sesion;
                    frmXtraPrincipal frm = new frmXtraPrincipal();
                    new MensajeLogin(sesion.Id);

                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos. Intente de nuevo");
                }
            }
            catch (Exception a) { MessageBox.Show("Error al realizar la operación. Esto se puede ocacionar por una falta de conexión a la red. \rCompruebe que esté conectado a la red. \n" + a.Message); }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}