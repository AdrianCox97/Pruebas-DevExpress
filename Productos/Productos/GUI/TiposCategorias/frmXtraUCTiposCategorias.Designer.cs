namespace CeramicaCarrillo.GUI.TiposCategorias
{
    partial class frmXtraUCTiposCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraUCTiposCategorias));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaTipos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idTipoProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Acciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonAccionesTipos = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAgregarTipos = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgVista
            // 
            this.dtgVista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVista.Location = new System.Drawing.Point(3, 117);
            this.dtgVista.MainView = this.dtgVistaTipos;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonAccionesTipos});
            this.dtgVista.Size = new System.Drawing.Size(717, 284);
            this.dtgVista.TabIndex = 1;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaTipos});
            // 
            // dtgVistaTipos
            // 
            this.dtgVistaTipos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idTipoProducto,
            this.NombreTipo,
            this.Acciones});
            this.dtgVistaTipos.GridControl = this.dtgVista;
            this.dtgVistaTipos.Name = "dtgVistaTipos";
            this.dtgVistaTipos.OptionsBehavior.AutoPopulateColumns = false;
            this.dtgVistaTipos.OptionsBehavior.ReadOnly = true;
            this.dtgVistaTipos.OptionsFind.AlwaysVisible = true;
            this.dtgVistaTipos.OptionsFind.FindNullPrompt = "Búsquedas...";
            // 
            // idTipoProducto
            // 
            this.idTipoProducto.Caption = "Clave";
            this.idTipoProducto.FieldName = "idTipoProducto";
            this.idTipoProducto.Name = "idTipoProducto";
            this.idTipoProducto.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.idTipoProducto.Visible = true;
            this.idTipoProducto.VisibleIndex = 0;
            // 
            // NombreTipo
            // 
            this.NombreTipo.Caption = "Nombre del Tipo de Producto";
            this.NombreTipo.FieldName = "NombreTipo";
            this.NombreTipo.Name = "NombreTipo";
            this.NombreTipo.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.NombreTipo.Visible = true;
            this.NombreTipo.VisibleIndex = 1;
            // 
            // Acciones
            // 
            this.Acciones.Caption = "Acciones";
            this.Acciones.ColumnEdit = this.ItemButtonAccionesTipos;
            this.Acciones.Name = "Acciones";
            this.Acciones.Visible = true;
            this.Acciones.VisibleIndex = 2;
            // 
            // ItemButtonAccionesTipos
            // 
            this.ItemButtonAccionesTipos.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.ItemButtonAccionesTipos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Editar registro", "EditarTipo"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Eliminar registro", "EliminarTipo"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Agregar Departamentos", "AgregarCategorias")});
            this.ItemButtonAccionesTipos.Name = "ItemButtonAccionesTipos";
            this.ItemButtonAccionesTipos.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ItemButtonAccionesTipos.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ItemButtonAccionesTipos_ButtonClick);
            // 
            // btnAgregarTipos
            // 
            this.btnAgregarTipos.AllowFocus = false;
            this.btnAgregarTipos.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipos.Appearance.Options.UseFont = true;
            this.btnAgregarTipos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregarTipos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTipos.ImageOptions.Image")));
            this.btnAgregarTipos.Location = new System.Drawing.Point(3, 30);
            this.btnAgregarTipos.Name = "btnAgregarTipos";
            this.btnAgregarTipos.Size = new System.Drawing.Size(275, 42);
            this.btnAgregarTipos.TabIndex = 2;
            this.btnAgregarTipos.Text = "Agregar Tipos de Producto";
            this.btnAgregarTipos.ToolTip = "Agregar nuevos tipos de productos al sistema";
            this.btnAgregarTipos.Click += new System.EventHandler(this.btnAgregarTipos_Click);
            // 
            // frmXtraUCTiposCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarTipos);
            this.Controls.Add(this.dtgVista);
            this.Name = "frmXtraUCTiposCategorias";
            this.Size = new System.Drawing.Size(723, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesTipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaTipos;
        private DevExpress.XtraGrid.Columns.GridColumn idTipoProducto;
        private DevExpress.XtraEditors.SimpleButton btnAgregarTipos;
        private DevExpress.XtraGrid.Columns.GridColumn NombreTipo;
        private DevExpress.XtraGrid.Columns.GridColumn Acciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonAccionesTipos;
    }
}
