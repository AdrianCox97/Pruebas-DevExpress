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
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Ventas
{
    public partial class frmXtraCobroA : DevExpress.XtraEditors.XtraForm
    {
        public static BDCarrilloEntities datos = null;
        Sesiones sesion;
        public static int _idFolio = 0;
        List<Model.Productos> Compra;
        List<int> Cantidad;
        double falta = 0;
        Abonos abono = null;
        Folio folio = null;

        public frmXtraCobroA(List<Model.Productos> lista, List<int> unidades, String Total, Sesiones ses)
        {
            InitializeComponent();
            Compra = lista;
            Cantidad = unidades;
            txtTotal.Text = Total;
            sesion = ses;
            falta = Convert.ToDouble(Total);
        }

        public frmXtraCobroA()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto.Text != string.Empty)
            {
                double faltante = falta - Convert.ToDouble(txtMonto.Text);
                if (faltante <= 0)
                {
                    txtFaltante.Text = "0";
                    txtCambio.ForeColor = Color.Black;
                    txtCambio.Text = "0";
                    txtCambio.Text = ((falta - Convert.ToDouble(txtMonto.Text))* -1).ToString();
                }
                else
                {
                    txtFaltante.Text = (faltante).ToString();
                    txtCambio.ForeColor = Color.Green;
                    txtCambio.Text = "0";
                }
            }
            else { txtCambio.Text = "0"; txtFaltante.Text = falta.ToString(); }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            validarCobro();
        }

        private void validarCobro()
        {
            if (_idFolio <= 0)
            {
                if (XtraMessageBox.Show("¿Desea realizar el apartado?", "Apartando", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    realizarCompra();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                if (Convert.ToDouble(txtCambio.Text) == 0 && Convert.ToDouble(txtFaltante.Text) == 0)
                {
                    if (XtraMessageBox.Show("Con este abono se completará el pago de los productos adquiridos.", "Abonando", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        RealizarAbono();
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    if (XtraMessageBox.Show("El abono ha sido realizado.", "Abonando", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        RealizarAbono();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void realizarCompra()
        {
            try
            {
                folio = new Folio();
                abono = new Abonos();
                double totalVenta = 0;
                folio.FechaVenta = DateTime.Now;
                folio.IdPersonal = sesion.Id;
                folio.Status = false;
                datos.Folio.Add(folio);
                datos.SaveChanges();
                int idFolio = Convert.ToInt32((from f in datos.Folio orderby f.IdFolio descending select f.IdFolio).ToList()[0]);
                DetalleFolio detalle;
                for (int i = 0; i < Compra.Count; i++)
                {
                    detalle = new DetalleFolio();
                    detalle.IdFolio = idFolio;
                    Model.Productos producto = datos.Productos.Find(Compra[i].IdProductos);
                    producto.Unidades -= Cantidad[i];
                    detalle.IdProductos = producto.IdProductos;
                    detalle.Precio = producto.PrecioVenta;
                    detalle.Unidades = Cantidad[i];
                    detalle.Total = Cantidad[i] * detalle.Precio;
                    totalVenta += detalle.Total;
                    datos.DetalleFolio.Add(detalle);
                    datos.SaveChanges();
                }
                folio = datos.Folio.Find(idFolio);
                folio.TotalVenta = totalVenta;
                abono.IdFolio = idFolio;
                abono.MontoAbono = Convert.ToDouble(txtMonto.Text);
                folio.Faltante = ((folio.TotalVenta - abono.MontoAbono) <= 0) ? 0 : (folio.TotalVenta - abono.MontoAbono);
                folio.Status = (folio.Faltante == 0) ? true : false;
                abono.FechaAbono = DateTime.Now;
                datos.Abonos.Add(abono);
                datos.SaveChanges();
                Hide();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error: " + e.Message);
            }
        }

        
        private void RealizarAbono()
        {
            try
            {
                if (folio == null)
                {
                    folio = new Folio();
                }

                folio = datos.Folio.Find(_idFolio);
                abono = new Abonos();
                abono.IdFolio = folio.IdFolio;
                abono.MontoAbono = Convert.ToDouble(txtMonto.Text);
                folio.Faltante = ((folio.Faltante - abono.MontoAbono) <= 0) ? 0 : (folio.Faltante - abono.MontoAbono);
                folio.Status = (folio.Faltante == 0) ? true : false;
                abono.FechaAbono = DateTime.Now;
                datos.Abonos.Add(abono);
                datos.SaveChanges();
                Hide();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error: " + e.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frmXtraCobroA_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                if (_idFolio != 0)
                {
                    folio = datos.Folio.Find(_idFolio);
                    falta = folio.Faltante;
                    txtFaltante.Text = folio.Faltante.ToString();
                    txtTotal.Text = folio.TotalVenta.ToString();
                }
                else
                {
                    txtFaltante.Text = txtTotal.Text;
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error: " + e.Message);
            }
        }
    }
}