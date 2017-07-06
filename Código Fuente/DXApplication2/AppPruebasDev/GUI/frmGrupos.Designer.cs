namespace AppPruebasDev.GUI
{
    partial class frmGrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrupos));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEliminarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoGrupo = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDGrupo = new DevExpress.XtraEditors.TextEdit();
            this.txtCuatrimestre = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtGrupo = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaGrupos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cuatrimestre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuatrimestre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEditarGrupo);
            this.layoutControl1.Controls.Add(this.btnEliminarGrupo);
            this.layoutControl1.Controls.Add(this.btnGuardarGrupo);
            this.layoutControl1.Controls.Add(this.btnNuevoGrupo);
            this.layoutControl1.Controls.Add(this.txtIDGrupo);
            this.layoutControl1.Controls.Add(this.txtCuatrimestre);
            this.layoutControl1.Controls.Add(this.txtGrupo);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(558, 182);
            this.layoutControl1.TabIndex = 14;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.AllowFocus = false;
            this.btnEliminarGrupo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGrupo.Appearance.Options.UseFont = true;
            this.btnEliminarGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDivision.ImageOptions.Image")));
            this.btnEliminarGrupo.Location = new System.Drawing.Point(415, 102);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(119, 56);
            this.btnEliminarGrupo.StyleController = this.layoutControl1;
            this.btnEliminarGrupo.TabIndex = 21;
            this.btnEliminarGrupo.Text = "Eliminar";
            this.btnEliminarGrupo.Click += new System.EventHandler(this.btnEliminarGrupo_Click);
            // 
            // btnEditarGrupo
            // 
            this.btnEditarGrupo.AllowFocus = false;
            this.btnEditarGrupo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGrupo.Appearance.Options.UseFont = true;
            this.btnEditarGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDivision.ImageOptions.Image")));
            this.btnEditarGrupo.Location = new System.Drawing.Point(293, 102);
            this.btnEditarGrupo.Name = "btnEditarGrupo";
            this.btnEditarGrupo.Size = new System.Drawing.Size(118, 56);
            this.btnEditarGrupo.StyleController = this.layoutControl1;
            this.btnEditarGrupo.TabIndex = 20;
            this.btnEditarGrupo.Text = "Editar";
            this.btnEditarGrupo.Click += new System.EventHandler(this.btnEditarGrupo_Click);
            // 
            // btnGuardarGrupo
            // 
            this.btnGuardarGrupo.AllowFocus = false;
            this.btnGuardarGrupo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGrupo.Appearance.Options.UseFont = true;
            this.btnGuardarGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarDivision.ImageOptions.Image")));
            this.btnGuardarGrupo.Location = new System.Drawing.Point(415, 42);
            this.btnGuardarGrupo.Name = "btnGuardarGrupo";
            this.btnGuardarGrupo.Size = new System.Drawing.Size(119, 56);
            this.btnGuardarGrupo.StyleController = this.layoutControl1;
            this.btnGuardarGrupo.TabIndex = 19;
            this.btnGuardarGrupo.Text = "Guardar";
            this.btnGuardarGrupo.Click += new System.EventHandler(this.btnGuardarGrupo_Click);
            // 
            // btnNuevoGrupo
            // 
            this.btnNuevoGrupo.AllowFocus = false;
            this.btnNuevoGrupo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoGrupo.Appearance.Options.UseFont = true;
            this.btnNuevoGrupo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaDivision.ImageOptions.Image")));
            this.btnNuevoGrupo.Location = new System.Drawing.Point(293, 42);
            this.btnNuevoGrupo.Name = "btnNuevoGrupo";
            this.btnNuevoGrupo.Size = new System.Drawing.Size(118, 56);
            this.btnNuevoGrupo.StyleController = this.layoutControl1;
            this.btnNuevoGrupo.TabIndex = 18;
            this.btnNuevoGrupo.Text = "Nuevo";
            this.btnNuevoGrupo.Click += new System.EventHandler(this.btnNuevoGrupo_Click);
            // 
            // txtIDGrupo
            // 
            this.txtIDGrupo.Location = new System.Drawing.Point(24, 58);
            this.txtIDGrupo.Name = "txtIDGrupo";
            this.txtIDGrupo.Properties.NullValuePrompt = "Clave de la División";
            this.txtIDGrupo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtIDGrupo.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtIDGrupo.Size = new System.Drawing.Size(241, 20);
            this.txtIDGrupo.StyleController = this.layoutControl1;
            this.txtIDGrupo.TabIndex = 14;
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(24, 98);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Properties.MaxLength = 2;
            this.txtCuatrimestre.Properties.NullValuePrompt = "Ejemplo: 4";
            this.txtCuatrimestre.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtCuatrimestre.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtCuatrimestre.Size = new System.Drawing.Size(241, 20);
            this.txtCuatrimestre.StyleController = this.layoutControl1;
            this.txtCuatrimestre.TabIndex = 15;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(558, 182);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(269, 162);
            this.layoutControlGroup2.Text = "Datos del Grupo";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCuatrimestre;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem3.Text = "Cuatrimestre";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIDGrupo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.layoutControlGroup3.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup3.Location = new System.Drawing.Point(269, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition7.Width = 50D;
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition8.Width = 50D;
            this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition7,
            columnDefinition8});
            rowDefinition7.Height = 50D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition8.Height = 50D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition7,
            rowDefinition8});
            this.layoutControlGroup3.Size = new System.Drawing.Size(269, 162);
            this.layoutControlGroup3.Text = "Acciones";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnNuevoGrupo;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(63, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(122, 60);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnGuardarGrupo;
            this.layoutControlItem4.Location = new System.Drawing.Point(122, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(71, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(123, 60);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEliminarGrupo;
            this.layoutControlItem6.Location = new System.Drawing.Point(122, 60);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(68, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(123, 60);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(24, 138);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Properties.MaxLength = 1;
            this.txtGrupo.Properties.NullValuePrompt = "Ejemplo: A";
            this.txtGrupo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtGrupo.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtGrupo.Size = new System.Drawing.Size(241, 20);
            this.txtGrupo.StyleController = this.layoutControl1;
            this.txtGrupo.TabIndex = 15;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtGrupo;
            this.layoutControlItem7.CustomizationFormText = "Nombre de la División";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem7.Text = "Grupo";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(62, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEditarGrupo;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(65, 27);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(122, 60);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // dtgVista
            // 
            this.dtgVista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgVista.Location = new System.Drawing.Point(0, 213);
            this.dtgVista.MainView = this.dtgVistaGrupos;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.Size = new System.Drawing.Size(583, 177);
            this.dtgVista.TabIndex = 15;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaGrupos});
            // 
            // dtgVistaGrupos
            // 
            this.dtgVistaGrupos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDGrupo,
            this.Cuatrimestre,
            this.Grupo});
            this.dtgVistaGrupos.GridControl = this.dtgVista;
            this.dtgVistaGrupos.Name = "dtgVistaGrupos";
            this.dtgVistaGrupos.OptionsBehavior.Editable = false;
            this.dtgVistaGrupos.OptionsBehavior.ReadOnly = true;
            this.dtgVistaGrupos.OptionsFind.AlwaysVisible = true;
            this.dtgVistaGrupos.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dtgVistaGrupos_RowCellClick);
            // 
            // IDGrupo
            // 
            this.IDGrupo.Caption = "Clave";
            this.IDGrupo.FieldName = "IDGrupo";
            this.IDGrupo.Name = "IDGrupo";
            this.IDGrupo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IDGrupo.Visible = true;
            this.IDGrupo.VisibleIndex = 0;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.Caption = "Cuatrimestre";
            this.Cuatrimestre.FieldName = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Cuatrimestre.Visible = true;
            this.Cuatrimestre.VisibleIndex = 1;
            // 
            // Grupo
            // 
            this.Grupo.Caption = "Grupo";
            this.Grupo.FieldName = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Grupo.Visible = true;
            this.Grupo.VisibleIndex = 2;
            // 
            // frmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 390);
            this.Controls.Add(this.dtgVista);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIDGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCuatrimestre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnEliminarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnEditarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnGuardarGrupo;
        private DevExpress.XtraEditors.SimpleButton btnNuevoGrupo;
        private DevExpress.XtraEditors.TextEdit txtIDGrupo;
        private DevExpress.XtraEditors.TextEdit txtCuatrimestre;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtGrupo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaGrupos;
        private DevExpress.XtraGrid.Columns.GridColumn IDGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn Cuatrimestre;
        private DevExpress.XtraGrid.Columns.GridColumn Grupo;
    }
}