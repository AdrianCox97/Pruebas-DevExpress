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
    public partial class frmAlumnos : Form
    {
        public static BDPruebasEntities bdPruebas = null;
        //CARRERAS oCarreras;
        //General oGeneral = new General();

        public frmAlumnos()
        {
            InitializeComponent();

            dtg();

            //gridControl1.DataSource = bdPruebas.ALUMNOS.ToList();

            //gridControl1.DataSource = bdPruebas.ALUMNOS.Include("CARRERAS").ToList();
            //gridView1.MasterRowEmpty += GridView1_MasterRowEmpty;
            //gridView1.MasterRowGetRelationCount += GridView1_MasterRowGetRelationCount;
            //gridView1.MasterRowGetRelationName += GridView1_MasterRowGetRelationName;
            //gridView1.MasterRowGetChildList += GridView1_MasterRowGetChildList;

            


            //gridView1.MasterRowEmpty += GridView1_MasterRowEmpty;
            //gridView1.MasterRowGetRelationCount += GridView1_MasterRowGetRelationCount;
            //gridView1.MasterRowGetRelationName += GridView1_MasterRowGetRelationName;
            //gridView1.MasterRowGetChildList += GridView1_MasterRowGetChildList;
        }

        private void GridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            ALUMNOS c = (ALUMNOS)gridView1.GetRow(e.RowHandle);
            e.ChildList = new BindingSource(c, "CARRERAS");
        }

        private void GridView1_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "CARRERAS";
        }

        private void GridView1_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void GridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            ALUMNOS c = (ALUMNOS)gridView1.GetRow(e.RowHandle);
            //e.IsEmpty = c.CARRERAS.Count == 0;
        }

        private void dtg()
        {
            //dtgVista.DataSource = bdPruebas.VistaAlumnos.ToList();
            //DevExpress.XtraGrid.GridLevelTree dfdf = new DevExpress.XtraGrid.GridLevelTree(dtgVista);
            //dtgVista.LevelTree.Nodes.Add()

            //DataSet dsDetail = new DataSet();
            //DataTable dtA = new DataTable();
            //DataTable dtAS = new DataTable();

            //dtA.Columns.Add("Matricula", typeof(String));
            //dtA.Columns.Add("NombreCompleto", typeof(String));

            //dtA = bdPruebas.ALUMNOS.ToList();

            //dsDetail.Tables.Add("Alumnos");
            //dsDetail.Tables.Add("AlumnosSub1");

            //dsDetail.Tables["Alumnos"].Columns.Add("Matricula", typeof(String));
            //dsDetail.Tables["Alumnos"].Columns.Add("NombreCompleto", typeof(String));

            //dsDetail.Tables["AlumnosSub1"].Columns.Add("Telefono", typeof(String));
            //dsDetail.Tables["AlumnosSub1"].Columns.Add("NombreCarrera", typeof(String));
            //dsDetail.Tables["AlumnosSub1"].Columns.Add("GradoGrupo", typeof(String));

            //dsDetail.Tables[0]. = bdPruebas.VistaAlumnos.ToList();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPruebasDataSet.CARRERAS' table. You can move, or remove it, as needed.
            this.cARRERASTableAdapter.Fill(this.bDPruebasDataSet.CARRERAS);
            this.alumnosTableAdapter1.Fill(this.bDPruebasDataSet.ALUMNOS);
        }
    }
}