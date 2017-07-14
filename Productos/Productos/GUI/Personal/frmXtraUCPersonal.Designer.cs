namespace CeramicaCarrillo.GUI.Personal
{
    partial class frmXtraUCPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraUCPersonal));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.btnAgregarPersonal = new DevExpress.XtraEditors.SimpleButton();
            this.dtgVista = new DevExpress.XtraGrid.GridControl();
            this.dtgVistaPersonal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPersonal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreCompleto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Contrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Movil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Puesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Acciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonAccionesPeronal = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesPeronal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.AllowFocus = false;
            this.btnAgregarPersonal.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersonal.Appearance.Options.UseFont = true;
            this.btnAgregarPersonal.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnAgregarPersonal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPersonal.ImageOptions.Image")));
            this.btnAgregarPersonal.Location = new System.Drawing.Point(3, 30);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(206, 42);
            this.btnAgregarPersonal.TabIndex = 3;
            this.btnAgregarPersonal.Text = "Agregar Empleado";
            this.btnAgregarPersonal.ToolTip = "Agregar nuevos empleados al sistema";
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // dtgVista
            // 
            this.dtgVista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgVista.Location = new System.Drawing.Point(3, 117);
            this.dtgVista.MainView = this.dtgVistaPersonal;
            this.dtgVista.Name = "dtgVista";
            this.dtgVista.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonAccionesPeronal});
            this.dtgVista.Size = new System.Drawing.Size(717, 284);
            this.dtgVista.TabIndex = 2;
            this.dtgVista.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgVistaPersonal});
            // 
            // dtgVistaPersonal
            // 
            this.dtgVistaPersonal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPersonal,
            this.NombreCompleto,
            this.Usuario,
            this.Contrasena,
            this.Telefono,
            this.Movil,
            this.Direccion,
            this.FechaNacimiento,
            this.Puesto,
            this.Acciones});
            this.dtgVistaPersonal.GridControl = this.dtgVista;
            this.dtgVistaPersonal.Name = "dtgVistaPersonal";
            this.dtgVistaPersonal.OptionsBehavior.ReadOnly = true;
            this.dtgVistaPersonal.OptionsFind.AlwaysVisible = true;
            this.dtgVistaPersonal.OptionsFind.FindNullPrompt = "Búsquedas...";
            this.dtgVistaPersonal.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // IdPersonal
            // 
            this.IdPersonal.Caption = "Clave";
            this.IdPersonal.FieldName = "IdPersonal";
            this.IdPersonal.Name = "IdPersonal";
            this.IdPersonal.Visible = true;
            this.IdPersonal.VisibleIndex = 0;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.Caption = "Nombre del Empleado";
            this.NombreCompleto.FieldName = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.Visible = true;
            this.NombreCompleto.VisibleIndex = 1;
            // 
            // Usuario
            // 
            this.Usuario.Caption = "Nombre de Usuario";
            this.Usuario.FieldName = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Visible = true;
            this.Usuario.VisibleIndex = 2;
            // 
            // Contrasena
            // 
            this.Contrasena.Caption = "Contraseña";
            this.Contrasena.FieldName = "Contrasena";
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Visible = true;
            this.Contrasena.VisibleIndex = 3;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Teléfono";
            this.Telefono.FieldName = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 4;
            // 
            // Movil
            // 
            this.Movil.Caption = "Celular";
            this.Movil.FieldName = "Movil";
            this.Movil.Name = "Movil";
            this.Movil.Visible = true;
            this.Movil.VisibleIndex = 5;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Dirección";
            this.Direccion.FieldName = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 6;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Caption = "Fecha de Nacimiento";
            this.FechaNacimiento.FieldName = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Visible = true;
            this.FechaNacimiento.VisibleIndex = 7;
            // 
            // Puesto
            // 
            this.Puesto.Caption = "Puesto";
            this.Puesto.FieldName = "Puesto";
            this.Puesto.Name = "Puesto";
            this.Puesto.Visible = true;
            this.Puesto.VisibleIndex = 8;
            // 
            // Acciones
            // 
            this.Acciones.Caption = "Acciones";
            this.Acciones.ColumnEdit = this.ItemButtonAccionesPeronal;
            this.Acciones.Name = "Acciones";
            this.Acciones.Visible = true;
            this.Acciones.VisibleIndex = 9;
            // 
            // ItemButtonAccionesPeronal
            // 
            this.ItemButtonAccionesPeronal.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.ItemButtonAccionesPeronal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Editar registro", "EditarPersonal"),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Eliminar registro", "EliminarPersonal")});
            this.ItemButtonAccionesPeronal.Name = "ItemButtonAccionesPeronal";
            this.ItemButtonAccionesPeronal.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.ItemButtonAccionesPeronal.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ItemButtonAccionesPeronal_ButtonClick);
            // 
            // frmXtraUCPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarPersonal);
            this.Controls.Add(this.dtgVista);
            this.Name = "frmXtraUCPersonal";
            this.Size = new System.Drawing.Size(723, 404);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVistaPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonAccionesPeronal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAgregarPersonal;
        private DevExpress.XtraGrid.GridControl dtgVista;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgVistaPersonal;
        private DevExpress.XtraGrid.Columns.GridColumn IdPersonal;
        private DevExpress.XtraGrid.Columns.GridColumn NombreCompleto;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn Contrasena;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn Movil;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn FechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn Puesto;
        private DevExpress.XtraGrid.Columns.GridColumn Acciones;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonAccionesPeronal;
    }
}
