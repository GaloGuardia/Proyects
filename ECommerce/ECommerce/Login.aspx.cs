using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Login : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session.Clear();
                lbMsg.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lbMsg.Text = ex.Message;
            }
        }

        protected void btIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txUsuario.Text) 
                    || string.IsNullOrWhiteSpace(txContraseña.Text))
                {
                    lbMsg.Text = "Ingrese nombre de usuario y contraseña.";
                    return;
                }

                ClienteDTO cliente = null;
                cliente = ws.Login(txUsuario.Text, txContraseña.Text);

                if (cliente != null)
                {
                    cliente.Nombre = txUsuario.Text;
                    Session.Add("cliente", cliente);
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    lbMsg.Text = "Nombre de usuario o contraseña incorrecta.";
                }
            }
            catch (Exception ex)
            {
                lbMsg.Text = ex.Message;
            }
        }
    }
}