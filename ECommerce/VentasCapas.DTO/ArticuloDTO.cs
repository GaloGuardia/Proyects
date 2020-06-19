using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasCapas.DTO
{
    [Serializable]
    public class ArticuloDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Stock { get; set; }
    }
}
