using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.Business
{
    public static class Articulos
    {
        public static List<ArticuloDTO> ConsultarTodos()
        {
            return DAO.ArticuloDAO.ReadAll();
        }

        public static List<ArticuloDTO> ConsultarPorNombre(string filtro)
        {
            filtro = filtro.Replace("'", "");
            return DAO.ArticuloDAO.ConsultarByNombre("WHERE Nombre LIKE '%" + filtro + "%'");
        }

        public static ArticuloDTO ConsultarPorId(int id)
        {
            var list = DAO.ArticuloDAO.ConsultarByNombre("WHERE ID = " + id.ToString());
            if (list.Count > 0)
                return list[0];
            else
                return null;
        }

        public static void Actualizar(ArticuloDTO articulo)
        {
            //Validaciones?
            DAO.ArticuloDAO.Update(articulo);
        }

        public static void Crear(ArticuloDTO articulo)
        {
            //Validaciones?
            DAO.ArticuloDAO.Create(articulo);
        }

        public static void Eliminar(int id)
        {
            //Validaciones?
            DAO.ArticuloDAO.Delete(id);
        }
    }
}
