using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace ECommerce
{
    public partial class Signin : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public bool validarEmail(string email)
        {
            return Regex.IsMatch(email, "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        }

        public bool validarTelefono(string tel)
        {
            if (tel.Length == 9)
            {
                return Regex.IsMatch(tel, "^([0-9]{4})[-]*([0-9]{4})$"); //Número de teléfono con 8 números.
            }
            else if (tel.Length == 13)
            {
                return Regex.IsMatch(tel, "^([0-9]{3})[ ]*([0-9]{4})[-]*([0-9]{4})$"); //Número de teléfono con 11 números.
            }
            return false;
        }

        public bool validarDireccion(string dir)
        {
            int count = 0;

            foreach (var number in dir)
            {
                if (char.IsNumber(number))
                {
                    count += 1;
                }
            }
            
            switch (count)
            {
                case 1:
                    if ((Regex.IsMatch(dir, @"\s\w+(\s){1}([0-9]{1})$")) || (Regex.IsMatch(dir, @"\s\w+(\s){1}\w+(\s){1}([0-9]{1})$")))                        
                    {
                        return false;
                    }
                    else if ((Regex.IsMatch(dir, @"\w+(\s){1}([0-9]{1})$")) || (Regex.IsMatch(dir, @"\w+(\s){1}\w+(\s){1}([0-9]{1})$"))) // Dirección con un número
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 2:
                    if ((Regex.IsMatch(dir, @"\s\w+(\s){1}([0-9]{1})([0-9]{1})$")) || (Regex.IsMatch(dir, @"\s\w+(\s){1}\w+(\s){1}([0-9]{1})([0-9]{1})$")))                        
                    {
                        return false;
                    }
                    else if ((Regex.IsMatch(dir, @"\w+(\s){1}([0-9]{1})([0-9]{1})$")) || (Regex.IsMatch(dir, @"\w+(\s){1}\w+(\s){1}([0-9]{1})([0-9]{1})$"))) // Dirección con dos números
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 3:
                    if ((Regex.IsMatch(dir, @"\s\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})$")) || (Regex.IsMatch(dir, @"\s\w+(\s){1}\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})$")))                  
                    {
                        return false;
                    }
                    else if ((Regex.IsMatch(dir, @"\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})$")) || (Regex.IsMatch(dir, @"\w+(\s){1}\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})$"))) // Dirección con tres números
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case 4:
                    if ((Regex.IsMatch(dir, @"\s\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})([0-9]{1})$")) || (Regex.IsMatch(dir, @"\s\w+(\s){1}\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})([0-9]{1})$")))                        
                    {
                        return false;
                    }
                    else if ((Regex.IsMatch(dir, @"\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})([0-9]{1})$")) || (Regex.IsMatch(dir, @"\w+(\s){1}\w+(\s){1}([0-9]{1})([0-9]{1})([0-9]{1})([0-9]{1})$"))) // Dirección con cuatro números
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;                    
            }            
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string user = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string contraseña2 = txtContraseña2.Text.Trim();
            string email = txtEmail.Text.Trim();
            string tel = txtTel.Text;
            string dir = txtDir.Text;

            if ((nombre != "") && (user != "") && (contraseña != "") && (contraseña2 != "") && (email != "") && (tel != "") && (dir != ""))
            {
                if (contraseña == contraseña2)
                {
                    if (validarEmail(email) == true)
                    {
                        if (validarTelefono(tel) == true)
                        {
                            if (validarDireccion(dir) == true)
                            {
                                ClienteDTO usuario = ws.Registrarse(nombre, dir, tel, email, user, contraseña);
                                Response.Redirect("Login.aspx");
                            }
                            else
                            {
                                lbMsg.Text = "La dirección de domicilio es incorrecta.<br>(Ej.: Av Libertador 666 / Perú 750)";
                            }
                        }
                        else
                        {
                            lbMsg.Text = "El número de teléfono ingresado no es válido.<br>(Ej.: 1111-2222 / 011 2222-3333)";
                        }
                    }
                    else
                    {
                        lbMsg.Text = "El correo electronico ingresado no es válido.";
                    }
                }
                else
                {
                    lbMsg.Text = "Las contraseñas no coinciden.";
                }
            }
            else
            {
                lbMsg.Text = "Complete todos los campos para registrarse.";
            }
        }
    }
}