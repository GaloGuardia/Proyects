using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VentasCapas.DTO;

namespace TP2_VentasCapas
{
    public partial class frmArticulosABM : Form
    {
        public ArticuloDTO articulo { get; set; }

        public frmArticulosABM()
        {
            InitializeComponent();
        }

        private void frmArticulosABM_Load(object sender, EventArgs e)
        {
            //Es update?
            if (articulo != null)
            {                
                txId.Text = articulo.Id.ToString();
                txNombre.Text = articulo.Nombre;
                txDescripcion.Text = articulo.Descripcion;
                nuPrecioCompra.Value = articulo.PrecioCompra;
                nuPrecioVenta.Value = articulo.PrecioVenta;
                nuStock.Value = articulo.Stock;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            //Es update?
            if (articulo != null)
            {
                articulo.Nombre = txNombre.Text;
                articulo.Descripcion = txDescripcion.Text;
                articulo.PrecioCompra = nuPrecioCompra.Value;
                articulo.PrecioVenta = nuPrecioVenta.Value;
                articulo.Stock = Convert.ToInt32(nuStock.Value);

                VentasCapas.Business.Articulos.Actualizar(articulo);
                this.Close();
            }
            else
            {
                //Es create.
                articulo = new ArticuloDTO();

                articulo.Nombre = txNombre.Text;
                articulo.Descripcion = txDescripcion.Text;
                articulo.PrecioCompra = nuPrecioCompra.Value;
                articulo.PrecioVenta = nuPrecioVenta.Value;
                articulo.Stock = Convert.ToInt32(nuStock.Value);

                VentasCapas.Business.Articulos.Crear(articulo);
                this.Close();
            }
        }
    }
}
