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

namespace CeramicaCarrillo.GUI.TiposCategorias
{
    public partial class frmXtraEdicionCategorias : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static String strNombreTipo;
        public static Boolean boolAdministrador;
        ArchivosLocales oExtras = new ArchivosLocales();
        Categorias oCategorias;

        public frmXtraEdicionCategorias()
        {
            InitializeComponent();

            CargarInfo();
        }

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            NuevaCategoria();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            EditarCategoria();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            EliminarCategoria();
        }

        private void dtgVistaCategorias_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Int32 IndexFila = e.RowHandle;

                txtIDCategoria.Text = dtgVistaCategorias.GetRowCellValue(IndexFila, idCategoria).ToString().Trim();
                txtNombreCategoria.Text = dtgVistaCategorias.GetRowCellValue(IndexFila, NombreCategoria).ToString().Trim();

                OffBotonesEdicion(false);
            }
            catch (Exception f)
            {
                oExtras.Mensajes('*', "");
            }
        }

        private void NuevaCategoria()
        {
            txtIDCategoria.Text = "";
            txtNombreCategoria.Text = "";

            OffBotonesEdicion(true);
        }

        private void GuardarCategoria()
        {
            try
            {
                bdCarrillo.Categorias.Add(RecuperarDatosCategoria());
                bdCarrillo.SaveChanges();

                oExtras.Mensajes('S', "Éxito");

                NuevaCategoria();
                VistaDatos();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('S', "Error");
            }
        }

        private void EditarCategoria()
        {
            try
            {
                Int32 IDCategoria = Convert.ToInt32(txtIDCategoria.Text.Trim());

                var edicion = bdCarrillo.Categorias.Find(IDCategoria);

                var DatosCategoria = RecuperarDatosCategoria();

                edicion.NombreCategoria = DatosCategoria.NombreCategoria;
                edicion.idTipoProducto = DatosCategoria.idTipoProducto;

                bdCarrillo.SaveChanges();

                oExtras.Mensajes('U', "Éxito");

                NuevaCategoria();
                VistaDatos();
                OffBotonesEdicion(true);
            }
            catch (Exception f)
            {
                oExtras.Mensajes('U', "Error");
            }
        }

        private void EliminarCategoria()
        {
            try
            {
                if (oExtras.Mensajes('X', "") == DialogResult.Yes)
                {
                    Int32 IDCategoria = Convert.ToInt32(txtIDCategoria.Text);

                    var edicion = bdCarrillo.Categorias.Find(IDCategoria);

                    bdCarrillo.Categorias.Remove(edicion);
                    bdCarrillo.SaveChanges();

                    oExtras.Mensajes('D', "Éxito");

                    NuevaCategoria();
                    VistaDatos();
                    OffBotonesEdicion(true);
                }
            }
            catch (Exception f)
            {
                oExtras.Mensajes('D', "Error");
            }
        }

        private Categorias RecuperarDatosCategoria()
        {
            var IDTipo = (from tbTipos in bdCarrillo.TipoProductos
                          where tbTipos.NombreTipo == txtNombreTipo.Text.Trim()
                          select tbTipos.idTipoProducto).ToList().FirstOrDefault();

            if (IDTipo > 0)
            {
                oCategorias = new Categorias()
                {
                    NombreCategoria = txtNombreCategoria.Text.Trim(),
                    idTipoProducto = IDTipo
                };

                if (txtIDCategoria.Text != "")
                {
                    oCategorias.idCategoria = Convert.ToInt32(txtIDCategoria.Text);
                }
            }
            else
            {
                throw new Exception();
            }

            return oCategorias;
        }

        private void VistaDatos()
        {
            txtNombreTipo.Text = strNombreTipo;

            try
            {
                var IDTipo = (from tbTipo in bdCarrillo.TipoProductos
                              where tbTipo.NombreTipo == strNombreTipo
                              select tbTipo.idTipoProducto).ToList().FirstOrDefault();

                dtgVista.DataSource = (from tbCategorias in bdCarrillo.Categorias
                                       where tbCategorias.idTipoProducto == IDTipo
                                       select tbCategorias).ToList();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('*', "");
            }
        }

        private void OffBotonesEdicion(Boolean Valor)
        {
            switch (Valor)
            {
                case true:
                    btnGuardarCategoria.Enabled = true;
                    btnEditarCategoria.Enabled = false;
                    btnEliminarCategoria.Enabled = false;
                    break;
                case false:
                    btnGuardarCategoria.Enabled = false;
                    btnEditarCategoria.Enabled = true;
                    btnEliminarCategoria.Enabled = true;
                    break;
            }
        }

        private void CargarInfo()
        {
            OffBotonesEdicion(true);
            NuevaCategoria();
            VistaDatos();
        }
    }
}