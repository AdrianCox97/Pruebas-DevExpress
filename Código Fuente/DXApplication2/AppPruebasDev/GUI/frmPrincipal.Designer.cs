namespace AppPruebasDev.GUI
{
    partial class frmPrincipal
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
            this.btnDivisiones = new DevExpress.XtraEditors.SimpleButton();
            this.btnCarreras = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrupos = new DevExpress.XtraEditors.SimpleButton();
            this.btnAlumnos = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnDivisiones
            // 
            this.btnDivisiones.AllowFocus = false;
            this.btnDivisiones.Location = new System.Drawing.Point(223, 180);
            this.btnDivisiones.Name = "btnDivisiones";
            this.btnDivisiones.Size = new System.Drawing.Size(108, 91);
            this.btnDivisiones.TabIndex = 7;
            this.btnDivisiones.Text = "Divisiones";
            this.btnDivisiones.Click += new System.EventHandler(this.btnDivisiones_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.AllowFocus = false;
            this.btnCarreras.Location = new System.Drawing.Point(54, 180);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Size = new System.Drawing.Size(108, 91);
            this.btnCarreras.TabIndex = 6;
            this.btnCarreras.Text = "Carreras";
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.AllowFocus = false;
            this.btnGrupos.Location = new System.Drawing.Point(223, 51);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(108, 91);
            this.btnGrupos.TabIndex = 5;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.AllowFocus = false;
            this.btnAlumnos.Location = new System.Drawing.Point(54, 51);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(108, 91);
            this.btnAlumnos.TabIndex = 4;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 322);
            this.Controls.Add(this.btnDivisiones);
            this.Controls.Add(this.btnCarreras);
            this.Controls.Add(this.btnGrupos);
            this.Controls.Add(this.btnAlumnos);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDivisiones;
        private DevExpress.XtraEditors.SimpleButton btnCarreras;
        private DevExpress.XtraEditors.SimpleButton btnGrupos;
        private DevExpress.XtraEditors.SimpleButton btnAlumnos;
    }
}