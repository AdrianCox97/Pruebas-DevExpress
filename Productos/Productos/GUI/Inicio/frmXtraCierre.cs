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

namespace CeramicaCarrillo.GUI.Inicio
{
    public partial class frmXtraCierre : DevExpress.XtraEditors.XtraForm
    {
        Cierre _cierre;

        public frmXtraCierre(object oCierre)
        {
            InitializeComponent();

            _cierre = (Cierre)oCierre;
            _cierre.Accion = 'X';
        }
        
        private void pbxCerrarSesion_Click(object sender, EventArgs e)
        {
            _cierre.Accion = 'S';
            this.Close();
        }

        private void pbxSalirAplicacion_Click(object sender, EventArgs e)
        {
            _cierre.Accion = 'A';
            this.Close();
        }
    }
}