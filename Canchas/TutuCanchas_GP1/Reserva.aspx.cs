using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutuCanchas.DTO;

namespace TutuCanchas_GP1
{
    public partial class Reserva : System.Web.UI.Page
    {
        ReservasDTO reserva = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nuevaReserva"] == null)
                Response.Redirect("Buscador.aspx");

            reserva = (ReservasDTO)Session["nuevaReserva"];


            if (!Page.IsPostBack)
            {
                lbReserva.Text = string.Format("Fecha: {0}, IdCancha: {1}, Precio: {2}", 
                    reserva.FechaHora, reserva.IdCancha, reserva.Precio);
            }
        }

        protected void btCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Buscador.aspx");
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {

            ReservasDTO aux = TutuCanchas.Business.Reservas.CrearReserva(reserva);
            Response.Redirect("Buscador.aspx");

        }
    }
}