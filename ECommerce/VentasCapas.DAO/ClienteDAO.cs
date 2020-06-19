using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public static class ClienteDAO
    {
        public static List<ClienteDTO> ReadAll()
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM CLIENTES",
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ClienteDTO> list = GetList(dt);

            return list;
        }

        public static ClienteDTO IniciarSesion(string usuario, string contraseña)
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM CLIENTES WHERE Usuario = '[usuario]' AND Contraseña = '[contraseña]'"
                .Replace("[usuario]", usuario)
                .Replace("[contraseña]", contraseña),
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }                        

            List<ClienteDTO> list = GetList(dt);

            if (list.Count > 0)
                return list[0];

            return null;

        }

        public static ClienteDTO NewAccount(string nombre, string direccion, string telefono, string email, string usuario, string contraseña)
        {
            using (SqlConnection con = new SqlConnection(DAOHelper.connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Clientes (Id, Nombre, Direccion, Telefono, Email, Usuario, Contraseña) VALUES ([id], '[nombre]', '[direccion]', '[telefono]', '[email]', '[usuario]', '[contraseña]')";

                    int id = DAOHelper.GetNextId("Clientes");
                    cmd.CommandText = cmd.CommandText.Replace("[id]", id.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[nombre]", nombre.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[direccion]", direccion.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[telefono]", telefono.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[email]", email.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[usuario]", usuario.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[contraseña]", contraseña.ToString());

                    cmd.ExecuteNonQuery();

                    ClienteDTO aux = new ClienteDTO();

                    return aux;
                }
            }
        }

        public static List<ClienteDTO> GetList(DataTable dt)
        {
            ClienteDTO dto;
            List<ClienteDTO> lista = new List<ClienteDTO>();

            //Itero entre los registros para armar la Lista de DTO.
            foreach (DataRow dr in dt.Rows)
            {
                dto = new ClienteDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("Nombre")) dto.Nombre = (string)dr["Nombre"];
                if (!dr.IsNull("Direccion")) dto.Direccion = (string)dr["Direccion"];
                if (!dr.IsNull("Telefono")) dto.Telefono = (string)dr["Telefono"];
                if (!dr.IsNull("Email")) dto.Email = (string)dr["Email"];

                lista.Add(dto);
            }

            return lista;
        }
    }
}
