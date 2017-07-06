namespace AppPruebasDev.GUI
{
    partial class frmDivisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDivisiones));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtNombreDivision = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEliminarDivision = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarDivision = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarDivision = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevaDivision = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDDivision = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaDivisiones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDDivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreDivision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDDivision.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaDivisiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(558, 146);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(269, 126);
            this.layoutControlGroup2.Text = "Datos de la División";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtNombreDivision;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(245, 44);
            this.layoutControlItem3.Text = "Nombre de la División";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(102, 13);
            // 
            // txtNombreDivision
            // 
            this.txtNombreDivision.Location = new System.Drawing.Point(24, 98);
            this.txtNombreDivision.Name = "txtNombreDivision";
            this.txtNombreDivision.Properties.NullValuePrompt = "Ejemplo: División Industrial";
            this.txtNombreDivision.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNombreDivision.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtNombreDivision.Size = new System.Drawing.Size(241, 20);
            this.txtNombreDivision.StyleController = this.layoutControl1;
            this.txtNombreDivision.TabIndex = 15;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEditarDivision);
            this.layoutControl1.Controls.Add(this.btnEliminarDivision);
            this.layoutControl1.Controls.Add(this.btnGuardarDivision);
            this.layoutControl1.Controls.Add(this.btnNuevaDivision);
            this.layoutControl1.Controls.Add(this.txtIDDivision);
            this.layoutControl1.Controls.Add(this.txtNombreDivision);
            this.layoutControl1.Location = new System.Drawing.Point(26, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(558, 146);
            this.layoutControl1.TabIndex = 13;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEliminarDivision
            // 
            this.btnEliminarDivision.AllowFocus = false;
            this.btnEliminarDivision.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDivision.Appearance.Options.UseFont = true;
            this.btnEliminarDivision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarDivision.ImageOptions.Image")));
            this.btnEliminarDivision.Location = new System.Drawing.Point(415, 84);
            this.btnEliminarDivision.Name = "btnEliminarDivision";
            this.btnEliminarDivision.Size = new System.Drawing.Size(119, 38);
            this.btnEliminarDivision.StyleController = this.layoutControl1;
            this.btnEliminarDivision.TabIndex = 21;
            this.btnEliminarDivision.Text = "Eliminar";
            this.btnEliminarDivision.Click += new System.EventHandler(this.btnEliminarDivision_Click);
            // 
            // btnEditarDivision
            // 
            this.btnEditarDivision.AllowFocus = false;
            this.btnEditarDivision.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarDivision.Appearance.Options.UseFont = true;
            this.btnEditarDivision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDivision.ImageOptions.Image")));
            this.btnEditarDivision.Location = new System.Drawing.Point(293, 84);
            this.btnEditarDivision.Name = "btnEditarDivision";
            this.btnEditarDivision.Size = new System.Drawing.Size(118, 38);
            this.btnEditarDivision.StyleController = this.layoutControl1;
            this.btnEditarDivision.TabIndex = 20;
            this.btnEditarDivision.Text = "Editar";
            this.btnEditarDivision.Click += new System.EventHandler(this.btnEditarDivision_Click);
            // 
            // btnGuardarDivision
            // 
            this.btnGuardarDivision.AllowFocus = false;
            this.btnGuardarDivision.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDivision.Appearance.Options.UseFont = true;
            this.btnGuardarDivision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarDivision.ImageOptions.Image")));
            this.btnGuardarDivision.Location = new System.Drawing.Point(415, 42);
            this.btnGuardarDivision.Name = "btnGuardarDivision";
            this.btnGuardarDivision.Size = new System.Drawing.Size(119, 38);
            this.btnGuardarDivision.StyleController = this.layoutControl1;
            this.btnGuardarDivision.TabIndex = 19;
            this.btnGuardarDivision.Text = "Guardar";
            this.btnGuardarDivision.Click += new System.EventHandler(this.btnGuardarDivision_Click);
            // 
            // btnNuevaDivision
            // 
            this.btnNuevaDivision.AllowFocus = false;
            this.btnNuevaDivision.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaDivision.Appearance.Options.UseFont = true;
            this.btnNuevaDivision.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaDivision.ImageOptions.Image")));
            this.btnNuevaDivision.Location = new System.Drawing.Point(293, 42);
            this.btnNuevaDivision.Name = "btnNuevaDivision";
            this.btnNuevaDivision.Size = new System.Drawing.Size(118, 38);
            this.btnNuevaDivision.StyleController = this.layoutControl1;
            this.btnNuevaDivision.TabIndex = 18;
            this.btnNuevaDivision.Text = "Nuevo";
            this.btnNuevaDivision.Click += new System.EventHandler(this.btnNuevaDivision_Click);
            // 
            // txtIDDivision
            // 
            this.txtIDDivision.Location = new System.Drawing.Point(24, 58);
            this.txtIDDivision.Name = "txtIDDivision";
            this.txtIDDivision.Properties.NullValuePrompt = "Clave de la División";
            this.txtIDDivision.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtIDDivision.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtIDDivision.Size = new System.Drawing.Size(241, 20);
            this.txtIDDivision.StyleController = this.layoutControl1;
            this.txtIDDivision.TabIndex = 14;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIDDivision;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(245, 40);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(102, 13);
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
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup3.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 50D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 50D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup3.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.layoutControlGroup3.Size = new System.Drawing.Size(269, 126);
            this.layoutControlGroup3.Text = "Acciones";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnNuevaDivision;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(63, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(122, 42);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnGuardarDivision;
            this.layoutControlItem4.Location = new System.Drawing.Point(122, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(71, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(123, 42);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnEliminarDivision;
            this.layoutControlItem6.Location = new System.Drawing.Point(122, 42);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(68, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem6.Size = new System.Drawing.Size(123, 42);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // dtgVista
            // 
            this.dtgVista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgVista.Location = new System.Drawing.Point(0, 184);
            this.dtgVista.MainView = this.dtgVistaDivisiones;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.Size = new System.Drawing.Size(606, 216);
            this.dtgVista.TabIndex = 14;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaDivisiones});
            // 
            // dtgVistaDivisiones
            // 
            this.dtgVistaDivisiones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDDivision,
            this.NombreDivision});
            this.dtgVistaDivisiones.GridControl = this.dtgVista;
            this.dtgVistaDivisiones.Name = "dtgVistaDivisiones";
            this.dtgVistaDivisiones.OptionsBehavior.Editable = false;
            this.dtgVistaDivisiones.OptionsBehavior.ReadOnly = true;
            this.dtgVistaDivisiones.OptionsFind.AlwaysVisible = true;
            this.dtgVistaDivisiones.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.dtgVistaDivisiones_RowCellClick);
            // 
            // IDDivision
            // 
            this.IDDivision.Caption = "Clave";
            this.IDDivision.FieldName = "IDDivision";
            this.IDDivision.Name = "IDDivision";
            this.IDDivision.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.IDDivision.Visible = true;
            this.IDDivision.VisibleIndex = 0;
            // 
            // NombreDivision
            // 
            this.NombreDivision.Caption = "Nombre de la División";
            this.NombreDivision.FieldName = "NombreDivision";
            this.NombreDivision.Name = "NombreDivision";
            this.NombreDivision.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreDivision.Visible = true;
            this.NombreDivision.VisibleIndex = 1;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnEditarDivision;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(65, 27);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem5.Size = new System.Drawing.Size(122, 42);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.Click += new System.EventHandler(this.btnEditarDivision_Click);
            // 
            // frmDivisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 400);
            this.Controls.Add(this.dtgVista);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDivisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divisiones";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIDDivision.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaDivisiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtNombreDivision;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnEliminarDivision;
        private DevExpress.XtraEditors.SimpleButton btnEditarDivision;
        private DevExpress.XtraEditors.SimpleButton btnGuardarDivision;
        private DevExpress.XtraEditors.SimpleButton btnNuevaDivision;
        private DevExpress.XtraEditors.TextEdit txtIDDivision;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaDivisiones;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn IDDivision;
        private DevExpress.XtraGrid.Columns.GridColumn NombreDivision;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}