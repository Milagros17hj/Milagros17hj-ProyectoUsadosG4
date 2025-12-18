using libreriaIII2025;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUsadosGrupo4
{
    public partial class frmRegistroCliente : Form
    {
        public DataSet ds;
        private DatosCliente clienteActual = new DatosCliente();


        public frmRegistroCliente()
        {
            InitializeComponent();
        }
         private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
         private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtIdentificación.Clear();
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtEmail.Clear();
            txtTeléfono.Clear();
            txtCanton.Clear();
            txtDistrito.Clear();
            cmbSexo.SelectedIndex = -1;
            dtpNacimiento.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            cmbIdentificacion.SelectedIndex = -1;
            cmbProvincia.SelectedIndex = -1;    

            clienteActual = new DatosCliente();
            txtIdentificación.ReadOnly = false;
            txtIdentificación.Focus();
            cargarTodo();

        }
        //CARGA DEL FORMULARIO
    
        private void frmRegistroCliente_Load(object sender, EventArgs e)
        {
            try
            {

                // Catálogo de Tipo de Identificación
                string cmdTipo = "SELECT id_tipo, descripcion FROM TipoIdentificacion";
                ds = Utilidades.ejecutar(cmdTipo);
                cmbIdentificacion.DataSource = ds.Tables[0].DefaultView;
                cmbIdentificacion.DisplayMember = "descripcion";
                cmbIdentificacion.ValueMember = "id_tipo";
                cmbIdentificacion.SelectedItem = null;

                // Provincias
                string cmdProv = "SELECT id_provincia, nombre FROM Provincia";
                ds = Utilidades.ejecutar(cmdProv);
                cmbProvincia.DataSource = ds.Tables[0].DefaultView;
                cmbProvincia.DisplayMember = "nombre";
                cmbProvincia.ValueMember = "id_provincia";
                cmbProvincia.SelectedItem = null;

                // COMO ES SOLO M y F, SE CARGAN MANUALMENTE NO DESDE BD
                cmbSexo.Items.Clear();
                cmbSexo.Items.AddRange(new[] { "M", "F" });
                cmbSexo.SelectedIndex = -1;

                //BLOQUEAR EDICION DEL DATAGRIDVIEW
                dgvDatos.ReadOnly = true;
                dgvDatos.AllowUserToAddRows = false;
                dgvDatos.AllowUserToDeleteRows = false;

                //QUE SE CARGUE LA TABLA COMPLETA AL INICIAR
                cargarTodo();
                clienteActual = new DatosCliente();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar los catálogos 001: " + ex.Message);
            }

        }

        private void cmbIdentificacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clienteActual.IdTipoIdentificacion = Convert.ToInt32(cmbIdentificacion.SelectedValue);
                clienteActual.TipoIdentificacionNombre = cmbIdentificacion.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar tipo de identificación 002: " + ex.Message);
            }

        }
        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clienteActual.IdProvincia = Convert.ToInt32(cmbProvincia.SelectedValue);
                clienteActual.Provincia = cmbProvincia.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar provincia 002: " + ex.Message);
            }

        }
        private void cmbSexo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                clienteActual.Sexo = cmbSexo.SelectedItem != null ? cmbSexo.SelectedItem.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar sexo 002: " + ex.Message);
            }

        }
        //BOTON GRABAR/ ACTUALIZAR (GUARDAR)
        private void btnGrabar_Click(object sender, EventArgs e)
        {
         
            grabar();
        }

        public void grabar()
        {
            if (string.IsNullOrWhiteSpace(txtIdentificación.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido1.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTeléfono.Text) ||
                string.IsNullOrWhiteSpace(txtCanton.Text) ||
                string.IsNullOrWhiteSpace(txtDistrito.Text) ||
                cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Debe rellenar todos los campos para guardar.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clienteActual.IdTipoIdentificacion = Convert.ToInt32(cmbIdentificacion.SelectedValue);
            clienteActual.NumeroIdentificacion = txtIdentificación.Text.Trim();
            clienteActual.Nombre = txtNombre.Text.Trim();
            clienteActual.PrimerApellido = txtApellido1.Text.Trim();
            clienteActual.SegundoApellido = txtApellido2.Text.Trim();
            clienteActual.Sexo = cmbSexo.SelectedItem?.ToString();
            clienteActual.FechaNacimiento = dtpNacimiento.Value;
            clienteActual.FechaVencimientoDoc = dtpVencimiento.Value;
            clienteActual.Email = txtEmail.Text.Trim();
            clienteActual.Telefono = txtTeléfono.Text.Trim();
            clienteActual.IdProvincia = Convert.ToInt32(cmbProvincia.SelectedValue);
            clienteActual.Canton = txtCanton.Text.Trim();
            clienteActual.Distrito = txtDistrito.Text.Trim();

            if (clienteActual.IdTipoIdentificacion <= 0 || clienteActual.IdProvincia <= 0)
            {
                MessageBox.Show("Debe seleccionar tipo de identificación y provincia válidos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cmdCliente;

                if (txtIdentificación.ReadOnly) // MODO EDICIÓN
                {
                    cmdCliente = string.Format(
                        "UPDATE Cliente SET id_tipo_identificacion = {0}, nombre = '{1}', primer_apellido = '{2}', segundo_apellido = '{3}', sexo = '{4}', " +
                        "fecha_nacimiento = '{5}', fecha_vencimiento_doc = '{6}', email = '{7}', telefono = '{8}', id_provincia = {9}, canton = '{10}', distrito = '{11}', id_estado = 1 " +
                        "WHERE numero_identificacion = '{12}'",
                        clienteActual.IdTipoIdentificacion,
                        clienteActual.Nombre,
                        clienteActual.PrimerApellido,
                        clienteActual.SegundoApellido,
                        clienteActual.Sexo,
                        clienteActual.FechaNacimiento.ToString("yyyy-MM-dd"),
                        clienteActual.FechaVencimientoDoc.ToString("yyyy-MM-dd"),
                        clienteActual.Email,
                        clienteActual.Telefono,
                        clienteActual.IdProvincia,
                        clienteActual.Canton,
                        clienteActual.Distrito,
                        clienteActual.NumeroIdentificacion
                    );

                    Utilidades.ejecutar(cmdCliente);
                    MessageBox.Show("Cliente actualizado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // CREAR NUEVO CLIENTE
                {
                    cmdCliente = string.Format(
                        "INSERT INTO Cliente (id_tipo_identificacion, numero_identificacion, nombre, primer_apellido, segundo_apellido, sexo, " +
                        "fecha_nacimiento, fecha_vencimiento_doc, email, telefono, id_provincia, canton, distrito, id_estado) " +
                        "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, '{11}', '{12}', 1)",
                        clienteActual.IdTipoIdentificacion,
                        clienteActual.NumeroIdentificacion,
                        clienteActual.Nombre,
                        clienteActual.PrimerApellido,
                        clienteActual.SegundoApellido,
                        clienteActual.Sexo,
                        clienteActual.FechaNacimiento.ToString("yyyy-MM-dd"),
                        clienteActual.FechaVencimientoDoc.ToString("yyyy-MM-dd"),
                        clienteActual.Email,
                        clienteActual.Telefono,
                        clienteActual.IdProvincia,
                        clienteActual.Canton,
                        clienteActual.Distrito
                    );

                    Utilidades.ejecutar(cmdCliente);
                    MessageBox.Show("Cliente creado satisfactoriamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refrescar todos los registros en el DataGridView
                cargarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al grabar cliente: " + ex.Message);
            }
        }

        // CARGAR DATOS EN EL DATAGRIDVIEW LUEGO DE GRABAR/ACTUALIZAR
        public void Cargar()
        {
            try
            {
                string cmd = string.Format(
                    "SELECT a.numero_identificacion AS Cedula, a.nombre, a.primer_apellido, a.segundo_apellido, a.sexo, a.fecha_nacimiento, " +
                    "a.fecha_vencimiento_doc, a.email, a.telefono, a.canton, a.distrito, c.nombre AS Provincia, t.descripcion AS TipoIdentificacion " +
                    "FROM Cliente a, Provincia c, TipoIdentificacion t " +
                    "WHERE a.id_provincia = c.id_provincia AND a.id_tipo_identificacion = t.id_tipo AND a.numero_identificacion = '{0}'",
                    txtIdentificación.Text.Trim()
                );

                ds = Utilidades.ejecutar(cmd);
                dgvDatos.DataSource = ds.Tables[0].DefaultView;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    clienteActual.NumeroIdentificacion = row["Cedula"].ToString();
                    txtIdentificación.Text = clienteActual.NumeroIdentificacion.Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar cliente: " + ex.Message);
            }
        }
        // BOTON CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        public void consultar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentificación.Text))
                {
                    MessageBox.Show("Debe ingresar el número de identificación para consultar.", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdentificación.Focus();
                    return;
                }

                string cmd = string.Format(
                    "SELECT a.id_tipo_identificacion, t.descripcion AS TipoIdentificacion, a.numero_identificacion AS Cedula, a.nombre, a.primer_apellido, a.segundo_apellido, a.sexo, " +
                    "a.fecha_nacimiento, a.fecha_vencimiento_doc, a.email, a.telefono, a.id_provincia, c.nombre AS Provincia, a.canton, a.distrito " +
                    "FROM Cliente a, Provincia c, TipoIdentificacion t " +
                    "WHERE a.numero_identificacion = '{0}' AND a.id_provincia = c.id_provincia AND a.id_tipo_identificacion = t.id_tipo",
                    txtIdentificación.Text.Trim()
                );

                ds = Utilidades.ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvDatos.DataSource = ds.Tables[0].DefaultView;
                    DataRow row = ds.Tables[0].Rows[0];

                    clienteActual.IdTipoIdentificacion = Convert.ToInt32(row["id_tipo_identificacion"]);
                    clienteActual.TipoIdentificacionNombre = row["TipoIdentificacion"].ToString();
                    clienteActual.NumeroIdentificacion = row["Cedula"].ToString();
                    clienteActual.Nombre = row["nombre"].ToString();
                    clienteActual.PrimerApellido = row["primer_apellido"].ToString();
                    clienteActual.SegundoApellido = row["segundo_apellido"].ToString();
                    clienteActual.Sexo = row["sexo"].ToString();

                    if (row["fecha_nacimiento"] != DBNull.Value)
                        clienteActual.FechaNacimiento = Convert.ToDateTime(row["fecha_nacimiento"]);

                    if (row["fecha_vencimiento_doc"] != DBNull.Value)
                        clienteActual.FechaVencimientoDoc = Convert.ToDateTime(row["fecha_vencimiento_doc"]);

                    clienteActual.Email = row["email"].ToString();
                    clienteActual.Telefono = row["telefono"].ToString();
                    clienteActual.IdProvincia = Convert.ToInt32(row["id_provincia"]);
                    clienteActual.Provincia = row["Provincia"].ToString();
                    clienteActual.Canton = row["canton"].ToString();
                    clienteActual.Distrito = row["distrito"].ToString();
                }
                else
                {
                    MessageBox.Show("El cliente no está registrado.", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al consultar cliente: " + ex.Message);
            }
        }
        //Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        public void eliminar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdentificación.Text))
                {
                    MessageBox.Show("Debe ingresar el número de identificación para eliminar.", "Eliminar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdentificación.Focus();
                    return;
                }

                string cmd = string.Format("DELETE FROM Cliente WHERE numero_identificacion = '{0}'",
                    txtIdentificación.Text.Trim());

                Utilidades.ejecutar(cmd);

                MessageBox.Show("Cliente eliminado satisfactoriamente", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar cliente: " + ex.Message);
            }
        }

        // CARGAR TODOS LOS CLIENTES EN EL DATAGRIDVIEW AL INICIAR EL FORMULARIO
        public void cargarTodo()
        {
            try
            {
                string cmd = "SELECT a.numero_identificacion AS Cedula, a.nombre, a.primer_apellido, a.segundo_apellido, " +
                             "a.sexo, a.fecha_nacimiento, a.fecha_vencimiento_doc, a.email, a.telefono, " +
                             "c.nombre AS Provincia, a.canton, a.distrito, t.descripcion AS TipoIdentificacion " +
                             "FROM Cliente a, Provincia c, TipoIdentificacion t " +
                             "WHERE a.id_provincia = c.id_provincia AND a.id_tipo_identificacion = t.id_tipo";

                ds = Utilidades.ejecutar(cmd);
                dgvDatos.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de clientes 007: " + ex.Message);
            }
        }
         // SELECCIONAR FILA DEL DATAGRIDVIEW PARA EDITAR
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                txtIdentificación.ReadOnly = true; // BLOQUEAR LA CÉDULA PARA EVITAR DUPLICADOS

                txtIdentificación.Text = fila.Cells["Cedula"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellido1.Text = fila.Cells["primer_apellido"].Value.ToString();
                txtApellido2.Text = fila.Cells["segundo_apellido"].Value.ToString();
                txtEmail.Text = fila.Cells["email"].Value.ToString();
                txtTeléfono.Text = fila.Cells["telefono"].Value.ToString();
                txtCanton.Text = fila.Cells["canton"].Value.ToString();
                txtDistrito.Text = fila.Cells["distrito"].Value.ToString();

                // Validar valores nulos antes de asignar a los DateTimePicker
                if (fila.Cells["fecha_nacimiento"].Value != DBNull.Value)
                    dtpNacimiento.Value = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value);

                if (fila.Cells["fecha_vencimiento_doc"].Value != DBNull.Value)
                    dtpVencimiento.Value = Convert.ToDateTime(fila.Cells["fecha_vencimiento_doc"].Value);

                // Combos
                cmbSexo.SelectedItem = fila.Cells["sexo"].Value.ToString();
                cmbProvincia.Text = fila.Cells["Provincia"].Value.ToString();
                cmbIdentificacion.Text = fila.Cells["TipoIdentificacion"].Value.ToString();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras", "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras", "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
         }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras", "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


        private void txtTeléfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan números",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCanton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras y números", "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
        }

        private void txtDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras y números", "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
        }
    }

}
