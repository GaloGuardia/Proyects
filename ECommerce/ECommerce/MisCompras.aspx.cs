using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class MisCompras : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<ArticuloDTO> compra = new List<ArticuloDTO>();

                gvCompras.DataSource = compra;
                gvCompras.DataBind();

                if (gvCompras.Rows.Count == 0)
                {
                    lblMsg.Text = "No ha comprado ningun articulo recientemente.";
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
    }
}