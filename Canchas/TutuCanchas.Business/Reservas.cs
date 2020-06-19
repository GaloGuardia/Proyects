using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;

namespace TutuCanchas.Business
{
    public static class Reservas
    {
        public static List<DisponibilidadDTO> BuscarDiponibilidad(DateTime fecha, int tipoCancha, int zona, decimal precioMax)
        {

            //PARA BUSCAR LA DISPONIBILIDAD:
            //----------------------------------------------------------------------------------------
            //1- OBTENGO EL "DIA" (DE LA SEMANA) QUE CORRESPONDE A LA FECHA DE BUSQUEDA
            //2- OBTENGO LOS HORARIOS DE LAS CANCHAS QUE COINCIDEN CON EL FILTRO (DIA, TIPO, MONTO...)
            //3- OBTENGO TODAS LAS RESERVAS DE LA FECHA BUSCADA
            //4- RECORRO LOS HORARIOS, HORA POR HORA, PARA ARMAR EL LISTADO DE "DISPONIBLES"
            //5- AQUELLOS HORARIOS CON RESERVA, LOS MARCO COMO "OCUPADOS"

            string dia = GetDiaByFecha(fecha);
            List<CanchasHorariosDTO> horarios = DAO.CanchasHorariosDAO.Buscar(zona, precioMax, tipoCancha, dia);
            List<ReservasDTO> reservas = DAO.ReservasDAO.ReadAll(fecha);
            List<DisponibilidadDTO> disponibilidad = new List<DisponibilidadDTO>();

            for (int i = 0; i < horarios.Count; i++)
            {
                //Recorro hora x hora todo el rango disponible para esta cancha / dia.
                for (int hora = horarios[i].HoraDesde; hora < horarios[i].HoraHasta; hora++)
                {
                    DisponibilidadDTO disp = new DisponibilidadDTO();

                    disp.Dia = dia;
                    disp.FechaHora = fecha.AddHours(hora);
                    disp.Horario = hora;
                    disp.IdCancha = horarios[i].IdCancha;

                    //Chequeo si ya esta reservado:
                    ReservasDTO reserva = reservas.Find(x => x.IdCancha == disp.IdCancha && x.FechaHora == disp.FechaHora);
                    if (reserva == null)
                    {
                        //Si no encontre ninguna reserva para esta cancha, fecha y horario,
                        //la agrego como disponible.
                        disp.Ocupada = false;
                    }
                    else
                    {
                        //Sino, la marco como ocupada.
                        disp.Ocupada = true;
                    }

                    disponibilidad.Add(disp);
                }
            }

            return disponibilidad;
        }

        public static ReservasDTO CrearReserva(ReservasDTO reserva)
        {
            return DAO.ReservasDAO.Create(reserva);
        }

        private static string GetDiaByFecha(DateTime fecha)
        {
            string dia = string.Empty;

            switch (fecha.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    dia = "DOMINGO";
                    break;
                case DayOfWeek.Monday:
                    dia = "LUNES";
                    break;
                case DayOfWeek.Tuesday:
                    dia = "MARTES";
                    break;
                case DayOfWeek.Wednesday:
                    dia = "MIERCOLES";
                    break;
                case DayOfWeek.Thursday:
                    dia = "JUEVES";
                    break;
                case DayOfWeek.Friday:
                    dia = "VIERNES";
                    break;
                case DayOfWeek.Saturday:
                    dia = "SABADO";
                    break;
                default:
                    break;
            }

            return dia;
        }

        public static List<ReservasDTO> GetMisReservas(int idUsuario)
        {
            return DAO.ReservasDAO.ReadAll(idUsuario);
        }
    }
}
