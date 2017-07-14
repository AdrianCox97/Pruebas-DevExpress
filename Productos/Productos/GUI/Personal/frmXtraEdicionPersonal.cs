using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Personal
{
    public partial class frmXtraEdicionPersonal : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static String strFormTitulo;
        public static Char chAccion;
        public static Model.Personal oDatosPersonal = null;
        Boolean boolGuardar = false;
        CeramicaCarrillo.Model.Personal oPersonal;
        ArchivosLocales oExtras = new ArchivosLocales();

        public frmXtraEdicionPersonal()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnGuardarPersonal_Click(object sender, EventArgs e)
        {
            switch (chAccion)
            {
                case 'N':
                    GuardarPersonal();
                    break;
                case 'U':
                    EditarPersonal();
                    break;
            }
        }

        private void btnCancelarPersonal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXtraEdicionPersonal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (boolGuardar == false)
            {
                if (oExtras.Mensajes('C', "") == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                boolGuardar = false;
            }
        }

        private void GuardarPersonal()
        {
            try
            {
                bdCarrillo.Personal.Add(RecuperarDatosPersonal());
                bdCarrillo.SaveChanges();

                oExtras.Mensajes('S', "Éxito");

                boolGuardar = true;

                this.Close();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('S', "Error");
            }
        }

        private void EditarPersonal()
        {
            try
            {
                var edicion = bdCarrillo.Personal.Find(Convert.ToInt32(txtIDPersonal.Text));

                if (edicion != null)
                {
                    var _Personal = RecuperarDatosPersonal();

                    edicion.Nombre = _Personal.Nombre;
                    edicion.Apellido = _Personal.Apellido;
                    edicion.Telefono = _Personal.Telefono;
                    edicion.Movil = _Personal.Movil;
                    edicion.Direccion = _Personal.Direccion;
                    edicion.FechaNacimiento = _Personal.FechaNacimiento;
                    edicion.Puesto = _Personal.Puesto;
                    edicion.Usuario = _Personal.Usuario;
                    edicion.Contrasena = _Personal.Contrasena;

                    bdCarrillo.SaveChanges();

                    oExtras.Mensajes('U', "Éxito");

                    boolGuardar = true;

                    this.Close();
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('U', "Error");
            }
        }

        private Model.Personal RecuperarDatosPersonal()
        {
            oPersonal = new Model.Personal()
            {
                Nombre = txtNombres.Text.Trim(),
                Apellido = txtApellidos.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Movil = txtCelular.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                FechaNacimiento = dtpNacimiento.DateTime.Date,
                Puesto = txtPuesto.Text.Trim(),
                Usuario = txtUsuario.Text.Trim(),
                Contrasena = txtContrasena.Text.Trim()
            };

            if (txtIDPersonal.Text != "")
            {
                oPersonal.IdPersonal = Convert.ToInt32(txtIDPersonal.Text.Trim());
            }


            return oPersonal;
        }

        private void MostrarInfo()
        {
            this.Text = strFormTitulo;

            if (oDatosPersonal != null)
            {
                txtIDPersonal.Text = oDatosPersonal.IdPersonal.ToString();
                txtNombres.Text = oDatosPersonal.Nombre;
                txtApellidos.Text = oDatosPersonal.Apellido;
                txtTelefono.Text = oDatosPersonal.Telefono;
                txtCelular.Text = oDatosPersonal.Movil;
                txtDireccion.Text = oDatosPersonal.Direccion;
                txtPuesto.Text = oDatosPersonal.Puesto;
                txtUsuario.Text = oDatosPersonal.Usuario;
                txtContrasena.Text = oDatosPersonal.Contrasena;

                try
                {
                    dtpNacimiento.DateTime = oDatosPersonal.FechaNacimiento.Value;
                }
                catch
                {
                    dtpNacimiento.DateTime = DateTime.Now.Date;
                }
            }
        }
    }
}