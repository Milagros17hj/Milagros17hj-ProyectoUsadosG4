using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaIII2025;

namespace ProyectoUsadosGrupo4
{
    public partial class frmlogin : Form
    {
        public DataSet ds;
        private DatosUsuario usuarioActual;

        public frmlogin()
        {
            InitializeComponent();
            
        }

        //Boton SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTON INGRESAR
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        //BOTON INGRESAR
        private void Ingresar()
        {
            try
            {
                // VALIDACIÓN DE CAMPOS VACÍOS
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Debe ingresar los datos", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    limpiar();
                    return;
                }

                // CODIFICAR CONTRASEÑA
                string contraseña = Utilidades.codificar(txtClave.Text.Trim());

                string cmd = string.Format(
                    "SELECT id_usuario, numero_identificacion, nombre_usuario, contrasena, email, id_estado, es_empleado " +
                    "FROM Usuario WHERE (email = '{0}' OR nombre_usuario = '{0}') AND contrasena = '{1}'",
                    txtUsuario.Text.Trim(), contraseña);

                ds = Utilidades.ejecutar(cmd);

                // VALIDAR USUARIO
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de credenciales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    return;
                }

                DataRow fila = ds.Tables[0].Rows[0];

                // CREAR OBJETO USUARIO ACTUAL
                usuarioActual = new DatosUsuario
                {
                    IdUsuario = Convert.ToInt32(fila["id_usuario"]),
                    NumeroIdentificacion = fila["numero_identificacion"].ToString(),
                    NombreUsuario = fila["nombre_usuario"].ToString(),
                    Contrasena = fila["contrasena"].ToString(),
                    Email = fila["email"].ToString(),
                    IdEstado = Convert.ToInt32(fila["id_estado"]),
                    EsEmpleado = Convert.ToBoolean(fila["es_empleado"])
                };

                // SI ESTÁ INHABILITADO NO ENTRA
                if (usuarioActual.IdEstado != 1)
                {
                    MessageBox.Show("El usuario está inhabilitado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // VERIFICAR ROL DEL USUARIO
                if (usuarioActual.EsEmpleado)
                {
                    string cmdRol = string.Format(
                        "SELECT id_empleado, id_rol FROM Empleado WHERE numero_identificacion = '{0}'",
                        usuarioActual.NumeroIdentificacion);

                    DataSet dsRol = Utilidades.ejecutar(cmdRol);

                    if (dsRol.Tables[0].Rows.Count > 0)
                    {
                        int idRol = Convert.ToInt32(dsRol.Tables[0].Rows[0]["id_rol"]);
                        Sesiones.Rol = idRol;
                        Sesiones.IdEmpleado = Convert.ToInt32(dsRol.Tables[0].Rows[0]["id_empleado"]);

                        switch (idRol)
                        {
                            case 1: usuarioActual.Rol = "Administrador"; break;
                            case 2: usuarioActual.Rol = "Recepcionista"; break;
                            case 3: usuarioActual.Rol = "Agente"; break;
                            case 4: usuarioActual.Rol = "Cajera"; break;
                            default: usuarioActual.Rol = "Empleado"; break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró rol.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    Sesiones.Rol = 0; // Cliente
                    usuarioActual.Rol = "Cliente";

                    string cmdCliente = string.Format(
                        "SELECT id_cliente FROM Cliente WHERE numero_identificacion = '{0}'",
                        usuarioActual.NumeroIdentificacion);

                    DataSet dsCliente = Utilidades.ejecutar(cmdCliente);

                    if (dsCliente.Tables[0].Rows.Count > 0)
                    {
                        Sesiones.IdCliente = Convert.ToInt32(dsCliente.Tables[0].Rows[0]["id_cliente"]);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente en la tabla Cliente.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Sesiones.Usuario = usuarioActual.NombreUsuario;
                MessageBox.Show("Bienvenido al sistema.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ABRIR MENÚ Y PASAR USUARIO
                this.Hide();
                frmMenu menu = new frmMenu(usuarioActual); 
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el login: " + ex.Message, "Ingreso a Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        // LIMPIAR CAMPOS
        public void limpiar()
        {
            txtUsuario.Clear();
            txtClave.Clear();
            txtUsuario.Focus();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

       
    }
}

