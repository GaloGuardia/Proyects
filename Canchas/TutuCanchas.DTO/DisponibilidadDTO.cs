using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DTO
{
    public class DisponibilidadDTO
    {
        public DateTime FechaHora { get; set; }
        public string Dia { get; set; }
        public int Horario { get; set; }
        public int IdCancha { get; set; }
        public bool Ocupada { get; set; }
    }
}
