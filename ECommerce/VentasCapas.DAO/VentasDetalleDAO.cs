using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public static class VentasDetalleDAO
    {
        public static VentasDetalleDTO AgregarDetalle(int idcabecera, int idarticulo, string precioventa)
        {
            using (SqlConnection con = new SqlConnection(DAOHelper.connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO VentasDetalle (Id, IdVentaCabecera, IdArticulo, PrecioUnitario, Cantidad) VALUES ([id], '[idventacabecera]', '[idarticulo]', '[precio]', 1)";

                    int id = DAOHelper.GetNextId("VentasDetalle");
                    cmd.CommandText = cmd.CommandText.Replace("[id]", id.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[idventacabecera]", idcabecera.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[idarticulo]", idarticulo.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[precio]", precioventa.ToString());

                    cmd.ExecuteNonQuery();

                    VentasDetalleDTO aux = new VentasDetalleDTO();

                    return aux;
                }
            }
        }
    }
}
