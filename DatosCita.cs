using libreriaIII2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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



        public bool InsertarCita()
        {
            try
            {
                string cmd = "INSERT INTO Cita (id_cliente, id_agente, id_recepcionista, fecha, hora, id_estado, id_vehiculo) " +
                             "VALUES (" + IdCliente + ", " + IdAgente + ", " + IdRecepcionista + ", '" +
                             Fecha.ToString("yyyy-MM-dd") + "', '" + Hora + "', " + IdEstado + ", " + IdVehiculo + ")";

                Utilidades.ejecutar(cmd);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar cita 001: " + ex.Message);
                return false;
            }
        }
    }
}
