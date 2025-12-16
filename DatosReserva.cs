using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal class DatosReserva
    {
        private int idReserva;
        private int idCita;
        private int idVehiculo;
        private DateTime fechaReserva;
        private int idEstado;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public int IdCita { get => idCita; set => idCita = value; }
        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }

        public string MostrarReserva()
        {
            return "Reserva: " + IdReserva + " - Vehículo: " + IdVehiculo +
                   " - Fecha: " + FechaReserva.ToString("dd/MM/yyyy") +
                   " - Estado: " + IdEstado;
        }
    }
}