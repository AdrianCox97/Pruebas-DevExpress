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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colMatricula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreAlumno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoPaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidoMaterno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cARRERASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPruebasDataSet = new AppPruebasDev.BDPruebasDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCarrera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCarrera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cARRERASTableAdapter = new AppPruebasDev.BDPruebasDataSetTableAdapters.CARRERASTableAdapter();
            this.alumnosTableAdapter1 = new AppPruebasDev.BDPruebasDataSetTableAdapters.ALUMNOSTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.aLUMNOS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPruebasDataSet1 = new AppPruebasDev.BDPruebasDataSet();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMatricula1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aLUMNOS1TableAdapter = new AppPruebasDev.BDPruebasDataSetTableAdapters.ALUMNOS1TableAdapter();
            this.alumnoS2TableAdapter1 = new AppPruebasDev.BDPruebasDataSetTableAdapters.ALUMNOS2TableAdapter();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGradoGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCarrera1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARRERASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cARRERASBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            gridLevelNode1.LevelTemplate = this.cardView1;
            gridLevelNode1.RelationName = "RefCARRERAS4";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(755, 270);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.cardView1});
            // 
            // cARRERASBindingSource
            // 
            this.cARRERASBindingSource.DataMember = "CARRERAS";
            this.cARRERASBindingSource.DataSource = this.bDPruebasDataSet;
            // 
            // bDPruebasDataSet
            // 
            this.bDPruebasDataSet.DataSetName = "BDPruebasDataSet";
            this.bDPruebasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCarrera,
            this.colNombreCarrera});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
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
            // cARRERASTableAdapter
            // 
            this.cARRERASTableAdapter.ClearBeforeFill = true;
            // 
            // alumnosTableAdapter1
            // 
            this.alumnosTableAdapter1.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.aLUMNOS1BindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "ALUMNOS1_ALUMNOS2";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl2.Location = new System.Drawing.Point(0, 303);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(755, 200);
            this.gridControl2.TabIndex = 20;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView3});
            // 
            // aLUMNOS1BindingSource
            // 
            this.aLUMNOS1BindingSource.DataMember = "ALUMNOS1";
            this.aLUMNOS1BindingSource.DataSource = this.bDPruebasDataSet1;
            // 
            // bDPruebasDataSet1
            // 
            this.bDPruebasDataSet1.DataSetName = "BDPruebasDataSet";
            this.bDPruebasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMatricula1,
            this.colNombreCompleto});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // colMatricula1
            // 
            this.colMatricula1.FieldName = "Matricula";
            this.colMatricula1.Name = "colMatricula1";
            this.colMatricula1.Visible = true;
            this.colMatricula1.VisibleIndex = 0;
            // 
            // colNombreCompleto
            // 
            this.colNombreCompleto.FieldName = "NombreCompleto";
            this.colNombreCompleto.Name = "colNombreCompleto";
            this.colNombreCompleto.Visible = true;
            this.colNombreCompleto.VisibleIndex = 1;
            // 
            // aLUMNOS1TableAdapter
            // 
            this.aLUMNOS1TableAdapter.ClearBeforeFill = true;
            // 
            // alumnoS2TableAdapter1
            // 
            this.alumnoS2TableAdapter1.ClearBeforeFill = true;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNombreCarrera1,
            this.colGradoGrupo,
            this.colTelefono1});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            // 
            // colGradoGrupo
            // 
            this.colGradoGrupo.FieldName = "GradoGrupo";
            this.colGradoGrupo.Name = "colGradoGrupo";
            this.colGradoGrupo.Visible = true;
            this.colGradoGrupo.VisibleIndex = 0;
            // 
            // colNombreCarrera1
            // 
            this.colNombreCarrera1.FieldName = "NombreCarrera";
            this.colNombreCarrera1.Name = "colNombreCarrera1";
            this.colNombreCarrera1.Visible = true;
            this.colNombreCarrera1.VisibleIndex = 1;
            // 
            // colTelefono1
            // 
            this.colTelefono1.FieldName = "Telefono";
            this.colTelefono1.Name = "colTelefono1";
            this.colTelefono1.Visible = true;
            this.colTelefono1.VisibleIndex = 2;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 503);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAlumnos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARRERASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLUMNOS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPruebasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BDPruebasDataSet bDPruebasDataSet1;
        private System.Windows.Forms.BindingSource aLUMNOS1BindingSource;
        private BDPruebasDataSetTableAdapters.ALUMNOS1TableAdapter aLUMNOS1TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMatricula1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCompleto;
        private BDPruebasDataSetTableAdapters.ALUMNOS2TableAdapter alumnoS2TableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCarrera1;
        private DevExpress.XtraGrid.Columns.GridColumn colGradoGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono1;
    }
}