using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CeramicaCarrillo.Model;

namespace CeramicaCarrillo.GUI.Ventas
{
    public partial class frmXtraUCPuntoVenta : DevExpress.XtraEditors.XtraUserControl
    {
        public static BDCarrilloEntities datos = null;
        public static Sesiones sesion = null;
        List<Model.Productos> _compra;
        List<int> Cantidad;
        bool seleccionado = false;
        int posicion = -1, unidades = 0;
        double precio = 0;

        public frmXtraUCPuntoVenta()
        {
            InitializeComponent();
            _compra = new List<Model.Productos>();
            Cantidad = new List<int>();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            tmrHora.Start();
            asignarEmpleado();
            cargarDatos();
            quitarSeleccion(sender, e);
        }

        private void lueBuscar_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lueBuscar.Text);

                agregarProducto(id);
            }
            catch { }
            lueBuscar.Text = "Seleccionar...";
            cargarDatos();
            quitarSeleccion(sender, e);
        }

        private void agregarProducto(int id)
        {
            Model.Productos producto = datos.Productos.Find(id);
            Categorias cat = datos.Categorias.Find(producto.idCategoria);
            TipoProductos tp = datos.TipoProductos.Find(cat.idTipoProducto);
            _compra.Add(producto);
            Cantidad.Add(0);
            float total = obtenerTotal(0, producto.PrecioVenta);
            gvDatos.Rows.Add(producto.Descripcion, tp.NombreTipo + "/" + cat.NombreCategoria, producto.PrecioVenta, 0, total);
            obtenerTotalCompra();
        }

        private void obtenerTotalCompra()
        {
            float total = 0;
            for (int i = 0; i < gvDatos.Rows.Count; i++)
            {
                total += float.Parse(gvDatos.Rows[i].Cells[4].Value.ToString());
            }
            txtTotal.Text = total.ToString();
        }

        private float obtenerTotal(int unidades, double precioV)
        {
            return float.Parse((unidades * precioV).ToString());
        }

        private void gvDatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!seleccionado)
            {
                seleccionado = true;
                seUnidades.Enabled = true;
                btnEliminar.Enabled = true;
            }
            posicion = e.RowIndex;
            seUnidades.ResetText();
            precio = Convert.ToDouble(gvDatos.Rows[posicion].Cells[2].Value);
            unidades = Convert.ToInt32(gvDatos.Rows[posicion].Cells[3].Value);
            seUnidades.Value = unidades;
        }

        private void cargarDatos()
        {
            var datasource = (from u in datos.Productos
                              join c in datos.Categorias on u.idCategoria equals c.idCategoria
                              join t in datos.TipoProductos on c.idTipoProducto equals t.idTipoProducto
                              where u.Unidades > 0 && u.Status== true
                              select new
                              {
                                  u.IdProductos,
                                  u.Descripcion,
                                  c.NombreCategoria,
                                  t.NombreTipo,
                                  u.Unidades,
                                  u.PrecioVenta
                              }).ToList();
            try
            {
                foreach (var item in datasource.ToArray())
                {
                    foreach (var prod in _compra)
                    {
                        if (item.IdProductos == prod.IdProductos)
                        {
                            datasource.Remove(item);
                        }
                    }
                }
            }
            catch { }
            lueBuscar.Properties.DataSource = datasource;
            lueBuscar.Properties.DisplayMember = "IdProductos";
            lueBuscar.Properties.ValueMember = "IdProductos";
            lueBuscar.Text = "Seleccionar...";
        }

        private void quitarSeleccion(object sender, EventArgs e)
        {

            try
            {
                gvDatos.Rows[posicion].Selected = false;
            }
            catch { }
            posicion = -1;
            seleccionado = false;
            seUnidades.Enabled = false;
            btnEliminar.Enabled = false;
            seUnidades.ResetText();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                _compra.RemoveAt(posicion);
                Cantidad.RemoveAt(posicion);
                gvDatos.Rows.RemoveAt(posicion);
                quitarSeleccion(sender, e);
                cargarDatos();
                obtenerTotalCompra();
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (_compra.Count > 0)
            {
                frmXtraCobroV.datos = datos;
                frmXtraCobroV cobro = new frmXtraCobroV(_compra, Cantidad, txtTotal.Text, sesion);
                if (cobro.ShowDialog() == DialogResult.OK)
                {
                    gvDatos.Rows.Clear();
                }
            }
            else
            {
                XtraMessageBox.Show("No tiene produtos en la lista.");
            }
        }

        

        private void seUnidades_EditValueChanged(object sender, EventArgs e)
        {
            if (seleccionado)
            {
                int disponibles = Convert.ToInt32(_compra[posicion].Unidades);
                unidades = Convert.ToInt32(seUnidades.EditValue);
                if (disponibles >= unidades)
                {
                    Cantidad[posicion] = unidades;
                    gvDatos.Rows[posicion].Cells[3].Value = unidades;
                    gvDatos.Rows[posicion].Cells[4].Value = obtenerTotal(unidades, precio).ToString();
                    obtenerTotalCompra();
                }
                else
                {
                    XtraMessageBox.Show("No se pueden agregar más unidades porque se ha alcanzado el límite.\n\nLa cantidad disponible para este producto es de: " + disponibles + " unidades.");
                    seUnidades.EditValue = disponibles;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCompra(sender, e);
        }

        private void btnApartar_Click(object sender, EventArgs e)
        {
            if (_compra.Count > 0)
            {
                frmXtraCobroA.datos = datos;
                frmXtraCobroA cobro = new frmXtraCobroA(_compra, Cantidad, txtTotal.Text, sesion);
                if (cobro.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < gvDatos.Rows.Count; i++)
                    {
                        gvDatos.Rows.RemoveAt(i);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No tiene produtos en la lista.");
            }
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            txtHora.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void asignarEmpleado()
        {
            var empleado = (from e in datos.Personal
                               where e.Usuario == sesion.Usuario
                               select new {
                                   e.Nombre,
                                   e.Apellido,
                                   e.Puesto
                               }).First();
            txtEmpleado.Text = empleado.Nombre + " " + empleado.Apellido;
            txtPuesto.Text = empleado.Puesto;
        }

        private void limpiarCompra(object sender, EventArgs e)
        {
            quitarSeleccion(sender, e);
            gvDatos.Rows.Clear();
            _compra = new List<CeramicaCarrillo.Model.Productos>();
            Cantidad = new List<int>();
            precio = 0;
        }

    }
}
