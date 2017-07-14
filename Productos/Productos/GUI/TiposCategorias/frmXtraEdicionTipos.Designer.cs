namespace CeramicaCarrillo.GUI.TiposCategorias
{
    partial class frmXtraEdicionTipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraEdicionTipos));
            this.lyCtrlDatosTipo = new DevExpress.XtraLayout.LayoutControl();
            this.txtNombreTipo = new DevExpress.XtraEditors.TextEdit();
            this.lyCtrlGroupDatosTipo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyGroupBoxDatosTipo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.CtrlItemNombreTipo = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancelarTipo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarTipo = new DevExpress.XtraEditors.SimpleButton();
            this.lblIDTipo = new DevExpress.XtraEditors.LabelControl();
            this.txtIDTipo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosTipo)).BeginInit();
            this.lyCtrlDatosTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreTipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemNombreTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDTipo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lyCtrlDatosTipo
            // 
            this.lyCtrlDatosTipo.Controls.Add(this.txtNombreTipo);
            this.lyCtrlDatosTipo.Location = new System.Drawing.Point(24, 22);
            this.lyCtrlDatosTipo.Name = "lyCtrlDatosTipo";
            this.lyCtrlDatosTipo.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(564, 20, 450, 400);
            this.lyCtrlDatosTipo.Root = this.lyCtrlGroupDatosTipo;
            this.lyCtrlDatosTipo.Size = new System.Drawing.Size(345, 88);
            this.lyCtrlDatosTipo.TabIndex = 24;
            this.lyCtrlDatosTipo.Text = "layoutControl1";
            // 
            // txtNombreTipo
            // 
            this.txtNombreTipo.Location = new System.Drawing.Point(81, 37);
            this.txtNombreTipo.Name = "txtNombreTipo";
            this.txtNombreTipo.Properties.NullValuePrompt = "Ejemplo: Cerámica";
            this.txtNombreTipo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtNombreTipo.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtNombreTipo.Size = new System.Drawing.Size(240, 20);
            this.txtNombreTipo.StyleController = this.lyCtrlDatosTipo;
            this.txtNombreTipo.TabIndex = 7;
            // 
            // lyCtrlGroupDatosTipo
            // 
            this.lyCtrlGroupDatosTipo.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lyCtrlGroupDatosTipo.GroupBordersVisible = false;
            this.lyCtrlGroupDatosTipo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyGroupBoxDatosTipo});
            this.lyCtrlGroupDatosTipo.Location = new System.Drawing.Point(0, 0);
            this.lyCtrlGroupDatosTipo.Name = "lyCtrlGroupDatosTipo";
            this.lyCtrlGroupDatosTipo.Size = new System.Drawing.Size(345, 88);
            this.lyCtrlGroupDatosTipo.TextVisible = false;
            // 
            // lyGroupBoxDatosTipo
            // 
            this.lyGroupBoxDatosTipo.CustomizationFormText = "Datos del Tipo de Producto";
            this.lyGroupBoxDatosTipo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.CtrlItemNombreTipo});
            this.lyGroupBoxDatosTipo.Location = new System.Drawing.Point(0, 0);
            this.lyGroupBoxDatosTipo.Name = "lyGroupBoxDatosTipo";
            this.lyGroupBoxDatosTipo.Size = new System.Drawing.Size(325, 68);
            this.lyGroupBoxDatosTipo.Text = "Datos del Tipo de Producto";
            // 
            // CtrlItemNombreTipo
            // 
            this.CtrlItemNombreTipo.Control = this.txtNombreTipo;
            this.CtrlItemNombreTipo.Location = new System.Drawing.Point(0, 0);
            this.CtrlItemNombreTipo.Name = "CtrlItemNombreTipo";
            this.CtrlItemNombreTipo.Size = new System.Drawing.Size(301, 31);
            this.CtrlItemNombreTipo.Text = "Descripción";
            this.CtrlItemNombreTipo.TextSize = new System.Drawing.Size(54, 13);
            // 
            // btnCancelarTipo
            // 
            this.btnCancelarTipo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTipo.Appearance.Options.UseFont = true;
            this.btnCancelarTipo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarTipo.ImageOptions.Image")));
            this.btnCancelarTipo.Location = new System.Drawing.Point(223, 146);
            this.btnCancelarTipo.Name = "btnCancelarTipo";
            this.btnCancelarTipo.Size = new System.Drawing.Size(134, 45);
            this.btnCancelarTipo.TabIndex = 29;
            this.btnCancelarTipo.Text = "Cancelar";
            this.btnCancelarTipo.Click += new System.EventHandler(this.btnCancelarTipo_Click);
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTipo.Appearance.Options.UseFont = true;
            this.btnGuardarTipo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarTipo.ImageOptions.Image")));
            this.btnGuardarTipo.Location = new System.Drawing.Point(36, 146);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(134, 45);
            this.btnGuardarTipo.TabIndex = 28;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // lblIDTipo
            // 
            this.lblIDTipo.Location = new System.Drawing.Point(12, 208);
            this.lblIDTipo.Name = "lblIDTipo";
            this.lblIDTipo.Size = new System.Drawing.Size(11, 13);
            this.lblIDTipo.TabIndex = 27;
            this.lblIDTipo.Text = "ID";
            this.lblIDTipo.Visible = false;
            // 
            // txtIDTipo
            // 
            this.txtIDTipo.Location = new System.Drawing.Point(29, 205);
            this.txtIDTipo.Name = "txtIDTipo";
            this.txtIDTipo.Size = new System.Drawing.Size(26, 20);
            this.txtIDTipo.TabIndex = 26;
            this.txtIDTipo.Visible = false;
            // 
            // frmXtraEdicionTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 233);
            this.Controls.Add(this.btnCancelarTipo);
            this.Controls.Add(this.btnGuardarTipo);
            this.Controls.Add(this.lblIDTipo);
            this.Controls.Add(this.txtIDTipo);
            this.Controls.Add(this.lyCtrlDatosTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXtraEdicionTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-----";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraEdicionTipos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlDatosTipo)).EndInit();
            this.lyCtrlDatosTipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreTipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyCtrlGroupDatosTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyGroupBoxDatosTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlItemNombreTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDTipo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl lyCtrlDatosTipo;
        private DevExpress.XtraEditors.TextEdit txtNombreTipo;
        private DevExpress.XtraLayout.LayoutControlGroup lyCtrlGroupDatosTipo;
        private DevExpress.XtraLayout.LayoutControlGroup lyGroupBoxDatosTipo;
        private DevExpress.XtraLayout.LayoutControlItem CtrlItemNombreTipo;
        private DevExpress.XtraEditors.SimpleButton btnCancelarTipo;
        private DevExpress.XtraEditors.SimpleButton btnGuardarTipo;
        private DevExpress.XtraEditors.LabelControl lblIDTipo;
        private DevExpress.XtraEditors.TextEdit txtIDTipo;
    }
}