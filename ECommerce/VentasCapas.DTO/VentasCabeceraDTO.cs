using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VentasCapas.DTO
{
    [Serializable]
    public class VentasCabeceraDTO
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public string Observaciones { get; set; }
    }
}
