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

namespace CeramicaCarrillo.GUI.Anomalias
{
    public partial class frmXtraAnomalias : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities bdCarrillo = null;
        public static String strUsuario;
        public static String strProducto;
        ArchivosLocales oExtras = new ArchivosLocales();
        CeramicaCarrillo.Model.Anomalias oAnomalias;
        Boolean boolGuardar = false;

        public frmXtraAnomalias()
        {
            InitializeComponent();

            MostrarInfo();
        }

        private void btnReportarAnomalia_Click(object sender, EventArgs e)
        {
            ReportarAnomalia();
        }

        private void btnCancelarAnomalia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXtraAnomalias_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ReportarAnomalia()
        {
            try
            {
                bdCarrillo.Anomalias.Add(RecuperarDatosCompra());
                bdCarrillo.SaveChanges();

                oExtras.Mensajes('A', "Éxito");

                boolGuardar = true;

                this.Close();
            }
            catch (Exception f)
            {
                oExtras.Mensajes('A', "Error");
            }
        }

        private CeramicaCarrillo.Model.Anomalias RecuperarDatosCompra()
        {
            var IDProducto = (from tbProducto in bdCarrillo.Productos
                              where tbProducto.Descripcion == txtDescripcionProducto.Text.Trim()
                              select tbProducto.IdProductos).ToList().FirstOrDefault();

            var IDUsuario = (from tbUsuario in bdCarrillo.Personal
                             where tbUsuario.Usuario == txtUsuario.Text.Trim()
                             select tbUsuario.IdPersonal).ToList().FirstOrDefault();

            if (IDProducto > 0 && IDUsuario > 0)
            {
                oAnomalias = new CeramicaCarrillo.Model.Anomalias()
                {
                    Descripcion = txtDescripcionAnomalia.Text.Trim(),
                    Fecha = DateTime.Now.Date,
                    IdPersonal = IDUsuario,
                    IdProductos = IDProducto
                };
            }
            else
            {
                throw new Exception();
            }

            return oAnomalias;
        }

        private void MostrarInfo()
        {
            txtUsuario.Text = strUsuario;
            txtDescripcionProducto.Text = strProducto;
        }
    }
}