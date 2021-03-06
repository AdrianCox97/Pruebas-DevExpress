﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPruebasDev.GUI
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        Model.BDPruebasDev1Entities bdPruebas = new Model.BDPruebasDev1Entities();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumnos.bdPruebas = bdPruebas;

            frmAlumnos frm = new frmAlumnos();

            frm.ShowDialog();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            frmGrupos.bdPruebas = bdPruebas;

            frmGrupos frm = new frmGrupos();

            frm.ShowDialog();
        }

        private void btnCarreras_Click(object sender, EventArgs e)
        {
            frmCarreras.bdPruebas = bdPruebas;

            frmCarreras frm = new frmCarreras();

            frm.ShowDialog();
        }

        private void btnDivisiones_Click(object sender, EventArgs e)
        {
            frmDivisiones.bdPruebas = bdPruebas;

            frmDivisiones frm = new frmDivisiones();

            frm.ShowDialog();
        }
    }
}