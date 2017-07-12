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

namespace AppPruebasDev.GUI
{
    public partial class frmGrupos : DevExpress.XtraEditors.XtraForm
    {
        public static BDPruebasDev1Entities bdPruebas = null;
        GRUPOS oGrupos;
        General oGeneral = new General();

        public frmGrupos()
        {
            InitializeComponent();

            Cargar();
        }

        private void btnNuevoGrupo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEditarGrupo_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminarGrupo_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dtgVistaGrupos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Int32 IndexFila = e.RowHandle;

                txtIDGrupo.Text = dtgVistaGrupos.GetRowCellValue(IndexFila, IDGrupo).ToString().Trim();
                txtCuatrimestre.Text = dtgVistaGrupos.GetRowCellValue(IndexFila, Cuatrimestre).ToString().Trim();
                txtGrupo.Text = dtgVistaGrupos.GetRowCellValue(IndexFila, Grupo).ToString().Trim();

                OffBotonesEdicion(false);
            }
            catch (Exception f)
            {
                oGeneral.Mensajes('X', "");
            }
        }

        private void Cargar()
        {
            txtIDGrupo.Properties.ReadOnly = true;

            Nuevo();
            VistaDatos();
        }

        private void Nuevo()
        {
            txtIDGrupo.ResetText();
            txtCuatrimestre.ResetText();
            txtGrupo.ResetText();

            OffBotonesEdicion(true);
        }

        private void Guardar()
        {
            try
            {
                bdPruebas.GRUPOS.Add(GetDatos());
                bdPruebas.SaveChanges();

                oGeneral.Mensajes('S', "Éxito");

                Nuevo();
                VistaDatos();
            }
            catch (Exception f)
            {
                oGeneral.Mensajes('S', "Error");
            }
        }

        private void Editar()
        {
            try
            {
                Int32 IDGrupo = Convert.ToInt32(txtIDGrupo.Text.Trim());

                var Consulta = bdPruebas.GRUPOS.Find(IDGrupo);

                var Grupo = GetDatos();

                Consulta.Cuatrimestre = Grupo.Cuatrimestre;
                Consulta.Grupo = Grupo.Grupo;
                bdPruebas.SaveChanges();

                oGeneral.Mensajes('U', "Éxito");

                Nuevo();
                VistaDatos();
                OffBotonesEdicion(true);
            }
            catch (Exception f)
            {
                oGeneral.Mensajes('U', "Error");
            }
        }

        private void Eliminar()
        {
            try
            {
                if (oGeneral.Mensajes('d', "") == DialogResult.Yes)
                {
                    Int32 IDGrupo = Convert.ToInt32(txtIDGrupo.Text);

                    var Consulta = bdPruebas.GRUPOS.Find(IDGrupo);

                    Consulta.Status = false;

                    bdPruebas.SaveChanges();

                    oGeneral.Mensajes('D', "Éxito");

                    Nuevo();
                    VistaDatos();
                    OffBotonesEdicion(true);
                }
            }
            catch
            {
                oGeneral.Mensajes('D', "Error");
            }
        }

        private GRUPOS GetDatos()
        {
            oGrupos = new GRUPOS
            {
                Cuatrimestre = txtCuatrimestre.Text.Trim(),
                Grupo = txtGrupo.Text.Trim(),
                Status = true
            };

            oGrupos.IDGrupo = txtIDGrupo.Text != "" ? Convert.ToInt32(txtIDGrupo.Text) : 0;

            return oGrupos;
        }

        private void VistaDatos()
        {
            dtgVista.DataSource = bdPruebas.VISTAGRUPOS.ToList();
        }

        private void OffBotonesEdicion(Boolean Valor)
        {
            switch (Valor)
            {
                case true:
                    btnGuardarGrupo.Enabled = true;
                    btnEditarGrupo.Enabled = false;
                    btnEliminarGrupo.Enabled = false;
                    break;
                case false:
                    btnGuardarGrupo.Enabled = false;
                    btnEditarGrupo.Enabled = true;
                    btnEliminarGrupo.Enabled = true;
                    break;
            }
        }
    }
}