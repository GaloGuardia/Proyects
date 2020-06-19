using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;

namespace TutuCanchas.DAO
{
    public static class ReservasDAO
    {
        public static List<ReservasDTO> ReadAll()
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Reservas",
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ReservasDTO> lista = GetList(dt);

            return lista;
        }

        public static List<ReservasDTO> ReadAll(DateTime fecha)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Reservas WHERE FechaHora >= '[desde]' AND FechaHora < '[hasta]'";

            query = query.Replace("[desde]", fecha.ToString("yyyy-MM-dd"));
            query = query.Replace("[hasta]", fecha.AddDays(1).ToString("yyyy-MM-dd"));

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                query,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ReservasDTO> lista = GetList(dt);

            return lista;
        }

        public static List<ReservasDTO> ReadAll(int idUsuario)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Reservas WHERE IdUsuario = [idUsuario]";

            query = query.Replace("[idUsuario]", idUsuario.ToString());

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                query,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            List<ReservasDTO> lista = GetList(dt);

            return lista;
        }

        private static List<ReservasDTO> GetList(DataTable dt)
        {
            ReservasDTO dto;
            List<ReservasDTO> lista = new List<ReservasDTO>();

            //Itero entre los registros para armar la Lista de DTO.
            foreach (DataRow dr in dt.Rows)
            {
                dto = new ReservasDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("IdCancha")) dto.IdCancha = (int)dr["IdCancha"];
                if (!dr.IsNull("FechaHora")) dto.FechaHora = (DateTime)dr["FechaHora"];
                if (!dr.IsNull("IdUsuario")) dto.IdUsuario = (int)dr["IdUsuario"];
                if (!dr.IsNull("Precio")) dto.Precio = (decimal)dr["Precio"];
                if (!dr.IsNull("Estado")) dto.Estado = (string)dr["Estado"];
                if (!dr.IsNull("IdCanchasHorarios")) dto.IdCanchasHorarios = (int)dr["IdCanchasHorarios"];

                lista.Add(dto);
            }

            return lista;
        }

        public static ReservasDTO Create(ReservasDTO reserva)
        {
            using (SqlConnection con = new SqlConnection(DAOHelper.connectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO Reservas (Id, IdCancha, FechaHora, IdUsuario, Precio, Estado) VALUES ([id], [idCancha], '[fechaHora]', 1, [precio], 'CONFIRMADO')";

                    int id = DAOHelper.GetNextId("Reservas");
                    cmd.CommandText = cmd.CommandText.Replace("[id]", id.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[idCancha]", reserva.IdCancha.ToString());
                    cmd.CommandText = cmd.CommandText.Replace("[fechaHora]", reserva.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.CommandText = cmd.CommandText.Replace("[precio]", reserva.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture));

                    cmd.ExecuteNonQuery();

                    reserva.Id = id;
                    return reserva;
                }
            }
        }
    }
}
