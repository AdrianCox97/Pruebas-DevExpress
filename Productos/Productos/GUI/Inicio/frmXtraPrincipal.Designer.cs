namespace CeramicaCarrillo.GUI.Inicio
{
    partial class frmXtraPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXtraPrincipal));
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanelNavegacion = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionCtrlNavegacion = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnVentas = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPuntoVenta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSistemaAp = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnBodega = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProductos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCategorias_Tipos = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRegistroCompra = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnRegistroVenta = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.gpPersonal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.ribCtrlMenuPrincipal = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanelNavegacion.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionCtrlNavegacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelNavegacion});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanelNavegacion
            // 
            this.dockPanelNavegacion.Controls.Add(this.dockPanel_Container);
            this.dockPanelNavegacion.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanelNavegacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockPanelNavegacion.ID = new System.Guid("a045df26-1503-4d9a-99c1-a531310af22b");
            this.dockPanelNavegacion.Location = new System.Drawing.Point(0, 53);
            this.dockPanelNavegacion.Name = "dockPanelNavegacion";
            this.dockPanelNavegacion.Options.ShowAutoHideButton = false;
            this.dockPanelNavegacion.Options.ShowCloseButton = false;
            this.dockPanelNavegacion.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelNavegacion.Size = new System.Drawing.Size(200, 536);
            this.dockPanelNavegacion.Text = "Navegación";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionCtrlNavegacion);
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(193, 509);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionCtrlNavegacion
            // 
            this.accordionCtrlNavegacion.AllowItemSelection = true;
            this.accordionCtrlNavegacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.accordionCtrlNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionCtrlNavegacion.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup,
            this.btnVentas,
            this.btnBodega,
            this.accordionControlElement1,
            this.gpPersonal,
            this.accordionControlElement2});
            this.accordionCtrlNavegacion.Location = new System.Drawing.Point(0, 0);
            this.accordionCtrlNavegacion.Name = "accordionCtrlNavegacion";
            this.accordionCtrlNavegacion.Size = new System.Drawing.Size(193, 509);
            this.accordionCtrlNavegacion.TabIndex = 0;
            this.accordionCtrlNavegacion.Text = "accordionControl";
            this.accordionCtrlNavegacion.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.accordionControl_SelectedElementChanged);
            // 
            // mainAccordionGroup
            // 
            this.mainAccordionGroup.Expanded = true;
            this.mainAccordionGroup.HeaderVisible = false;
            this.mainAccordionGroup.Name = "mainAccordionGroup";
            this.mainAccordionGroup.Text = "mainGroup";
            // 
            // btnVentas
            // 
            this.btnVentas.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnPuntoVenta,
            this.btnSistemaAp});
            this.btnVentas.Expanded = true;
            this.btnVentas.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Text = "Ventas";
            // 
            // btnPuntoVenta
            // 
            this.btnPuntoVenta.Expanded = true;
            this.btnPuntoVenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPuntoVenta.ImageOptions.Image")));
            this.btnPuntoVenta.Name = "btnPuntoVenta";
            this.btnPuntoVenta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPuntoVenta.Text = "Punto de Venta";
            // 
            // btnSistemaAp
            // 
            this.btnSistemaAp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSistemaAp.ImageOptions.Image")));
            this.btnSistemaAp.Name = "btnSistemaAp";
            this.btnSistemaAp.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSistemaAp.Text = "Sistema de Apartado";
            // 
            // btnBodega
            // 
            this.btnBodega.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnProductos,
            this.btnCategorias_Tipos});
            this.btnBodega.Expanded = true;
            this.btnBodega.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btnBodega.Name = "btnBodega";
            this.btnBodega.Text = "Bodega";
            // 
            // btnProductos
            // 
            this.btnProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageOptions.Image")));
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProductos.Text = "Productos";
            // 
            // btnCategorias_Tipos
            // 
            this.btnCategorias_Tipos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias_Tipos.ImageOptions.Image")));
            this.btnCategorias_Tipos.Name = "btnCategorias_Tipos";
            this.btnCategorias_Tipos.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCategorias_Tipos.Text = "Tipos y Departamentos";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnRegistroCompra,
            this.btnRegistroVenta,
            this.accordionControlElement6});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Registros";
            // 
            // btnRegistroCompra
            // 
            this.btnRegistroCompra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroCompra.ImageOptions.Image")));
            this.btnRegistroCompra.Name = "btnRegistroCompra";
            this.btnRegistroCompra.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRegistroCompra.Text = "Compras";
            // 
            // btnRegistroVenta
            // 
            this.btnRegistroVenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroVenta.ImageOptions.Image")));
            this.btnRegistroVenta.Name = "btnRegistroVenta";
            this.btnRegistroVenta.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnRegistroVenta.Text = "Ventas";
            // 
            // gpPersonal
            // 
            this.gpPersonal.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement5});
            this.gpPersonal.Expanded = true;
            this.gpPersonal.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.gpPersonal.Name = "gpPersonal";
            this.gpPersonal.Text = "Personal";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Personal";
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.ImageOptions.Image")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "Registro de Actividades";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement4});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "Estadísticas";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement4.ImageOptions.Image")));
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Compra-Venta";
            // 
            // tabbedView
            // 
            this.tabbedView.RootContainer.Element = null;
            this.tabbedView.DocumentClosed += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.tabbedView_DocumentClosed);
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // ribCtrlMenuPrincipal
            // 
            this.ribCtrlMenuPrincipal.ExpandCollapseItem.Id = 0;
            this.ribCtrlMenuPrincipal.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribCtrlMenuPrincipal.ExpandCollapseItem});
            this.ribCtrlMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ribCtrlMenuPrincipal.MaxItemId = 2;
            this.ribCtrlMenuPrincipal.Name = "ribCtrlMenuPrincipal";
            this.ribCtrlMenuPrincipal.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuPrincipal.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribCtrlMenuPrincipal.ShowToolbarCustomizeItem = false;
            this.ribCtrlMenuPrincipal.Size = new System.Drawing.Size(778, 53);
            this.ribCtrlMenuPrincipal.Toolbar.ShowCustomizeItem = false;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "VS2010";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement6.ImageOptions.Image")));
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement6.Text = "Anomalías";
            // 
            // frmXtraPrincipal
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 589);
            this.Controls.Add(this.dockPanelNavegacion);
            this.Controls.Add(this.ribCtrlMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXtraPrincipal";
            this.Ribbon = this.ribCtrlMenuPrincipal;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerámica Carrillo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXtraPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanelNavegacion.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionCtrlNavegacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribCtrlMenuPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelNavegacion;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionCtrlNavegacion;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnBodega;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProductos;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCategorias_Tipos;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribCtrlMenuPrincipal;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnVentas;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPuntoVenta;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSistemaAp;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRegistroCompra;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnRegistroVenta;
        private DevExpress.XtraBars.Navigation.AccordionControlElement gpPersonal;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
    }
}