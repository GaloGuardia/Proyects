using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //--
            if (this.Page.Session["cliente"] == null)
                Response.Redirect("~/Login.aspx");

            ClienteDTO cliente = (ClienteDTO)this.Page.Session["cliente"];
            string nombre = cliente.Nombre.Trim();
            lbUser.Text = "Cliente: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombre);


            Total();

        }

        protected void btCarrito_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Carrito.aspx");
        }

        public void Total()
        {
            decimal total;

            if  (Session["carrito"] != null)
            { 
                List<ArticuloDTO> list = (List<ArticuloDTO>)Session["carrito"];

                total = list.Sum(x => x.PrecioVenta);

                lblTotal.Text = "Total: $" + total.ToString();
            }
            else
            {
                total = 0;
                lblTotal.Text = "Total: $0";
            } 

        }

    }
}