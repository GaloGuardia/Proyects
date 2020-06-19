using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Carrito : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<ArticuloDTO> articulos = new List<ArticuloDTO>();
                articulos = (List<ArticuloDTO>)Session["carrito"];                
                gvCarrito.DataSource = articulos;
                gvCarrito.DataBind();

                if (gvCarrito.Rows.Count == 0)
                {
                    lblMsg.Text = "No ha agregado ningun articulo al carrito.";
                    btnComprar.Visible = false;
                    btnVaciar.Visible = false;
                }
                else
                {
                    lblMsg.Text = "";
                }

            }
            catch
            {
                throw;
            }
        }

        protected void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                Session["carrito"] = null;
                gvCarrito.DataSource = Session["carrito"];
                gvCarrito.DataBind();

                if (gvCarrito.Rows.Count == 0)
                {
                    lblMsg.Text = "No ha agregado ningun articulo al carrito.";
                    btnComprar.Visible = false;
                    btnVaciar.Visible = false;
                }
                else
                {
                    lblMsg.Text = "";
                }
            }
            catch
            {
                throw;
            }
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            // VentasCabecera
            string fecha = DateTime.Now.ToString();
            ClienteDTO cliente = (ClienteDTO)Session["cliente"];
            int id = cliente.Id;

            VentasCabeceraDTO cabecera = ws.Cabecera(id, fecha);
            int idcabecera = cabecera.Id;

            foreach(GridViewRow articulo in gvCarrito.Rows)
            {
                // VentasDetalle
                int idarticulo = Convert.ToInt32(articulo.Cells[1].Text);
                string precioventa = articulo.Cells[4].Text;

                VentasDetalleDTO detalle = ws.Detalle(idcabecera, idarticulo, precioventa);
            }

            Session["carrito"] = null;
            gvCarrito.DataSource = Session["carrito"];
            gvCarrito.DataBind();

            ((Site)this.Master).Total();

            Response.Redirect("Articulos.aspx");
        }
    }
}