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

namespace CeramicaCarrillo.GUI.Productos
{
    public partial class frmXtraEdicionProductos : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static String strFormTitulo;
        public static Char chAccion;
        public static Model.Productos oDatosProducto = null;
        public static String CategoriaProducto = null;
        Boolean boolGuardar = false;
        CeramicaCarrillo.Model.Productos oProductos;
        ArchivosLocales oExtras = new ArchivosLocales();

        public frmXtraEdicionProductos()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            switch (chAccion)
            {
                case 'N':
                    GuardarProducto();
                    break;
                case 'U':
                    EditarProducto();
                    break;
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXtraEdicionProductos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GuardarProducto()
        {
            try
            {
                bdCarrillo.Productos.Add(RecuperarDatosProducto());
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

        private void EditarProducto()
        {
            try
            {
                var edicion = bdCarrillo.Productos.Find(Convert.ToInt32(txtIDProducto.Text));

                if (edicion != null)
                {
                    var Producto = RecuperarDatosProducto();

                    edicion.Descripcion = Producto.Descripcion;
                    edicion.PrecioVenta = Producto.PrecioVenta;
                    edicion.PrecioMayoreo = Producto.PrecioMayoreo;
                    edicion.Unidades = Producto.Unidades;
                    edicion.idCategoria = Producto.idCategoria;
                    
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

        private void cbxCargarCategorias()
        {
            cbxCategoria.Properties.Items.Clear();

            cbxCategoria.Properties.Items.Add("Seleccionar");

            var CategoriasTipos = (from tbCategorias in bdCarrillo.Categorias
                                   join tbTipos in bdCarrillo.TipoProductos on tbCategorias.idTipoProducto equals tbTipos.idTipoProducto
                                   select new
                                   {
                                       tbCategorias.NombreCategoria,
                                       tbTipos.NombreTipo
                                   });

            foreach (var CategoriaTipo in CategoriasTipos)
            {
                cbxCategoria.Properties.Items.Add(CategoriaTipo.NombreCategoria.Trim() + "-" + CategoriaTipo.NombreTipo.Trim());
            }

            cbxCategoria.SelectedIndex = 0;
        }

        private Model.Productos RecuperarDatosProducto()
        {
            var IDCategoria = (from tbCategorias in bdCarrillo.Categorias
                               join tbTipos in bdCarrillo.TipoProductos on tbCategorias.idTipoProducto equals tbTipos.idTipoProducto
                               let CategoriaTipo = tbCategorias.NombreCategoria.Trim() + "-" + tbTipos.NombreTipo.Trim()
                               where CategoriaTipo == cbxCategoria.SelectedItem.ToString().Trim()
                               select tbCategorias.idCategoria).ToList().FirstOrDefault();

            if (IDCategoria > 0)
            {
                oProductos = new Model.Productos()
                {
                    Descripcion = txtDescripcion.Text.Trim(),
                    PrecioVenta = Convert.ToDouble(txtPrecioUnitario.Text.Trim()),
                    PrecioMayoreo = Convert.ToDouble(txtPrecioMayoreo.Text.Trim()),
                    Unidades = Convert.ToInt32(txtUnidades.Text.Trim()),
                    Status = true,
                    idCategoria = IDCategoria
                };

                if (txtIDProducto.Text != "")
                {
                    oProductos.IdProductos = Convert.ToInt32(txtIDProducto.Text.Trim());
                }
            }
            else
            {
                throw new Exception();
            }

            return oProductos;
        }

        private void MostrarInfo()
        {
            this.Text = strFormTitulo;

            cbxCargarCategorias();

            if (oDatosProducto != null && CategoriaProducto != null)
            {
                txtIDProducto.Text = oDatosProducto.IdProductos.ToString();
                txtDescripcion.Text = oDatosProducto.Descripcion;
                txtPrecioUnitario.Text = oDatosProducto.PrecioVenta.ToString();
                txtPrecioMayoreo.Text = oDatosProducto.PrecioMayoreo.ToString();
                txtUnidades.Text = oDatosProducto.Unidades.ToString();
                cbxCategoria.SelectedItem = CategoriaProducto;
            }
        }
    }
}