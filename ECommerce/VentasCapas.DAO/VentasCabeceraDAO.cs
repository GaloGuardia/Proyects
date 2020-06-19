using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public static class VentasCabeceraDAO
    {
        public static VentasCabeceraDTO AgregarCabecera(int idCliente, string fecha)
        {
            using (SqlConnection con = new SqlConnection(DAOHelper.connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO VentasCabecera (Id, Fecha, IdCliente, IdVendedor, Observaciones) VALUES ([id], '[fecha]', '[idcliente]', 1, 'Entrega en casa.')";

                    int id = DAOHelper.GetNextId("VentasCabecera");
                    cmd.CommandText = cmd.CommandText.Replace("[id]", id.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[fecha]", fecha.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[idcliente]", idCliente.ToString());

                    cmd.ExecuteNonQuery();

                    VentasCabeceraDTO aux = new VentasCabeceraDTO();
                    aux.Id = id;

                    return aux;
                }
            }
        }
    }
}
