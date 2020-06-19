using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutuCanchas.Business;
using TutuCanchas.DTO;

namespace TutuCanchas_GP1
{
    public partial class Buscador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si la sesion no esta iniciada, volvemos al Login.
            if (Session["usuario"] == null)
                Response.Redirect("Login.aspx");


            //Inicializo los controles.
            if (!Page.IsPostBack)
            {
                ddTipoCancha.Items.Add("Futbol 5 - Sintetico");
                ddTipoCancha.Items.Add("Futbol 5 - Cemento");
                ddTipoCancha.Items.Add("Futbol 11 - Pasto");

                ddZonas.Items.Clear();
                ddZonas.Items.Add("Zona 1");
                ddZonas.Items.Add("Zona 2");

                cal.SelectedDate = DateTime.Today;
            }
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            List<DisponibilidadDTO> disp = TutuCanchas.Business.Reservas.BuscarDiponibilidad(
                cal.SelectedDate, 1, 1, 5000);

            gvCanchas.DataSource = disp;
            gvCanchas.DataBind();
        }

        protected void gvCanchas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Reservar")
            {
                int row = Convert.ToInt32(e.CommandArgument);

                DateTime fecha = DateTime.Parse(gvCanchas.Rows[row].Cells[1].Text);
                int idCancha = Convert.ToInt32(gvCanchas.Rows[row].Cells[4].Text);
                CheckBox cb = ((CheckBox)gvCanchas.Rows[row].Cells[5].Controls[0]);

                if (!cb.Checked)
                {
                    ReservasDTO reserva = new ReservasDTO();
                    reserva.FechaHora = fecha;
                    reserva.IdCancha = idCancha;

                    Session.Add("nuevaReserva", reserva);
                    Response.Redirect("Reserva.aspx"); 
                }
                else
                {
                    lbMsg.Text = "Este horario ya se encuentra reservado!";
                }

            }
        }
    }
}