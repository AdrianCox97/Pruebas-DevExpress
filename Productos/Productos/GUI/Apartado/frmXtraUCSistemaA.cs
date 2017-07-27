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

namespace CeramicaCarrillo.GUI.Apartado
{
    public partial class frmXtraUCSistemaA : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;
        ArchivosLocales oExtras = new ArchivosLocales();
        Folio oFolio;

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
            catch (Exception e) { oExtras.Mensajes(' ',""); }
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

        private void ItemButtonApartados_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                Int32 IndexFila = gridView1.FindRow(gridView1.GetFocusedRow());

                switch (e.Button.Tag.ToString())
                {
                    case "AbonarApartado":
                        GetDatosEdicion(IndexFila);
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
            oFolio = new Folio
            {
                IdFolio = Convert.ToInt32(gridView1.GetRowCellValue(IndexFila, colIdFolio).ToString().Trim())
            };
            Ventas.frmXtraCobroA._idFolio = oFolio.IdFolio;
            Ventas.frmXtraCobroA.datos = datos;

            Ventas.frmXtraCobroA frmAbono = new Ventas.frmXtraCobroA();
            if (frmAbono.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

    }
}
