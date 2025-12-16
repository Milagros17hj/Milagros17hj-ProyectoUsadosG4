using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectoUsadosGrupo4
{
    internal class DatosEmpleado : DatosPersona
    {
        public int IdEmpleado { get; set; }
        public int IdRol { get; set; }
        public string RolNombre { get; set; }

        public string MostrarDatosEmpleado()
        {
            return $"Empleado: {Nombre} {PrimerApellido} - Rol: {RolNombre}";
        }
    }
}