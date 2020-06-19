using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public static class ArticuloDAO
    {
        public static List<ArticuloDTO> ReadAll()
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM ARTICULOS",
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ArticuloDTO> list = GetList(dt);

            return list;
        }

        public static List<ArticuloDTO> ConsultarByNombre(string nombre)
        {
            DataTable dt = new DataTable();

            nombre = nombre.Replace("'", "");

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM ARTICULOS WHERE Nombre LIKE '%" + nombre + "%'",
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ArticuloDTO> list = GetList(dt);

            return list;

        }

        public static ArticuloDTO AgregarArticulo(int id)
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM ARTICULOS WHERE Id = " + id,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ArticuloDTO> list = GetList(dt);

            if (list.Count > 0)
                return list[0];

            return null;

        }

        private static List<ArticuloDTO> GetList(DataTable dt)
        {
            ArticuloDTO dto;
            List<ArticuloDTO> lista = new List<ArticuloDTO>();

            //Itero entre los registros para armar la Lista de DTO.
            foreach (DataRow dr in dt.Rows)
            {
                dto = new ArticuloDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("Nombre")) dto.Nombre = (string)dr["Nombre"];
                if (!dr.IsNull("Descripcion")) dto.Descripcion = (string)dr["Descripcion"];
                if (!dr.IsNull("PrecioVenta")) dto.PrecioVenta = (decimal)dr["PrecioVenta"];
                if (!dr.IsNull("PrecioCompra")) dto.PrecioCompra = (decimal)dr["PrecioCompra"];
                if (!dr.IsNull("Stock")) dto.Stock = (int)dr["Stock"];

                lista.Add(dto);
            }

            return lista;
        }

        public static int Update(ArticuloDTO articulo)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(DAOHelper.connectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Articulos SET Nombre='[nombre]', Descripcion='[descripcion]', PrecioVenta=[precioVenta], PrecioCompra=[precioCompra], Stock='[stock]' WHERE Id=" + articulo.Id;

                    //Reemplazo los valores de los campos en el query.
                    cmd.CommandText = cmd.CommandText.Replace("[nombre]", articulo.Nombre);
                    cmd.CommandText = cmd.CommandText.Replace("[descripcion]", articulo.Descripcion);
                    cmd.CommandText = cmd.CommandText.Replace("[precioVenta]", articulo.PrecioVenta.ToString(System.Globalization.CultureInfo.InvariantCulture));       //El "InvariantCulture" es para que el ToString() ponga los decimales con '.' en lugar de ','.
                    cmd.CommandText = cmd.CommandText.Replace("[precioCompra]", articulo.PrecioCompra.ToString(System.Globalization.CultureInfo.InvariantCulture));     //El "InvariantCulture" es para que el ToString() ponga los decimales con '.' en lugar de ','.
                    cmd.CommandText = cmd.CommandText.Replace("[stock]", articulo.Stock.ToString());

                    //Ejecuto el update.
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }

        public static ArticuloDTO Create(ArticuloDTO articulo)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(DAOHelper.connectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"INSERT INTO Articulos (Id, Nombre, Descripcion, PrecioVenta, PrecioCompra, Stock) 
                                        VALUES ([id],'[nombre]','[descripcion]',[precioVenta],[precioCompra],[stock])";

                    int proximoId = DAOHelper.GetNextId("Articulos");
                    articulo.Id = proximoId;

                    //Reemplazo los valores de los campos en el query.
                    cmd.CommandText = cmd.CommandText.Replace("[id]", proximoId.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[nombre]", articulo.Nombre);
                    cmd.CommandText = cmd.CommandText.Replace("[descripcion]", articulo.Descripcion);
                    cmd.CommandText = cmd.CommandText.Replace("[precioVenta]", articulo.PrecioVenta.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[precioCompra]", articulo.PrecioCompra.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[stock]", articulo.Stock.ToString());

                    //Ejecuto el update.
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return articulo;
        }

        public static int Delete(int id)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(DAOHelper.connectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE Articulos WHERE Id=" + id;

                    //Ejecuto el delete.
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
    }
}
