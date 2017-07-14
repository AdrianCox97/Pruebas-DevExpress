namespace CeramicaCarrillo.GUI.Inicio
{
    partial class frmXtraCierre
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            this.lyCtrlAcciones = new DevExpress.XtraLayout.LayoutControl();
            this.pbxCerrarSesion = new DevExpress.XtraEditors.PictureEdit();
            this.pbxSalirAplicacion = new DevExpress.XtraEditors.PictureEdit();
            this.lyCtrlGroupAcciones = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemCerrarSesion = new DevExpress.XtraLayout.LayoutControlItem();
            this.lyCtrlSalirAplicacion = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlAcciones)).BeginInit();
            this.lyCtrlAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrarSesion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirAplicacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlSalirAplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lyCtrlAcciones
            // 
            this.lyCtrlAcciones.Controls.Add(this.pbxCerrarSesion);
            this.lyCtrlAcciones.Controls.Add(this.pbxSalirAplicacion);
            this.lyCtrlAcciones.Location = new System.Drawing.Point(12, 12);
            this.lyCtrlAcciones.Name = "lyCtrlAcciones";
            this.lyCtrlAcciones.Root = this.lyCtrlGroupAcciones;
            this.lyCtrlAcciones.Size = new System.Drawing.Size(507, 134);
            this.lyCtrlAcciones.TabIndex = 0;
            // 
            // pbxCerrarSesion
            // 
            this.pbxCerrarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxCerrarSesion.EditValue = global::CeramicaCarrillo.Properties.Resources.Logout;
            this.pbxCerrarSesion.Location = new System.Drawing.Point(12, 12);
            this.pbxCerrarSesion.Name = "pbxCerrarSesion";
            this.pbxCerrarSesion.Properties.AllowFocused = false;
            this.pbxCerrarSesion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pbxCerrarSesion.Properties.Appearance.Options.UseBackColor = true;
            this.pbxCerrarSesion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pbxCerrarSesion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbxCerrarSesion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pbxCerrarSesion.Properties.ZoomAccelerationFactor = 1D;
            this.pbxCerrarSesion.Size = new System.Drawing.Size(205, 88);
            this.pbxCerrarSesion.StyleController = this.lyCtrlAcciones;
            this.pbxCerrarSesion.TabIndex = 4;
            this.pbxCerrarSesion.Click += new System.EventHandler(this.pbxCerrarSesion_Click);
            // 
            // pbxSalirAplicacion
            // 
            this.pbxSalirAplicacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbxSalirAplicacion.EditValue = global::CeramicaCarrillo.Properties.Resources.shutdown;
            this.pbxSalirAplicacion.Location = new System.Drawing.Point(289, 12);
            this.pbxSalirAplicacion.Name = "pbxSalirAplicacion";
            this.pbxSalirAplicacion.Properties.AllowFocused = false;
            this.pbxSalirAplicacion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pbxSalirAplicacion.Properties.Appearance.Options.UseBackColor = true;
            this.pbxSalirAplicacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pbxSalirAplicacion.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbxSalirAplicacion.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pbxSalirAplicacion.Properties.ZoomAccelerationFactor = 1D;
            this.pbxSalirAplicacion.Size = new System.Drawing.Size(206, 88);
            this.pbxSalirAplicacion.StyleController = this.lyCtrlAcciones;
            this.pbxSalirAplicacion.TabIndex = 5;
            this.pbxSalirAplicacion.Click += new System.EventHandler(this.pbxSalirAplicacion_Click);
            // 
            // lyCtrlGroupAcciones
            // 
            this.lyCtrlGroupAcciones.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyCtrlGroupAcciones.GroupBordersVisible = false;
            this.lyCtrlGroupAcciones.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemCerrarSesion,
            this.lyCtrlSalirAplicacion});
            this.lyCtrlGroupAcciones.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lyCtrlGroupAcciones.Location = new System.Drawing.Point(0, 0);
            this.lyCtrlGroupAcciones.Name = "lyCtrlGroupAcciones";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 43D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 14D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 43D;
            this.lyCtrlGroupAcciones.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lyCtrlGroupAcciones.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.lyCtrlGroupAcciones.Size = new System.Drawing.Size(507, 134);
            this.lyCtrlGroupAcciones.TextVisible = false;
            // 
            // CtrlItemCerrarSesion
            // 
            this.CtrlItemCerrarSesion.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtrlItemCerrarSesion.AppearanceItemCaption.Options.UseFont = true;
            this.CtrlItemCerrarSesion.AppearanceItemCaption.Options.UseTextOptions = true;
            this.CtrlItemCerrarSesion.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CtrlItemCerrarSesion.Control = this.pbxCerrarSesion;
            this.CtrlItemCerrarSesion.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemCerrarSesion.Name = "CtrlItemCerrarSesion";
            this.CtrlItemCerrarSesion.Size = new System.Drawing.Size(209, 114);
            this.CtrlItemCerrarSesion.Text = "Cerrar Sesión";
            this.CtrlItemCerrarSesion.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.CtrlItemCerrarSesion.TextSize = new System.Drawing.Size(147, 19);
            this.CtrlItemCerrarSesion.Click += new System.EventHandler(this.pbxCerrarSesion_Click);
            // 
            // lyCtrlSalirAplicacion
            // 
            this.lyCtrlSalirAplicacion.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lyCtrlSalirAplicacion.AppearanceItemCaption.Options.UseFont = true;
            this.lyCtrlSalirAplicacion.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lyCtrlSalirAplicacion.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lyCtrlSalirAplicacion.Control = this.pbxSalirAplicacion;
            this.lyCtrlSalirAplicacion.Location = new System.Drawing.Point(277, 0);
            this.lyCtrlSalirAplicacion.Name = "lyCtrlSalirAplicacion";
            this.lyCtrlSalirAplicacion.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lyCtrlSalirAplicacion.Size = new System.Drawing.Size(210, 114);
            this.lyCtrlSalirAplicacion.Text = "Salir de la Aplicación";
            this.lyCtrlSalirAplicacion.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.lyCtrlSalirAplicacion.TextSize = new System.Drawing.Size(147, 19);
            this.lyCtrlSalirAplicacion.Click += new System.EventHandler(this.pbxSalirAplicacion_Click);
            // 
            // frmXtraCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 167);
            this.Controls.Add(this.lyCtrlAcciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmXtraCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acción";
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlAcciones)).EndInit();
            this.lyCtrlAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrarSesion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirAplicacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlSalirAplicacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lyCtrlAcciones;
        private DevExpress.XtraEditors.PictureEdit pbxCerrarSesion;
        private DevExpress.XtraEditors.PictureEdit pbxSalirAplicacion;
        private DevExpress.XtraLayout.LayoutControlGroup lyCtrlGroupAcciones;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemCerrarSesion;
        private DevExpress.XtraLayout.LayoutControlItem lyCtrlSalirAplicacion;
    }
}