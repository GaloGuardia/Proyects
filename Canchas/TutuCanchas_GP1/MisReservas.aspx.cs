using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutuCanchas.DTO;

namespace TutuCanchas_GP1
{
    public partial class MisReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<ReservasDTO> disp = TutuCanchas.Business.Reservas.GetMisReservas(1);
            gvReservas.DataSource = disp;
            gvReservas.DataBind();
        }

        protected void gvCanchas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //ToDo: Eliminar reserva.
        }
    }
}