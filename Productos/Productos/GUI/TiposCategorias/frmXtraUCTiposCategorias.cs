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
using System.Data.Entity;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.TiposCategorias
{
    public partial class frmXtraUCTiposCategorias : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static Sesiones sesion = null;
        Model.TipoProductos oDatosTipo = null;
        ArchivosLocales oExtras = new ArchivosLocales();

        public frmXtraUCTiposCategorias()
        {
            InitializeComponent();

            VistaDatos();
        }

        private void btnAgregarTipos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEdicion("Agregar Tipo de Producto", 'N');
        }

        private void ItemButtonAccionesTipos_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Int32 IndexFila = dtgVistaTipos.FindRow(dtgVistaTipos.GetFocusedRow());

                switch (e.Button.Tag.ToString())
                {
                    case "EditarTipo":
                        GetDatosEdicion(IndexFila);
                        AbrirFormularioEdicion("Editar Tipo de Producto", 'U');
                        break;
                    case "EliminarTipo":
                        EliminarTipo(IndexFila);
                        break;
                    case "AgregarCategorias":
                        String strNombreTipo = dtgVistaTipos.GetRowCellValue(IndexFila, NombreTipo).ToString().Trim();
                        AbrirFormularioCategorias(strNombreTipo);
                        break;
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('*', "");
            }
        }

        private void GetDatosEdicion(Int32 IndexFila)
        {
            oDatosTipo = new Model.TipoProductos
            {
                idTipoProducto = Convert.ToInt32(dtgVistaTipos.GetRowCellValue(IndexFila, idTipoProducto).ToString().Trim()),
                NombreTipo = dtgVistaTipos.GetRowCellValue(IndexFila, NombreTipo).ToString().Trim()
            };
        }

        private void EliminarTipo(Int32 IndexFila)
        {
            try
            {
                if (oExtras.Mensajes('X', "") == DialogResult.Yes)
                {
                    var eliminar = bdCarrillo.TipoProductos.Find(dtgVistaTipos.GetRowCellValue(IndexFila, idTipoProducto));
                    bdCarrillo.TipoProductos.Remove(eliminar);
                    bdCarrillo.SaveChanges();

                    VistaDatos();
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('D', "Error");
            }
        }

        private void AbrirFormularioEdicion(String strTitulo, Char chAccion)
        {
            frmXtraEdicionTipos.strFormTitulo = strTitulo;
            frmXtraEdicionTipos.chAccion = chAccion;
            frmXtraEdicionTipos.oDatosTipo = oDatosTipo;
            frmXtraEdicionTipos.bdCarrillo = bdCarrillo;
            frmXtraEdicionTipos.boolAdministrador = sesion.Admin;

            frmXtraEdicionTipos frm = new frmXtraEdicionTipos();

            frm.ShowDialog();

            oDatosTipo = null;

            VistaDatos();
        }

        private void AbrirFormularioCategorias(String strNombreTipo)
        {
            frmXtraEdicionCategorias.bdCarrillo = bdCarrillo;
            frmXtraEdicionCategorias.strNombreTipo = strNombreTipo;
            frmXtraEdicionCategorias.boolAdministrador = sesion.Admin;

            frmXtraEdicionCategorias frm = new frmXtraEdicionCategorias();

            frm.ShowDialog();

            VistaDatos();
        }

        private void VistaDatos()
        {
            try
            {
                dtgVista.DataSource = bdCarrillo.TipoProductos.ToList();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('*', "");
            }
        }
    }
}