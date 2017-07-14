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
        double total = 0;
        Abonos abono = null;
        Folio folio = null;

        public frmXtraCobroA(List<Model.Productos> lista, List<int> unidades, String Total, Sesiones ses)
        {
            InitializeComponent();
            Compra = lista;
            Cantidad = unidades;
            txtTotal.Text = Total;
            sesion = ses;
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            double cambio = total - Convert.ToInt32(txtMonto.Text);
            if (cambio < 0)
            {
                txtCambio.ForeColor = Color.Black;
                txtCambio.Text = (cambio * -1).ToString();
            }
            else
            {
                txtCambio.ForeColor = Color.Red;
                txtCambio.Text = (cambio * -1).ToString();
            }
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
                }
            }
            else
            {
                if (Convert.ToDouble(txtCambio.Text) >= 0)
                {
                    if (XtraMessageBox.Show("Con este abono se completará el pago de los productos adquiridos.", "Abonando", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        RealizarAbono();
                    }
                }
                else
                {
                    if (XtraMessageBox.Show("El abono ha sido realizado.", "Abonando", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        RealizarAbono();
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
                    abono = new Abonos();
                    folio = datos.Folio.Find(_idFolio);
                }
                abono.IdFolio = folio.IdFolio;
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
                    txtFaltante.Text = folio.Faltante.ToString();
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