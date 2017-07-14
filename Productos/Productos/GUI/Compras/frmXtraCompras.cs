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

namespace CeramicaCarrillo.GUI.Compras
{
    public partial class frmXtraCompras : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static String strProducto;
        ArchivosLocales oExtras = new ArchivosLocales();
        CeramicaCarrillo.Model.Compras oCompras;
        Boolean boolGuardar = false;

        public frmXtraCompras()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            GuardarCompra();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtValues_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Value = txtUnidades.Value * txtPrecioCompra.Value;
        }

        private void frmXtraCompras_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GuardarCompra()
        {
            try
            {
                bdCarrillo.Compras.Add(RecuperarDatosCompra());
                bdCarrillo.SaveChanges();

                oExtras.Mensajes('B', "Éxito");

                boolGuardar = true;

                this.Close();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('B', "Error");
            }
        }

        private CeramicaCarrillo.Model.Compras RecuperarDatosCompra()
        {
            var DatosProducto = (from tbProducto in bdCarrillo.Productos
                                 where tbProducto.Descripcion == txtDescripcionProducto.Text.Trim()
                                 select tbProducto).ToList().FirstOrDefault();

            if (DatosProducto.IdProductos > 0)
            {
                oCompras = new CeramicaCarrillo.Model.Compras()
                {
                    IdProductos = DatosProducto.IdProductos,
                    Unidades = Convert.ToInt32(txtUnidades.Value),
                    Precio = Convert.ToDouble(txtPrecioCompra.Value),
                    Total = Convert.ToDouble(txtTotal.Value),
                    Fecha = DateTime.Now.Date
                };

                DatosProducto.Unidades += oCompras.Unidades;
            }
            else
            {
                throw new Exception();
            }

            return oCompras;
        }

        private void MostrarInfo()
        {
            txtDescripcionProducto.Text = strProducto;

            AsignarEventos();
        }

        private void AsignarEventos()
        {
            txtUnidades.EditValueChanged += txtValues_EditValueChanged;
            txtPrecioCompra.EditValueChanged += txtValues_EditValueChanged;
        }
    }
}