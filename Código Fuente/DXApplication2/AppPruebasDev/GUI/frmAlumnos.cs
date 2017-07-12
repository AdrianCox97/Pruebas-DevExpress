using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppPruebasDev.Model;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace AppPruebasDev.GUI
{
    public partial class frmAlumnos : DevExpress.XtraEditors.XtraForm
    {
        public static BDPruebasDev1Entities bdPruebas = null;
        CARRERAS oCarreras;
        General oGeneral = new General();

        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}