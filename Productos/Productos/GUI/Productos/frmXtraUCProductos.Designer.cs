namespace CeramicaCarrillo.GUI.Productos
{
    partial class frmXtraUCProductos
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraUCProductos));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrecioMayoreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Unidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CategoriaTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Acciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonAccionesProductos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAgregarProductos = new DevExpress.XtraEditors.SimpleButton();
            this.btnReporteProductos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVista
            // 
            this.dtgVista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVista.Location = new System.Drawing.Point(3, 117);
            this.dtgVista.MainView = this.dtgVistaProductos;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonAccionesProductos});
            this.dtgVista.Size = new System.Drawing.Size(717, 284);
            this.dtgVista.TabIndex = 0;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaProductos});
            // 
            // dtgVistaProductos
            // 
            this.dtgVistaProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdProductos,
            this.Descripcion,
            this.PrecioVenta,
            this.PrecioMayoreo,
            this.Unidades,
            this.CategoriaTipo,
            this.Acciones});
            this.dtgVistaProductos.GridControl = this.dtgVista;
            this.dtgVistaProductos.Name = "dtgVistaProductos";
            this.dtgVistaProductos.OptionsBehavior.ReadOnly = true;
            this.dtgVistaProductos.OptionsFind.AlwaysVisible = true;
            this.dtgVistaProductos.OptionsFind.FindNullPrompt = "Búsquedas...";
            // 
            // IdProductos
            // 
            this.IdProductos.Caption = "Clave";
            this.IdProductos.FieldName = "IdProductos";
            this.IdProductos.Name = "IdProductos";
            this.IdProductos.Visible = true;
            this.IdProductos.VisibleIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripción";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 1;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.Caption = "Precio Unitario";
            this.PrecioVenta.FieldName = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.Visible = true;
            this.PrecioVenta.VisibleIndex = 2;
            // 
            // PrecioMayoreo
            // 
            this.PrecioMayoreo.Caption = "Precio de Mayoreo";
            this.PrecioMayoreo.FieldName = "PrecioMayoreo";
            this.PrecioMayoreo.Name = "PrecioMayoreo";
            this.PrecioMayoreo.Visible = true;
            this.PrecioMayoreo.VisibleIndex = 3;
            // 
            // Unidades
            // 
            this.Unidades.Caption = "Unidades (Stock)";
            this.Unidades.FieldName = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.Visible = true;
            this.Unidades.VisibleIndex = 4;
            // 
            // CategoriaTipo
            // 
            this.CategoriaTipo.Caption = "Departamento y Tipo";
            this.CategoriaTipo.FieldName = "CategoriaTipo";
            this.CategoriaTipo.Name = "CategoriaTipo";
            this.CategoriaTipo.Visible = true;
            this.CategoriaTipo.VisibleIndex = 5;
            // 
            // Acciones
            // 
            this.Acciones.Caption = "Acciones";
            this.Acciones.ColumnEdit = this.ItemButtonAccionesProductos;
            this.Acciones.Name = "Acciones";
            this.Acciones.Visible = true;
            this.Acciones.VisibleIndex = 6;
            // 
            // ItemButtonAccionesProductos
            // 
            this.ItemButtonAccionesProductos.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.ItemButtonAccionesProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Editar registro", "EditarProducto"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Eliminar registro", "EliminarProducto"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Reportar anomalías", "ReportarAnomalias"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Agregar compras", "AgregarCompras")});
            this.ItemButtonAccionesProductos.Name = "ItemButtonAccionesProductos";
            this.ItemButtonAccionesProductos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ItemButtonAccionesProductos.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ItemButtonAccionesProductos_ButtonClick);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.AllowFocus = false;
            this.btnAgregarProductos.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Appearance.Options.UseFont = true;
            this.btnAgregarProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregarProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductos.ImageOptions.Image")));
            this.btnAgregarProductos.Location = new System.Drawing.Point(3, 30);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(206, 42);
            this.btnAgregarProductos.TabIndex = 1;
            this.btnAgregarProductos.Text = "Agregar Productos";
            this.btnAgregarProductos.ToolTip = "Agregar nuevos productos al sistema";
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnReporteProductos
            // 
            this.btnReporteProductos.AllowFocus = false;
            this.btnReporteProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporteProductos.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteProductos.Appearance.Options.UseFont = true;
            this.btnReporteProductos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnReporteProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnReporteProductos.Location = new System.Drawing.Point(517, 30);
            this.btnReporteProductos.Name = "btnReporteProductos";
            this.btnReporteProductos.Size = new System.Drawing.Size(206, 42);
            this.btnReporteProductos.TabIndex = 2;
            this.btnReporteProductos.Text = "Generar Reporte";
            this.btnReporteProductos.ToolTip = "Generar reporte de productos";
            this.btnReporteProductos.Click += new System.EventHandler(this.btnReporteProductos_Click);
            // 
            // frmXtraUCProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnReporteProductos);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.dtgVista);
            this.Name = "frmXtraUCProductos";
            this.Size = new System.Drawing.Size(723, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaProductos;
        private DevExpress.XtraGrid.Columns.GridColumn IdProductos;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn PrecioMayoreo;
        private DevExpress.XtraGrid.Columns.GridColumn Unidades;
        private DevExpress.XtraGrid.Columns.GridColumn CategoriaTipo;
        private DevExpress.XtraEditors.SimpleButton btnAgregarProductos;
        private DevExpress.XtraGrid.Columns.GridColumn Acciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonAccionesProductos;
        private DevExpress.XtraEditors.SimpleButton btnReporteProductos;
    }
}