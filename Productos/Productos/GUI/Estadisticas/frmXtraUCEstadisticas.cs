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
using DevExpress.XtraCharts;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Estadisticas
{
    public partial class frmXtraUCEstadisticas : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;

        public frmXtraUCEstadisticas()
        {
            InitializeComponent();
            CargarMeses();
        }

        private void CargarMeses()
        {
            comprasEstadisticasTableAdapter1.Fill(dsEstadisticas1.ComprasEstadisticas);
            ventasEstadisticasTableAdapter.Fill(dsEstadisticas.VentasEstadisticas);
        }
        
    }
}
