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
    public partial class frmDivisiones : Form
    {
        public static BDPruebasEntities bdPruebas = null;
        DIVISIONES oDivisiones;
        General d;
        
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

                txtIDDivision.Text = dtgVistaDivisiones.GetRowCellValue(IndexFila, dtgVistaDivisiones.Columns[0]).ToString().Trim();
                txtNombreDivision.Text = dtgVistaDivisiones.GetRowCellValue(IndexFila, dtgVistaDivisiones.Columns[1]).ToString().Trim();

                OffBotones(false);
            }
            catch (Exception f)
            {
                Mensajes('X', "");
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
            txtIDDivision.Text = "";
            txtNombreDivision.Text = "";

            OffBotones(true);
        }

        private void Guardar()
        {
            try
            {
                BD.DIVISIONES.Add(GetDatos());
                BD.SaveChanges();

                Mensajes('S', "Éxito");

                Nuevo();
                VistaDatos();
            }
            catch(Exception f)
            {
                Mensajes('S', "Error");
            }
        }

        private void Editar()
        {
            try
            {
                Int32 IDDivision = Convert.ToInt32(txtIDDivision.Text.Trim());

                var Consulta = BD.DIVISIONES.Find(IDDivision);

                var Division = GetDatos();

                Consulta.NombreDivision = Division.NombreDivision;
                BD.SaveChanges();

                Mensajes('U', "Éxito");

                Nuevo();
                VistaDatos();
                OffBotones(true);
            }
            catch(Exception f)
            {
                Mensajes('U', "Error");
            }
        }

        private void Eliminar()
        {
            try
            {
                Int32 IDDivision = Convert.ToInt32(txtIDDivision.Text);

                var Consulta = BD.DIVISIONES.Find(IDDivision);

                BD.DIVISIONES.Remove(Consulta);
                BD.SaveChanges();

                Mensajes('D', "Éxito");

                Nuevo();
                VistaDatos();
                OffBotones(true);
            }
            catch
            {
                Mensajes('D', "Error");
            }
        }

        private DIVISIONES GetDatos()
        {
            oDivisiones = new DIVISIONES
            {
                NombreDivision = txtNombreDivision.Text.Trim() 
            };

            oDivisiones.IDDivision = txtIDDivision.Text != "" ? Convert.ToInt32(txtIDDivision.Text) : 0;

            return oDivisiones;
        }

        private void VistaDatos()
        {
            dtgVista.DataSource = BD.VistaDivisiones.ToList();
        }

        private void OffBotones(Boolean Valor)
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