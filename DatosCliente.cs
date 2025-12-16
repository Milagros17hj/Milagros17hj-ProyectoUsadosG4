using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal class DatosCliente : DatosPersona
    {
        public int IdCliente { get; set; }
        public int IdEstado { get; set; }
        public string TipoIdentificacionNombre { get; set; }
        public string Provincia { get; set; }

        public string MostrarDatosCliente()
        {
            return $"Cliente: {Nombre} {PrimerApellido} {SegundoApellido} - Identificación: {NumeroIdentificacion}";
        }
    }
}