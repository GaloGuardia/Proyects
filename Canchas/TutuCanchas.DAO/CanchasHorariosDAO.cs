using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;

namespace TutuCanchas.DAO
{
    public static class CanchasHorariosDAO
    {

        public static List<CanchasHorariosDTO> Buscar(int idZona, decimal precioMax, int idTipo, string dia)
        {
            DataTable dt = new DataTable();
            string query = 
                @"SELECT CanchasHorarios.* 
                FROM Canchas
                JOIN Clubes ON Canchas.IdClub = Clubes.Id
                JOIN CanchasHorarios ON Canchas.Id = CanchasHorarios.IdCancha
                WHERE Clubes.IdClubesZonas = [idZona] AND CanchasHorarios.Precio <= [precioMax] AND Canchas.IdCanchasTipos = [idTipo]
                AND Dia = '[dia]'";

            query = query.Replace("[idZona]", idZona.ToString());
            query = query.Replace("[precioMax]", precioMax.ToString());
            query = query.Replace("[idTipo]", idTipo.ToString());
            query = query.Replace("[dia]", dia);

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                query, DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            CanchasHorariosDTO dto;
            List<CanchasHorariosDTO> lista = new List<CanchasHorariosDTO>();

            //Itero entre los registros para armar la Lista de DTO.
            foreach (DataRow dr in dt.Rows)
            {
                dto = new CanchasHorariosDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("IdCancha")) dto.IdCancha = (int)dr["IdCancha"];
                if (!dr.IsNull("HoraDesde")) dto.HoraDesde = (int)dr["HoraDesde"];
                if (!dr.IsNull("HoraHasta")) dto.HoraHasta = (int)dr["HoraHasta"];
                if (!dr.IsNull("Dia")) dto.Dia = (string)dr["Dia"];
                if (!dr.IsNull("Precio")) dto.Precio = (decimal)dr["Precio"];

                lista.Add(dto);
            }

            return lista;
        }
    }
}
