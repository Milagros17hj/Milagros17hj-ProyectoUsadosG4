using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUsadosGrupo4
{
    internal static class Sesiones
    {
        public static string Usuario { get; set; }
        public static int Rol { get; set; }   // 1=Admin, 2=Agente, 3=Recepcionista, 4=Cajera, 0=Cliente
        public static string Identificacion { get; set; }
        public static int IdEmpleado { get; set; }
        public static int IdCliente { get; set; }

    }
}