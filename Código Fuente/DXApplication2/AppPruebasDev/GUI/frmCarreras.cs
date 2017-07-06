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
    public partial class frmCarreras : Form
    {
        public static BDPruebasEntities bdPruebas = null;
        CARRERAS oCarreras;
        General oGeneral = new General();

        public frmCarreras()
        {
            InitializeComponent();

            Cargar();
        }

        private void btnNuevaCarrera_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardarCarrera_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEditarCarrera_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminarCarrera_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void dtgVistaGrupos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Int32 IndexFila = e.RowHandle;

                txtIDCarrera.Text = dtgVistaCarreras.GetRowCellValue(IndexFila, IDCarrera).ToString().Trim();
                txtNombreCarrera.Text = dtgVistaCarreras.GetRowCellValue(IndexFila, NombreCarrera).ToString().Trim();
                cbxDivisionFK.SelectedItem = dtgVistaCarreras.GetRowCellValue(IndexFila, NombreDivision).ToString().Trim();

                OffBotonesEdicion(false);
            }
            catch (Exception f)
            {
                oGeneral.Mensajes('X', "");
            }
        }

        private void Cargar()
        {
            txtIDCarrera.Properties.ReadOnly = true;

            Nuevo();
            VistaDatos();
            LoadDivisiones();
        }

        private void Nuevo()
        {
            txtIDCarrera.ResetText();
            txtNombreCarrera.ResetText();
            cbxDivisionFK.SelectedIndex = 0;

            OffBotonesEdicion(true);
        }

        private void Guardar()
        {
            try
            {
                bdPruebas.CARRERAS.Add(GetDatos());
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
                Int32 IDCarrera = Convert.ToInt32(txtIDCarrera.Text.Trim());

                var Consulta = bdPruebas.CARRERAS.Find(IDCarrera);

                var Carrera = GetDatos();

                Consulta.NombreCarrera = Carrera.NombreCarrera;
                Consulta.IDDivision = Carrera.IDDivision;

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
                    Int32 IDCarrera = Convert.ToInt32(txtIDCarrera.Text);

                    var Consulta = bdPruebas.CARRERAS.Find(IDCarrera);

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

        private CARRERAS GetDatos()
        {
            var IDDivision = (from tbDivisiones in bdPruebas.VistaDivisiones
                              where tbDivisiones.NombreDivision.Trim() == cbxDivisionFK.SelectedItem.ToString().Trim()
                              select tbDivisiones.IDDivision).ToList().FirstOrDefault();

            if (IDDivision > 0)
            {
                oCarreras = new CARRERAS
                {
                    NombreCarrera = txtNombreCarrera.Text.Trim(),
                    IDDivision = IDDivision,
                    Status = true
                };

                oCarreras.IDCarrera = txtIDCarrera.Text != "" ? Convert.ToInt32(txtIDCarrera.Text) : 0;
            }
            else
            {
                throw new Exception();
            }

            return oCarreras;
        }

        private void VistaDatos()
        {
            dtgVista.DataSource = bdPruebas.VistaCarreras.ToList();
        }

        private void LoadDivisiones()
        {
            var Divisiones = bdPruebas.VistaDivisiones.ToList();

            cbxDivisionFK.Properties.Items.Clear();
            cbxDivisionFK.Properties.Items.Add("Seleccionar");

            foreach (var Division in Divisiones)
            {
                cbxDivisionFK.Properties.Items.Add(Division.NombreDivision.Trim());
            }

            cbxDivisionFK.SelectedIndex = 0;
        }

        private void OffBotonesEdicion(Boolean Valor)
        {
            switch (Valor)
            {
                case true:
                    btnGuardarCarrera.Enabled = true;
                    btnEditarCarrera.Enabled = false;
                    btnEliminarCarrera.Enabled = false;
                    break;
                case false:
                    btnGuardarCarrera.Enabled = false;
                    btnEditarCarrera.Enabled = true;
                    btnEliminarCarrera.Enabled = true;
                    break;
            }
        }
    }
}