namespace AppPruebasDev.GUI
{
    partial class frmCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEditarCarrera = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarCarrera = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarCarrera = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevaCarrera = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDCarrera = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreCarrera = new DevExpress.XtraEditors.TextEdit();
            this.cbxDivisionFK = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaCarreras = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCarrera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCarrera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreDivision = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCarrera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCarrera.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDivisionFK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEditarCarrera);
            this.layoutControl1.Controls.Add(this.btnEliminarCarrera);
            this.layoutControl1.Controls.Add(this.btnGuardarCarrera);
            this.layoutControl1.Controls.Add(this.btnNuevaCarrera);
            this.layoutControl1.Controls.Add(this.txtIDCarrera);
            this.layoutControl1.Controls.Add(this.txtNombreCarrera);
            this.layoutControl1.Controls.Add(this.cbxDivisionFK);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(558, 182);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEditarCarrera
            // 
            this.btnEditarCarrera.AllowFocus = false;
            this.btnEditarCarrera.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCarrera.Appearance.Options.UseFont = true;
            this.btnEditarCarrera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCarrera.ImageOptions.Image")));
            this.btnEditarCarrera.Location = new System.Drawing.Point(293, 102);
            this.btnEditarCarrera.Name = "btnEditarCarrera";
            this.btnEditarCarrera.Size = new System.Drawing.Size(118, 56);
            this.btnEditarCarrera.StyleController = this.layoutControl1;
            this.btnEditarCarrera.TabIndex = 20;
            this.btnEditarCarrera.Text = "Editar";
            this.btnEditarCarrera.Click += new System.EventHandler(this.btnEditarCarrera_Click);
            // 
            // btnEliminarCarrera
            // 
            this.btnEliminarCarrera.AllowFocus = false;
            this.btnEliminarCarrera.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCarrera.Appearance.Options.UseFont = true;
            this.btnEliminarCarrera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCarrera.ImageOptions.Image")));
            this.btnEliminarCarrera.Location = new System.Drawing.Point(415, 102);
            this.btnEliminarCarrera.Name = "btnEliminarCarrera";
            this.btnEliminarCarrera.Size = new System.Drawing.Size(119, 56);
            this.btnEliminarCarrera.StyleController = this.layoutControl1;
            this.btnEliminarCarrera.TabIndex = 21;
            this.btnEliminarCarrera.Text = "Eliminar";
            this.btnEliminarCarrera.Click += new System.EventHandler(this.btnEliminarCarrera_Click);
            // 
            // btnGuardarCarrera
            // 
            this.btnGuardarCarrera.AllowFocus = false;
            this.btnGuardarCarrera.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCarrera.Appearance.Options.UseFont = true;
            this.btnGuardarCarrera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCarrera.ImageOptions.Image")));
            this.btnGuardarCarrera.Location = new System.Drawing.Point(415, 42);
            this.btnGuardarCarrera.Name = "btnGuardarCarrera";
            this.btnGuardarCarrera.Size = new System.Drawing.Size(119, 56);
            this.btnGuardarCarrera.StyleController = this.layoutControl1;
            this.btnGuardarCarrera.TabIndex = 19;
            this.btnGuardarCarrera.Text = "Guardar";
            this.btnGuardarCarrera.Click += new System.EventHandler(this.btnGuardarCarrera_Click);
            // 
            // btnNuevaCarrera
            // 
            this.btnNuevaCarrera.AllowFocus = false;
            this.btnNuevaCarrera.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCarrera.Appearance.Options.UseFont = true;
            this.btnNuevaCarrera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaCarrera.ImageOptions.Image")));
            this.btnNuevaCarrera.Location = new System.Drawing.Point(293, 42);
            this.btnNuevaCarrera.Name = "btnNuevaCarrera";
            this.btnNuevaCarrera.Size = new System.Drawing.Size(118, 56);
            this.btnNuevaCarrera.StyleController = this.layoutControl1;
            this.btnNuevaCarrera.TabIndex = 18;
            this.btnNuevaCarrera.Text = "Nuevo";
            this.btnNuevaCarrera.Click += new System.EventHandler(this.btnNuevaCarrera_Click);
            // 
            // txtIDCarrera
            // 
            this.txtIDCarrera.Location = new System.Drawing.Point(24, 58);
            this.txtIDCarrera.Name = "txtIDCarrera";
            this.txtIDCarrera.Properties.NullValuePrompt = "Clave de la División";
            this.txtIDCarrera.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtIDCarrera.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtIDCarrera.Size = new System.Drawing.Size(241, 20);
            this.txtIDCarrera.StyleController = this.layoutControl1;
            this.txtIDCarrera.TabIndex = 14;
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(24, 98);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Properties.NullValuePrompt = "Ejemplo: Sistemas Informáticos";
            this.txtNombreCarrera.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNombreCarrera.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtNombreCarrera.Size = new System.Drawing.Size(241, 20);
            this.txtNombreCarrera.StyleController = this.layoutControl1;
            this.txtNombreCarrera.TabIndex = 15;
            // 
            // cbxDivisionFK
            // 
            this.cbxDivisionFK.Location = new System.Drawing.Point(24, 138);
            this.cbxDivisionFK.Name = "cbxDivisionFK";
            this.cbxDivisionFK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDivisionFK.Properties.NullValuePrompt = "Ejemplo: A";
            this.cbxDivisionFK.Properties.NullValuePromptShowForEmptyValue = true;
            this.cbxDivisionFK.Size = new System.Drawing.Size(241, 20);
            this.cbxDivisionFK.StyleController = this.layoutControl1;
            this.cbxDivisionFK.TabIndex = 15;
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
            this.layoutControlGroup2.Text = "Datos de la Carrera";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtNombreCarrera;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem3.Text = "Nombre de la Carrera";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIDCarrera;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(129, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbxDivisionFK;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem7.Text = "División a la que Pertenece";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(129, 13);
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
            this.layoutControlItem2.Control = this.btnNuevaCarrera;
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
            this.layoutControlItem4.Control = this.btnGuardarCarrera;
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
            this.layoutControlItem6.Control = this.btnEliminarCarrera;
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
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEditarCarrera;
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
            this.dtgVista.Location = new System.Drawing.Point(0, 215);
            this.dtgVista.MainView = this.dtgVistaCarreras;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.Size = new System.Drawing.Size(584, 195);
            this.dtgVista.TabIndex = 16;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaCarreras});
            // 
            // dtgVistaCarreras
            // 
            this.dtgVistaCarreras.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCarrera,
            this.NombreCarrera,
            this.NombreDivision});
            this.dtgVistaCarreras.GridControl = this.dtgVista;
            this.dtgVistaCarreras.Name = "dtgVistaCarreras";
            this.dtgVistaCarreras.OptionsBehavior.Editable = false;
            this.dtgVistaCarreras.OptionsBehavior.ReadOnly = true;
            this.dtgVistaCarreras.OptionsFind.AlwaysVisible = true;
            this.dtgVistaCarreras.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dtgVistaGrupos_RowCellClick);
            // 
            // IDCarrera
            // 
            this.IDCarrera.Caption = "Clave";
            this.IDCarrera.FieldName = "IDCarrera";
            this.IDCarrera.Name = "IDCarrera";
            this.IDCarrera.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IDCarrera.Visible = true;
            this.IDCarrera.VisibleIndex = 0;
            // 
            // NombreCarrera
            // 
            this.NombreCarrera.Caption = "Nombre de la Carrera";
            this.NombreCarrera.FieldName = "NombreCarrera";
            this.NombreCarrera.Name = "NombreCarrera";
            this.NombreCarrera.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreCarrera.Visible = true;
            this.NombreCarrera.VisibleIndex = 1;
            // 
            // NombreDivision
            // 
            this.NombreDivision.Caption = "Nombre de la División";
            this.NombreDivision.FieldName = "NombreDivision";
            this.NombreDivision.Name = "NombreDivision";
            this.NombreDivision.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreDivision.Visible = true;
            this.NombreDivision.VisibleIndex = 2;
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 410);
            this.Controls.Add(this.dtgVista);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIDCarrera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCarrera.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDivisionFK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnEditarCarrera;
        private DevExpress.XtraEditors.SimpleButton btnEliminarCarrera;
        private DevExpress.XtraEditors.SimpleButton btnGuardarCarrera;
        private DevExpress.XtraEditors.SimpleButton btnNuevaCarrera;
        private DevExpress.XtraEditors.TextEdit txtIDCarrera;
        private DevExpress.XtraEditors.TextEdit txtNombreCarrera;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDivisionFK;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaCarreras;
        private DevExpress.XtraGrid.Columns.GridColumn IDCarrera;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCarrera;
        private DevExpress.XtraGrid.Columns.GridColumn NombreDivision;
    }
}