namespace ProyectoUsadosGrupo4
{
    public class DatosUsuario
    {
        private int idUsuario;
        private string numeroIdentificacion;
        private string nombreUsuario;      
        private string contrasena;
        private string email;
        private bool esEmpleado;
        private int idEstado;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Email { get => email; set => email = value; }
        public bool EsEmpleado { get => esEmpleado; set => esEmpleado = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }

        public string MostrarUsuario()
        {
            return "Usuario: " + NombreUsuario + " - Email: " + Email +
                   " - Estado: " + IdEstado + " - EsEmpleado: " + EsEmpleado;
        }
    }
}