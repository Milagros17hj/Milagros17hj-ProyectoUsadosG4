using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal class DatosServicioAdicional
    {
        private int idServicio;
        private string descripcion;
        private decimal costo;

        public int IdServicio { get => idServicio; set => idServicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Costo { get => costo; set => costo = value; }

        public string MostrarServicio()
        {
            return "Servicio: " + Descripcion + " - Costo: " + Costo;
        }
    }
}