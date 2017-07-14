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

namespace CeramicaCarrillo.GUI.Apartado
{
    public partial class frmXtraUCSistemaA : DevExpress.XtraEditors.XtraUserControl
    {
        Model.ArchivosLocales al = new Model.ArchivosLocales();
        public frmXtraUCSistemaA()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                folioApartadoTableAdapter.Fill(dsSisApartado.FolioApartado);
                abonosApartadoTableAdapter1.Fill(dsSisApartado.AbonosApartado);
                productosApartadoTableAdapter1.Fill(dsSisApartado.ProductosApartado);
            }
            catch (Exception e) { al.Mensajes(' ',""); }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            VerReporte();
        }

        private void VerReporte()
        {
            frmXtraReporteApartado frm = new frmXtraReporteApartado();
            using (DevExpress.XtraReports.UI.ReportPrintTool imprimir = new DevExpress.XtraReports.UI.ReportPrintTool(frm))
            {
                imprimir.ShowRibbonPreviewDialog();
            }
            
        }
    }
}
