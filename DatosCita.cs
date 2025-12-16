using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal class DatosCita
    {
        private int idCita;
        private int idCliente;
        private int idAgente;
        private int idRecepcionista;
        private DateTime fecha;
        private TimeSpan hora;
        private int idEstado;
        private int idVehiculo;


        public int IdCita { get => idCita; set => idCita = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdAgente { get => idAgente; set => idAgente = value; }
        public int IdRecepcionista { get => idRecepcionista; set => idRecepcionista = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public TimeSpan Hora { get => hora; set => hora = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }



        public string MostrarCita()
        {
            return "Cita: " + Fecha.ToShortDateString() + " " + Hora +
                   " - Cliente: " + IdCliente + " - Agente: " + IdAgente;
        }
    }
}