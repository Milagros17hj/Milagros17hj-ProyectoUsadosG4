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
    public partial class frmRegistroUsuario : Form
    {
        DataSet ds;
        private DatosUsuario usuarioActual = new DatosUsuario();
        private bool bloqueado = false;
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmRegistroUsuario_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            txtNombre.ReadOnly = true;
            txtApellido1.ReadOnly = true;
            txtApellido2.ReadOnly = true;
            txtCorreo.ReadOnly = true;
   
            dgvDatos.ReadOnly = true;              
            dgvDatos.AllowUserToAddRows = false;   
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgvDatos.MultiSelect = false;

            ckbEstado.Checked = false;
            ckbEstado.Enabled = false;
            bloqueado = true;
        }

        //CONSULTA POR CEDULA PARA RELLENAR CAMPOS
        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultarPersona();
            }

        }

        private void ConsultarPersona()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("Debe digitar una cédula",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // COMO HAY DOS TABLAS CLIENTE Y EMPLEADO, PRIMERO BUSCAR EN EMPLEADO
                string cmdEmpleado = string.Format(
                    "SELECT numero_identificacion, nombre, primer_apellido, segundo_apellido, email " +
                    "FROM Empleado WHERE numero_identificacion = {0}", txtCedula.Text.Trim());

                ds = Utilidades.ejecutar(cmdEmpleado);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow fila = ds.Tables[0].Rows[0];

                    DatosEmpleado empleado = new DatosEmpleado();
                    empleado.NumeroIdentificacion = fila["numero_identificacion"].ToString();
                    empleado.Nombre = fila["nombre"].ToString();
                    empleado.PrimerApellido = fila["primer_apellido"].ToString();
                    empleado.SegundoApellido = fila["segundo_apellido"].ToString();
                    empleado.Email = fila["email"].ToString();

                    // RELLENA LOS ESPACIOS
                    txtNombre.Text = empleado.Nombre;
                    txtApellido1.Text = empleado.PrimerApellido;
                    txtApellido2.Text = empleado.SegundoApellido;
                    txtCorreo.Text = empleado.Email;
                    return;
                }

                // buscar en cliente
                string cmdCliente = string.Format(
                    "SELECT numero_identificacion, nombre, primer_apellido, segundo_apellido, email " +
                    "FROM Cliente WHERE numero_identificacion = {0}", txtCedula.Text.Trim());

                ds = Utilidades.ejecutar(cmdCliente);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow fila = ds.Tables[0].Rows[0];

                    DatosCliente cliente = new DatosCliente();
                    cliente.NumeroIdentificacion = fila["numero_identificacion"].ToString();
                    cliente.Nombre = fila["nombre"].ToString();
                    cliente.PrimerApellido = fila["primer_apellido"].ToString();
                    cliente.SegundoApellido = fila["segundo_apellido"].ToString();
                    cliente.Email = fila["email"].ToString();

                    // Rellenar Campos
                    txtNombre.Text = cliente.Nombre;
                    txtApellido1.Text = cliente.PrimerApellido;
                    txtApellido2.Text = cliente.SegundoApellido;
                    txtCorreo.Text = cliente.Email;
                }
                else
                {
                    MessageBox.Show("No se encontro cliente con esa cédula", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar 001: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            grabar();
        }

        public void grabar()
        {
            try
            {
                string fecha = DateTime.Now.ToString("MM/dd/yyyy");
                int estado = 1; // 1 = Habilitado, 2 = Inhabilitado Todos los usuarios nuevos se crean habilitados
                string contraseñaCodificada = Utilidades.codificar(txtContraseña.Text.Trim());

                if (string.IsNullOrWhiteSpace(txtCedula.Text) ||
                    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmar.Text) ||
                    string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido1.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido2.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Debe completar todos los espacios",
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Validacion de contraseñas
                if (txtContraseña.Text == txtConfirmar.Text)
                {
                    DatosUsuario usuario = new DatosUsuario();
                    usuario.NumeroIdentificacion = txtCedula.Text.Trim();
                    usuario.NombreUsuario = txtUsuario.Text.Trim();
                    usuario.Contrasena = contraseñaCodificada;
                    usuario.Email = txtCorreo.Text.Trim();
                    usuario.IdEstado = estado;
                    usuario.EsEmpleado = true; 

                    string cmd = string.Format("INSERT INTO Usuario (numero_identificacion, nombre_usuario, contrasena, email, id_estado, fec_creacion, fec_modificacion, es_empleado) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', {4}, '{5}', '{6}', {7})",
                        usuario.NumeroIdentificacion,
                        usuario.NombreUsuario,
                        usuario.Contrasena,
                        usuario.Email,
                        usuario.IdEstado,
                        fecha,
                        fecha,
                        usuario.EsEmpleado ? 1 : 0
                    );

                    Utilidades.ejecutar(cmd);

                    MessageBox.Show("Se creó el usuario satisfactoriamente",
                        "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargar(); 
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, por favor verificar...",
                        "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al grabar 002: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargar()
        {
            try
            {
                string cmd =
                    "SELECT a.numero_identificacion AS Cedula, a.nombre_usuario AS Usuario, a.email AS Correo, " +
                    " CASE a.id_estado WHEN 1 THEN 'Habilitado' ELSE 'Inhabilitado' END AS Estado, a.fec_creacion AS Fec_Creacion, " +
                    "  a.fec_modificacion AS Fec_Modificacion, CASE a.es_empleado WHEN 1 THEN 'Empleado' ELSE 'Cliente' END AS Tipo FROM Usuario a";

                ds = Utilidades.ejecutar(cmd);
                dgvDatos.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios 003: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            try
            {
                bloqueado = true;
                txtCedula.Clear();
                txtCorreo.Clear();
                txtNombre.Clear();
                txtApellido1.Clear();
                txtApellido2.Clear();
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtConfirmar.Clear();
                dgvDatos.DataSource = null;
                dgvDatos.Rows.Clear();
                ckbEstado.Checked = false;
                ckbEstado.Enabled = false;
                usuarioActual = new DatosUsuario(); 
                bloqueado = false;
                txtCedula.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar 004: " + ex.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("Debe ingresar el número de identificación para consultar.",
                        "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedula.Focus();
                    return;
                }

                string cmd = string.Format(
                    "SELECT u.id_usuario, u.numero_identificacion AS Cedula, u.nombre_usuario, u.email, " +
                    "CASE u.id_estado WHEN 1 THEN 'Habilitado' ELSE 'Inhabilitado' END AS Estado, " +
                    "CASE u.es_empleado WHEN 1 THEN 'Empleado' ELSE 'Cliente' END AS TipoPersona " +
                    "FROM Usuario u WHERE u.numero_identificacion = '{0}'",
                    txtCedula.Text.Trim());

                ds = Utilidades.ejecutar(cmd);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("El usuario no está registrado.",
                        "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    return;
                }

                dgvDatos.DataSource = ds.Tables[0].DefaultView;

                DataRow row = ds.Tables[0].Rows[0];

                usuarioActual.IdUsuario = Convert.ToInt32(row["id_usuario"]);
                usuarioActual.NumeroIdentificacion = row["Cedula"].ToString();
                usuarioActual.NombreUsuario = row["nombre_usuario"].ToString();
                usuarioActual.Email = row["email"].ToString();
                usuarioActual.IdEstado = (row["Estado"].ToString() == "Habilitado") ? 1 : 2;
                usuarioActual.EsEmpleado = (row["TipoPersona"].ToString() == "Empleado");

                bloqueado = true;
                ckbEstado.Checked = usuarioActual.IdEstado == 2;
                ckbEstado.Enabled = true;
                bloqueado = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al consultar usuario 005: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }
        public void eliminar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCedula.Text))
                {
                    MessageBox.Show("Debe ingresar el número de cedula para eliminar.", "Eliminar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCedula.Focus();
                    return;
                }

                string cmd = string.Format("DELETE FROM Usuario WHERE numero_identificacion = '{0}'",
                    txtCedula.Text.Trim());

                Utilidades.ejecutar(cmd);

                MessageBox.Show("Usuario eliminado satisfactoriamente", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar usuario 006: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (bloqueado) return;

            if (usuarioActual == null || usuarioActual.IdUsuario == 0)
            {
                MessageBox.Show("Debe consultar el usuario antes de cambiar el estado.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                bloqueado = true;
                ckbEstado.Checked = false;
                bloqueado = false;
                return;
            }

            try
            {
                int nuevoEstado = ckbEstado.Checked ? 2 : 1;
                string cmd = string.Format(
                    "UPDATE Usuario SET id_estado = {0}, fec_modificacion = '{1}' WHERE id_usuario = {2}",
                    nuevoEstado,
                    DateTime.Now.ToString("MM/dd/yyyy"),
                    usuarioActual.IdUsuario
                );

                Utilidades.ejecutar(cmd);

                MessageBox.Show("Estado actualizado correctamente",
                    "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar estado 007: " + ex.Message);
            }
        }


    }
}
