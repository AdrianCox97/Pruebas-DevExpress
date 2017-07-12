using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using AppPruebasDev.Model;

namespace AppPruebasDev.GUI
{
    public partial class frmDivisiones : DevExpress.XtraEditors.XtraForm
    {
        public static BDPruebasDev1Entities bdPruebas = null;
        DIVISIONES oDivisiones;
        General oGeneral = new General();
        
        public frmDivisiones()
        {
            InitializeComponent();
            
            Cargar();
        }

        private void btnNuevaDivision_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardarDivision_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEditarDivision_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnEliminarDivision_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        
        private void dtgVistaDivisiones_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                Int32 IndexFila = e.RowHandle;

                txtIDDivision.Text = dtgVistaDivisiones.GetRowCellValue(IndexFila, IDDivision).ToString().Trim();
                txtNombreDivision.Text = dtgVistaDivisiones.GetRowCellValue(IndexFila, NombreDivision).ToString().Trim();

                OffBotonesEdicion(false);
            }
            catch (Exception f)
            {
                oGeneral.Mensajes('X', "");
            }
        }

        private void Cargar()
        {
            txtIDDivision.Properties.ReadOnly = true;

            Nuevo();
            VistaDatos();
        }

        private void Nuevo()
        {
            txtIDDivision.ResetText();
            txtNombreDivision.ResetText();

            OffBotonesEdicion(true);
        }

        private void Guardar()
        {
            try
            {
                bdPruebas.DIVISIONES.Add(GetDatos());
                bdPruebas.SaveChanges();

                oGeneral.Mensajes('S', "Éxito");

                Nuevo();
                VistaDatos();
            }
            catch(Exception f)
            {
                oGeneral.Mensajes('S', "Error");
            }
        }

        private void Editar()
        {
            try
            {
                Int32 IDDivision = Convert.ToInt32(txtIDDivision.Text.Trim());

                var Consulta = bdPruebas.DIVISIONES.Find(IDDivision);

                var Division = GetDatos();

                Consulta.NombreDivision = Division.NombreDivision;
                bdPruebas.SaveChanges();

                oGeneral.Mensajes('U', "Éxito");

                Nuevo();
                VistaDatos();
                OffBotonesEdicion(true);
            }
            catch(Exception f)
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
                    Int32 IDDivision = Convert.ToInt32(txtIDDivision.Text);

                    var Consulta = bdPruebas.DIVISIONES.Find(IDDivision);

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

        private DIVISIONES GetDatos()
        {
            oDivisiones = new DIVISIONES
            {
                NombreDivision = txtNombreDivision.Text.Trim(),
                Status = true
            };

            oDivisiones.IDDivision = txtIDDivision.Text != "" ? Convert.ToInt32(txtIDDivision.Text) : 0;

            return oDivisiones;
        }

        private void VistaDatos()
        {
            dtgVista.DataSource = bdPruebas.VISTADIVISIONES.ToList();
        }

        private void OffBotonesEdicion(Boolean Valor)
        {
            switch (Valor)
            {
                case true:
                    btnGuardarDivision.Enabled = true;
                    btnEditarDivision.Enabled = false;
                    btnEliminarDivision.Enabled = false;
                    break;
                case false:
                    btnGuardarDivision.Enabled = false;
                    btnEditarDivision.Enabled = true;
                    btnEliminarDivision.Enabled = true;
                    break;
            }
        }
    }
}