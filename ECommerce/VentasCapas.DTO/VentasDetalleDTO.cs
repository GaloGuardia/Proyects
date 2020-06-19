using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasCapas.DTO
{
    [Serializable]
    public class VentasDetalleDTO
    {
        public int Id { get; set; }
        public int IdVentaCabecera { get; set; }
        public int IdArticulo { get; set; }
        public string PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
    }
}
