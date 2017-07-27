using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Personal
{
    public partial class frmXtraUCPersonal : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static Sesiones sesion = null;
        Model.Personal oDatosPersonal = null;
        ArchivosLocales oExtras = new ArchivosLocales();
        
        public frmXtraUCPersonal()
        {
            InitializeComponent();

            CargarInfo();
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormularioEdicion("Agregar Personal", 'N');
        }

        private void ItemButtonAccionesPeronal_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Int32 IndexFila = dtgVistaPersonal.FindRow(dtgVistaPersonal.GetFocusedRow());

                switch (e.Button.Tag.ToString())
                {
                    case "EditarPersonal":
                        GetDatosEdicion(IndexFila);
                        AbrirFormularioEdicion("Editar Personal", 'U');
                        break;
                    case "EliminarPersonal":
                        EliminarPersonal(IndexFila);
                        break;
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('*', "");
            }
        }

        private void AbrirFormularioEdicion(String strTitulo, Char chAccion)
        {
            frmXtraEdicionPersonal.strFormTitulo = strTitulo;
            frmXtraEdicionPersonal.chAccion = chAccion;
            frmXtraEdicionPersonal.oDatosPersonal = oDatosPersonal;
            frmXtraEdicionPersonal.bdCarrillo = bdCarrillo;

            frmXtraEdicionPersonal frm = new frmXtraEdicionPersonal();

            frm.ShowDialog();

            oDatosPersonal = null;

            VistaDatos();
        }

        private void GetDatosEdicion(Int32 IndexFila)
        {
            var _Datos = bdCarrillo.Personal.Find(Convert.ToInt32(dtgVistaPersonal.GetRowCellValue(IndexFila, IdPersonal).ToString().Trim()));

            oDatosPersonal = new Model.Personal
            {
                IdPersonal = _Datos.IdPersonal,
                Nombre = _Datos.Nombre,
                Apellido = _Datos.Apellido,
                Telefono = _Datos.Telefono,
                Movil = _Datos.Movil,
                Direccion = _Datos.Direccion,
                FechaNacimiento =_Datos.FechaNacimiento,
                Puesto = _Datos.Puesto,
                Usuario = _Datos.Usuario,
                Contrasena = _Datos.Contrasena
            };
        }

        private void EliminarPersonal(Int32 IndexFila)
        {
            try
            {
                if (oExtras.Mensajes('X', "") == DialogResult.Yes)
                {
                    Int32 IDPersonal = Convert.ToInt32(dtgVistaPersonal.GetRowCellValue(IndexFila, IdPersonal).ToString().Trim());

                    var edicion = bdCarrillo.Personal.Find(IDPersonal);

                    if (edicion != null)
                    {
                        edicion.Status = false;

                        bdCarrillo.SaveChanges();

                        oExtras.Mensajes('D', "Éxito");
                    }

                    VistaDatos();
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('D', "Error");
            }
        }

        private void Administrador()
        {
            if (sesion.Admin != true)
            {
                btnAgregarPersonal.Enabled = false;

                Contrasena.Visible = false;

                ItemButtonAccionesPeronal.Buttons[0].Enabled = false;
                ItemButtonAccionesPeronal.Buttons[1].Enabled = false;
            }
        }

        private void VistaDatos()
        {
            dtgVista.DataSource = (from tbPersonal in bdCarrillo.Personal
                                   let NombreCompleto = tbPersonal.Nombre + " " + tbPersonal.Apellido
                                   where tbPersonal.Status == true
                                   select new
                                   {
                                       tbPersonal.IdPersonal,
                                       NombreCompleto,
                                       tbPersonal.Usuario,
                                       tbPersonal.Contrasena,
                                       tbPersonal.Telefono,
                                       tbPersonal.Movil,
                                       tbPersonal.Direccion,
                                       tbPersonal.FechaNacimiento,
                                       tbPersonal.Puesto
                                   }).ToList();
        }

        private void CargarInfo()
        {
            Administrador();
            VistaDatos();
        }
    }
}