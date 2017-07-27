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
using DevExpress.XtraGrid.Views.Grid;
using System.Data.Entity;

namespace CeramicaCarrillo.GUI.Ventas
{
    public partial class frmXtraUCRegistroVentas : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCRegistroVentas()
        {
            InitializeComponent();
        }

        private void frmXtraUCRegistroV_Load(object sender, EventArgs e)
        {
            folioTableAdapter.Fill(dsPrueba1.Folio);
            detalleTableAdapter1.Fill(dsPrueba1.Detalle);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            VerReporte();
        }

        private void VerReporte()
        {
            DevExpress.XtraReports.UI.ReportPrintTool Imprimir = new
                DevExpress.XtraReports.UI.ReportPrintTool(new frmXtraReporteVentas());

            Imprimir.ShowRibbonPreviewDialog();
        }
    }
}