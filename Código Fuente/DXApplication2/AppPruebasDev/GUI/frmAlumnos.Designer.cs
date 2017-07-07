namespace AppPruebasDev.GUI
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.dtgVistaAlumnosSub1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaAlumnos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bDPruebasDataSet = new AppPruebasDev.BDPruebasDataSet();
            this.cARRERASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARRERASTableAdapter = new AppPruebasDev.BDPruebasDataSetTableAdapters.CARRERASTableAdapter();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colIDCarrera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCarrera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreAlumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.alumnosTableAdapter1 = new AppPruebasDev.BDPruebasDataSetTableAdapters.ALUMNOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaAlumnosSub1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARRERASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVistaAlumnosSub1
            // 
            this.dtgVistaAlumnosSub1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.dtgVistaAlumnosSub1.GridControl = this.dtgVista;
            this.dtgVistaAlumnosSub1.Name = "dtgVistaAlumnosSub1";
            this.dtgVistaAlumnosSub1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "Telefono";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "NombreCarrera";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "GradoGrupo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // dtgVista
            // 
            this.dtgVista.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode3.LevelTemplate = this.dtgVistaAlumnosSub1;
            gridLevelNode3.RelationName = "Level1";
            this.dtgVista.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            this.dtgVista.Location = new System.Drawing.Point(0, 276);
            this.dtgVista.MainView = this.dtgVistaAlumnos;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.Size = new System.Drawing.Size(755, 227);
            this.dtgVista.TabIndex = 18;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaAlumnos,
            this.dtgVistaAlumnosSub1});
            // 
            // dtgVistaAlumnos
            // 
            this.dtgVistaAlumnos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.dtgVistaAlumnos.GridControl = this.dtgVista;
            this.dtgVistaAlumnos.Name = "dtgVistaAlumnos";
            this.dtgVistaAlumnos.OptionsBehavior.Editable = false;
            this.dtgVistaAlumnos.OptionsBehavior.ReadOnly = true;
            this.dtgVistaAlumnos.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.dtgVistaAlumnos.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Matricula";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "NombreCompleto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCarrera,
            this.colNombreCarrera});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cARRERASBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode2.LevelTemplate = this.cardView1;
            gridLevelNode2.RelationName = "RefCARRERAS4";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(755, 270);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // bDPruebasDataSet
            // 
            this.bDPruebasDataSet.DataSetName = "BDPruebasDataSet";
            this.bDPruebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARRERASBindingSource
            // 
            this.cARRERASBindingSource.DataMember = "CARRERAS";
            this.cARRERASBindingSource.DataSource = this.bDPruebasDataSet;
            // 
            // cARRERASTableAdapter
            // 
            this.cARRERASTableAdapter.ClearBeforeFill = true;
            // 
            // cardView1
            // 
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatricula,
            this.colTelefono,
            this.colNombreAlumno,
            this.colApellidoPaterno,
            this.colApellidoMaterno});
            this.cardView1.FocusedCardTopFieldIndex = 0;
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            // 
            // colIDCarrera
            // 
            this.colIDCarrera.Caption = "Clave";
            this.colIDCarrera.FieldName = "IDCarrera";
            this.colIDCarrera.Name = "colIDCarrera";
            this.colIDCarrera.Visible = true;
            this.colIDCarrera.VisibleIndex = 0;
            // 
            // colNombreCarrera
            // 
            this.colNombreCarrera.Caption = "Nombre de la Carrera";
            this.colNombreCarrera.FieldName = "NombreCarrera";
            this.colNombreCarrera.Name = "colNombreCarrera";
            this.colNombreCarrera.Visible = true;
            this.colNombreCarrera.VisibleIndex = 1;
            // 
            // colNombreAlumno
            // 
            this.colNombreAlumno.Caption = "Nombre(s) del Alumno";
            this.colNombreAlumno.FieldName = "NombreAlumno";
            this.colNombreAlumno.Name = "colNombreAlumno";
            this.colNombreAlumno.Visible = true;
            this.colNombreAlumno.VisibleIndex = 0;
            // 
            // colApellidoPaterno
            // 
            this.colApellidoPaterno.Caption = "Apellido Paterno";
            this.colApellidoPaterno.FieldName = "ApellidoPaterno";
            this.colApellidoPaterno.Name = "colApellidoPaterno";
            this.colApellidoPaterno.Visible = true;
            this.colApellidoPaterno.VisibleIndex = 1;
            // 
            // colApellidoMaterno
            // 
            this.colApellidoMaterno.Caption = "Aprellido Materno";
            this.colApellidoMaterno.FieldName = "ApellidoMaterno";
            this.colApellidoMaterno.Name = "colApellidoMaterno";
            this.colApellidoMaterno.Visible = true;
            this.colApellidoMaterno.VisibleIndex = 2;
            // 
            // colMatricula
            // 
            this.colMatricula.Caption = "Matrícula";
            this.colMatricula.FieldName = "Matricula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Visible = true;
            this.colMatricula.VisibleIndex = 3;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "Teléfono";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 4;
            // 
            // alumnosTableAdapter1
            // 
            this.alumnosTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 503);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dtgVista);
            this.Name = "frmAlumnos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaAlumnosSub1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARRERASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaAlumnosSub1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaAlumnos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private BDPruebasDataSet bDPruebasDataSet;
        private System.Windows.Forms.BindingSource cARRERASBindingSource;
        private BDPruebasDataSetTableAdapters.CARRERASTableAdapter cARRERASTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCarrera;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCarrera;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreAlumno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoPaterno;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidoMaterno;
        private BDPruebasDataSetTableAdapters.ALUMNOSTableAdapter alumnosTableAdapter1;
    }
}