using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal abstract class DatosPersona
    {
        public string TipoIdentificacionNombre { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdProvincia { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public int IdEstado { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaVencimientoDoc { get; set; }

        public string MostrarDatos()
        {
            return $"Persona: {Nombre} {PrimerApellido} - Identificación: {NumeroIdentificacion}";
        }
    }
}