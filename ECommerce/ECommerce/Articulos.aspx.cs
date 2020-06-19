using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Articulos : System.Web.UI.Page
    {

        Service.ServiceSoapClient ws = new ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        protected void btFiltrar_Click(object sender, ImageClickEventArgs e)
        {
            CargarArticulosByNombre();
        }

        private void CargarArticulos()
        {
            List<ArticuloDTO> articulos = new List<Service.ArticuloDTO>();
            articulos = ws.GetArticulos().ToList();
            GenerarBaldozas(articulos);
        }

        private void CargarArticulosByNombre()
        {
            //ToDo: Reemplzar lista de Articulos "de prueba" por consulta al WebService.
            List<ArticuloDTO> articulos = new List<Service.ArticuloDTO>();
            articulos = ws.GetArticulosByNombre(txFiltro.Text).ToList();
            GenerarBaldozas(articulos);
        }

        private void BtAgregarAlCarrito_Click(object sender, ImageClickEventArgs e)
        {
            //Boton de "Agregar al Carrito":

            ImageButton btAdd = (ImageButton)sender;
            int id = Convert.ToInt32(btAdd.Attributes["articuloid"]);
            lbMsg.Text = "Articulo Agregado Correctamente";

            List<ArticuloDTO> carrito = new List<Service.ArticuloDTO>();
            if (Session["carrito"] != null)
            {
                carrito = (List<ArticuloDTO>)Session["carrito"];
            }

            ArticuloDTO articulo;
            articulo = ws.ArticuloForCarrito(id);

            if (articulo.Descripcion.Length > 50)
            {
                articulo.Descripcion = articulo.Descripcion.Substring(0, 50) + "...";
            }

            decimal precio = articulo.PrecioVenta;
            
            carrito.Add(articulo);
            Session.Add("carrito", carrito);


            ((Site)this.Master).Total();


            if (Timer.Enabled == true)
            {
                lblTimer.Text = "0";
            }

            Timer.Enabled = true;
        }

        private void GenerarBaldozas(List<ArticuloDTO> articulos)
        {
            //En base a una lista de ArticuloDTO, genero todas las baldozas.

            dvArticulos.Controls.Clear();
            foreach (ArticuloDTO articulo in articulos)
            {
                var div = new HtmlGenericControl("div");
                div.Attributes.Add("class", "col-md-4");


                var divCard = new HtmlGenericControl("div");
                divCard.Attributes.Add("class", "card mb-4 box-shadow");


                var bt = new ImageButton();
                bt.CssClass = "img-fluid";
                bt.Attributes.Add("idarticulo", articulo.Id.ToString());
                string path = Server.MapPath("~/Articulos/");
                if (System.IO.File.Exists(path + "/id" + articulo.Id + ".png"))
                {
                    bt.ImageUrl = "../Articulos/id" + articulo.Id + ".png";
                }
                else
                {
                    bt.ImageUrl = "../Articulos/nophoto.png";
                }


                var btAdd = new ImageButton();
                btAdd.Attributes.Add("articuloid", articulo.Id.ToString());
                btAdd.ImageUrl = "../Img/cart24.png";
                btAdd.Click += BtAgregarAlCarrito_Click;


                var divBody = new HtmlGenericControl("div");
                divBody.Attributes.Add("class", "card-body");

                Label lbNombre = new Label();
                lbNombre.Attributes.Add("class", "card-text");
                lbNombre.Text = "Nombre: " + articulo.Nombre + "<br />";

                Label lbDescripcion = new Label();
                lbDescripcion.Attributes.Add("class", "card-text");
                if (articulo.Descripcion.Length > 50)
                {
                    lbDescripcion.Text = "Descripción: " + articulo.Descripcion.Substring(0, 50) + "...<br/>";
                }                    
                else
                {
                    lbDescripcion.Text = "Descripción: " + articulo.Descripcion + "<br/>";
                }                 

                Label lbPrecio = new Label();
                lbPrecio.Attributes.Add("class", "card-text");
                lbPrecio.Text = "Precio: " + articulo.PrecioVenta + "<br/>";

                Label lbStock = new Label();
                lbStock.Attributes.Add("class", "card-text");
                lbStock.Text = "Stock: " + articulo.Stock + "<br/>";


                divBody.Controls.Add(bt);
                divBody.Controls.Add(lbNombre);
                divBody.Controls.Add(lbDescripcion);
                divBody.Controls.Add(lbPrecio);
                divBody.Controls.Add(lbStock);
                divBody.Controls.Add(btAdd);

                divCard.Controls.Add(divBody);
                div.Controls.Add(divCard);

                dvArticulos.Controls.Add(div);
            }
        }

        protected void Timer_Tick(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(lblTimer.Text);
            total += 1;
            lblTimer.Text = total.ToString();

            if (lblTimer.Text == "3")
            {
                lbMsg.Text = "";
                Timer.Enabled = false;
                lblTimer.Text = "0";
            }
        }
    }
}