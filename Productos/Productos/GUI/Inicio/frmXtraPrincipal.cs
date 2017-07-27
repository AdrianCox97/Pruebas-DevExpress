using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Inicio
{
    public partial class frmXtraPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Cierre oCierre = new Cierre();

        public static BDCarrilloEntities bdCarrillo = null;
        public static Sesiones sesion = null;
        ArchivosLocales oExtras = new ArchivosLocales();
        XtraUserControl frmProductosUC, frmCategoriasTiposUC, frmPuntoVentaUC, frmRegistroComprasUC,
            frmRegistroVentasUC, frmPersonalUC, frmActividadesUC, frmSisApartadoUC, frmEstadisticasUC, 
            frmRegistroAnomaliasUC;
        

        public frmXtraPrincipal()
        {
            InitializeComponent();

            CargarFormularios();
            ValidarAdmin();
        }

        XtraUserControl CreateUserControl(String strNombreUserControl, XtraUserControl frmXtraUC)
        {
            XtraUserControl result = frmXtraUC;
            result.Name = strNombreUserControl + "UC";
            result.Text = strNombreUserControl;
            return result;
        }

        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;

            XtraUserControl frmUserControl = null;

            switch (e.Element.Text)
            {
                case "Productos":
                    frmUserControl = frmProductosUC;
                    break;
                case "Tipos y Departamentos":
                    frmUserControl = frmCategoriasTiposUC;
                    break;
                case "Punto de Venta":
                    frmUserControl = frmPuntoVentaUC;
                    break;
                case "Compras":
                    frmUserControl = frmRegistroComprasUC;
                    break;
                case "Ventas":
                    frmUserControl = frmRegistroVentasUC;
                    break;
                case "Personal":
                    frmUserControl = frmPersonalUC;
                    break;
                case "Registro de Actividades":
                    frmUserControl = frmActividadesUC;
                    break;
                case "Anomalías":
                    frmUserControl = frmRegistroAnomaliasUC;
                    break;
                case "Sistema de Apartado":
                    frmUserControl = frmSisApartadoUC;
                    break;
                case "Compra-Venta":
                    frmUserControl = frmEstadisticasUC;
                    break;
                default:
                    frmUserControl = null;
                    break;
            }
            frmUserControl.Refresh();
            tabbedView.AddDocument(frmUserControl);
            tabbedView.ActivateDocument(frmUserControl);
        }

        //void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
        //    accordionCtrlNavegacion.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        //}

        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }

        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            accordionCtrlNavegacion.SelectedElement = null;
            if (tabbedView.Documents.Count == 0)
            {
                accordionCtrlNavegacion.SelectedElement = null;
            }
        }

        void RecreateUserControls(DocumentEventArgs e)
        {
            switch (e.Document.Caption)
            {
                case "Productos":
                    frmProductosUC = CreateUserControl("Productos", new Productos.frmXtraUCProductos());
                    break;
                case "Tipos y Departamentos":
                    frmCategoriasTiposUC = CreateUserControl("Tipos y Departamentos", new TiposCategorias.frmXtraUCTiposCategorias());
                    break;
                case "Punto de Venta":
                    frmPuntoVentaUC = CreateUserControl("Punto de Venta", new Ventas.frmXtraUCPuntoVenta());
                    break;
                case "Compras":
                    frmRegistroComprasUC = CreateUserControl("Compras", new Compras.frmXtraUCRegistroC());
                    break;
                case "Ventas":
                    frmRegistroVentasUC = CreateUserControl("Ventas", new Ventas.frmXtraUCRegistroVentas());
                    break;
                case "Personal":
                    frmPersonalUC = CreateUserControl("Personal", new Personal.frmXtraUCPersonal());
                    break;
                case "Registro de Actividades":
                    frmActividadesUC = CreateUserControl("Registro de Actividades", new Actividades.frmXtraUCRegistroAcciones());
                    break;
                case "Anomalías":
                    frmRegistroAnomaliasUC = CreateUserControl("Anomalías", new Anomalias.frmXtraUCRegistroAnomalias());
                    break;
                case "Sistema de Apartado":
                    frmSisApartadoUC = CreateUserControl("Sistema de Apartado", new Apartado.frmXtraUCSistemaA());
                    break;
                case "Compra-Venta":
                    frmEstadisticasUC = CreateUserControl("Compra-Venta", new Estadisticas.frmXtraUCEstadisticas());
                    break;
            }
        }

        private void CargarFormularios()
        {
            Productos.frmXtraUCProductos.bdCarrillo = bdCarrillo;
            Productos.frmXtraUCProductos.sesion = sesion;

            TiposCategorias.frmXtraUCTiposCategorias.sesion = sesion;
            TiposCategorias.frmXtraUCTiposCategorias.bdCarrillo = bdCarrillo;

            Ventas.frmXtraUCPuntoVenta.datos = bdCarrillo;
            Ventas.frmXtraUCPuntoVenta.sesion = sesion;
            Ventas.frmXtraUCRegistroVentas.datos = bdCarrillo;

            Compras.frmXtraUCRegistroC.datos = bdCarrillo;

            Personal.frmXtraUCPersonal.bdCarrillo = bdCarrillo;
            Personal.frmXtraUCPersonal.sesion = sesion;

            Anomalias.frmXtraUCRegistroAnomalias.bdCarrillo = bdCarrillo;

            Apartado.frmXtraUCSistemaA.datos = bdCarrillo;

            frmProductosUC = CreateUserControl("Productos", new Productos.frmXtraUCProductos());
            frmCategoriasTiposUC = CreateUserControl("Tipos y Departamentos", new TiposCategorias.frmXtraUCTiposCategorias());
            frmPuntoVentaUC = CreateUserControl("Punto de Venta", new Ventas.frmXtraUCPuntoVenta());
            frmRegistroComprasUC = CreateUserControl("Compras", new Compras.frmXtraUCRegistroC());
            frmRegistroVentasUC = CreateUserControl("Ventas", new Ventas.frmXtraUCRegistroVentas());
            frmPersonalUC = CreateUserControl("Personal", new Personal.frmXtraUCPersonal());
            frmActividadesUC = CreateUserControl("Registro de Actividades", new Actividades.frmXtraUCRegistroAcciones());
            frmRegistroAnomaliasUC = CreateUserControl("Anomalías", new Anomalias.frmXtraUCRegistroAnomalias());
            frmSisApartadoUC = CreateUserControl("Sistema de Apartado", new Apartado.frmXtraUCSistemaA());
            frmEstadisticasUC = CreateUserControl("Compra-Venta", new Estadisticas.frmXtraUCEstadisticas());
        }

        private void frmXtraPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oCierre.Accion != 'A' && oCierre.Accion != 'S')
            {
                frmXtraCierre frmCierre = new frmXtraCierre(oCierre);

                frmCierre.ShowDialog();
            }

            switch (oCierre.Accion)
            {
                case 'S':
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.Show();
                    break;
                case 'A':
                    Application.Exit();
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void ValidarAdmin()
        {
            if (!sesion.Admin)
            {
                gpPersonal.Visible = false;
            }
        }
    }

    public class Cierre
    {
        public Char Accion { set; get; }
    }
}