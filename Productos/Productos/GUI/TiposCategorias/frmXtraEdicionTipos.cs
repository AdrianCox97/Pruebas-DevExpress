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
    public partial class frmXtraEdicionTipos : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static String strFormTitulo;
        public static Char chAccion;
        public static Model.TipoProductos oDatosTipo = null;
        public static Boolean boolAdministrador;
        Boolean boolGuardar = false;
        TipoProductos oTiposProducto;
        ArchivosLocales oExtras = new ArchivosLocales();

        public frmXtraEdicionTipos()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            switch (chAccion)
            {
                case 'N':
                    GuardarTipo();
                    break;
                case 'U':
                    EditarTipo();
                    break;
            }
        }

        private void btnCancelarTipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXtraEdicionTipos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GuardarTipo()
        {
            try
            {
                bdCarrillo.TipoProductos.Add(RecuperarDatosTipo());
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

        private void EditarTipo()
        {
            try
            {
                var edicion = bdCarrillo.TipoProductos.Find(Convert.ToInt32(txtIDTipo.Text));

                if (edicion != null)
                {
                    var tipoProducto = RecuperarDatosTipo();
                    edicion.NombreTipo = tipoProducto.NombreTipo;
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

        private TipoProductos RecuperarDatosTipo()
        {
            oTiposProducto = new TipoProductos()
            {
                NombreTipo = txtNombreTipo.Text.Trim()
            };

            if (txtIDTipo.Text != "")
            {
                oTiposProducto.idTipoProducto = Convert.ToInt32(txtIDTipo.Text);
            }

            return oTiposProducto;
        }

        private void MostrarInfo()
        {
            this.Text = strFormTitulo;

            if (oDatosTipo != null)
            {
                txtIDTipo.Text = oDatosTipo.idTipoProducto.ToString();
                txtNombreTipo.Text = oDatosTipo.NombreTipo;
            }
        }
    }
}