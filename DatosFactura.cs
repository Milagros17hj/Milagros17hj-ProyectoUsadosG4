using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal class DatosFactura
    {
        private int idFactura;
        private int idReserva;
        private int idCajera;
        private DateTime fecha;
        private int idTipoPago;
        private decimal total;

        public int IdFactura { get => idFactura; set => idFactura = value; }
        public int IdReserva { get => idReserva; set => idReserva = value; }
        public int IdCajera { get => idCajera; set => idCajera = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdTipoPago { get => idTipoPago; set => idTipoPago = value; }
        public decimal Total { get => total; set => total = value; }

        public string MostrarFactura()
        {
            return "Factura: " + IdFactura + " - Reserva: " + IdReserva +
                   " - Cajera: " + IdCajera + " - Total: " + Total +
                   " - Fecha: " + Fecha.ToString("dd/MM/yyyy");
        }
    }
}