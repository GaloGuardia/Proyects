using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VentasCapas.DAO;
using VentasCapas.DTO;

namespace VentasCapasService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://ventasservice.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<ArticuloDTO> GetArticulos()
        {
            return ArticuloDAO.ReadAll();
        }

        [WebMethod]
        public ClienteDTO Login(string usuario, string contraseña)
        {
            return ClienteDAO.IniciarSesion(usuario, contraseña);
        }

        [WebMethod]
        public ClienteDTO Registrarse(string nombre, string direccion, string telefono, string email, string usuario, string contraseña)
        {
            return ClienteDAO.NewAccount(nombre, direccion, telefono, email, usuario, contraseña);
        }

        [WebMethod]
        public List<ArticuloDTO> GetArticulosByNombre(string nombre)
        {
            return ArticuloDAO.ConsultarByNombre(nombre);
        }

        [WebMethod]
        public ArticuloDTO ArticuloForCarrito(int id)
        {
            return ArticuloDAO.AgregarArticulo(id);
        }

        [WebMethod]
        public VentasCabeceraDTO Cabecera(int idCliente, string fecha)
        {
            return VentasCabeceraDAO.AgregarCabecera(idCliente, fecha);
        }

        [WebMethod]
        public VentasDetalleDTO Detalle(int idcabecera, int idarticulo, string precioventa)
        {
            string punto = precioventa.Replace(",",".");
            return VentasDetalleDAO.AgregarDetalle(idcabecera, idarticulo, punto);
        }
    }
}
