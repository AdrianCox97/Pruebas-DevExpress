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

namespace CeramicaCarrillo.GUI.Compras
{
    public partial class frmXtraUCRegistroC : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCRegistroC()
        {
            InitializeComponent();
        }

        private void frmXtraUCRegistroC_Load(object sender, EventArgs e)
        {
            comprasTableAdapter.Fill(dsRegCompras.Compras);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            VerReporte();
        }

        private void VerReporte()
        {
            frmXtraReporteCompras frm = new frmXtraReporteCompras();

            DevExpress.XtraReports.UI.ReportPrintTool Imprimir = new DevExpress.XtraReports.UI.ReportPrintTool(frm);
            Imprimir.ShowRibbonPreviewDialog();
        }
    }
}