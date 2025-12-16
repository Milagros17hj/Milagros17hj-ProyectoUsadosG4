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

        public frmlogin()
        {
            InitializeComponent();
        }

        //BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTON INGRESAR
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACION CAMPOS VACIOS
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


                DataSet ds = Utilidades.ejecutar(cmd);

                // VALIDAR USUARIO
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", " Error de credenciales",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();
                    return;
                }

                DataRow fila = ds.Tables[0].Rows[0];

                DatosUsuario usuario = new DatosUsuario
                {
                    IdUsuario = Convert.ToInt32(fila["id_usuario"]),
                    NumeroIdentificacion = fila["numero_identificacion"].ToString(),
                    NombreUsuario = fila["nombre_usuario"].ToString(),
                    Contrasena = fila["contrasena"].ToString(),
                    Email = fila["email"].ToString(),
                    IdEstado = Convert.ToInt32(fila["id_estado"]),
                    EsEmpleado = Convert.ToBoolean(fila["es_empleado"])
                };


                //SI ESTA INHABILITADO NO ENTRA

                if (usuario.IdEstado != 1)
                {
                    MessageBox.Show("El usuario está inhabilitado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificar rol del usuario

                //Solo empleados tienen rol 
                if (usuario.EsEmpleado)
                {
                    string cmdRol = string.Format(
                        "SELECT id_rol FROM Empleado WHERE numero_identificacion = '{0}'",
                        usuario.NumeroIdentificacion);

                    DataSet dsRol = Utilidades.ejecutar(cmdRol);

                    if (dsRol.Tables[0].Rows.Count > 0)
                        Sesiones.Rol = Convert.ToInt32(dsRol.Tables[0].Rows[0]["id_rol"]); // Asignar rol a la sesión me ayuda con los permisos en el menu
                    else
                    {
                        MessageBox.Show("No se encontró rol.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    Sesiones.Rol = 0; // Como cliente no tiene rol se le asigna el valor 0
                }

                Sesiones.Usuario = usuario.NombreUsuario; 

                MessageBox.Show("Bienvenido al sistema.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                frmMenu menu = new frmMenu();
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
    }
}

