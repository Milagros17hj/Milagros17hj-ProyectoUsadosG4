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
    public partial class frmRegistroEmpleado : Form
    {
        public DataSet ds;
        private DatosEmpleado empleadoActual = new DatosEmpleado();

        public frmRegistroEmpleado()
        {
            InitializeComponent();
        }

        //BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {

            Close();


        }

        //BOTON LIMPIAR
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
            cmbRol.SelectedIndex = -1;
            dtpNacimiento.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            cmbIdentificacion.SelectedIndex = -1;
            cmbProvincia.SelectedIndex = -1;

            empleadoActual = new DatosEmpleado();
            txtIdentificación.ReadOnly = false;
            txtIdentificación.Focus();
            cargarTodo();


        }
        //CARGA DEL FORMULARIO
        private void frmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            try
            {
                // roles
                string cmdRol = "SELECT id_rol, nombre FROM Rol";
                ds = Utilidades.ejecutar(cmdRol);
                cmbRol.DataSource = ds.Tables[0].DefaultView;
                cmbRol.DisplayMember = "nombre";   
                cmbRol.ValueMember = "id_rol";       
                cmbRol.SelectedItem = null;

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
                empleadoActual = new DatosEmpleado(); 

                
            

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al cargar los catálogos 001: " + ex.Message);
            }
        }
        private void cmbRol_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                empleadoActual.IdRol = Convert.ToInt32(cmbRol.SelectedValue);
                empleadoActual.RolNombre = cmbRol.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar rol: 002 " + ex.Message);
            }

        }
        private void cmbIdentificacion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                empleadoActual.IdTipoIdentificacion = Convert.ToInt32(cmbIdentificacion.SelectedValue);
                empleadoActual.TipoIdentificacionNombre = cmbIdentificacion.Text;
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
                empleadoActual.IdProvincia = Convert.ToInt32(cmbProvincia.SelectedValue);
                empleadoActual.Provincia = cmbProvincia.Text;
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
                empleadoActual.Sexo = cmbSexo.SelectedItem != null ? cmbSexo.SelectedItem.ToString() : string.Empty;
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

            // Asignar valores desde los controles al objeto empleadoActual
            empleadoActual.IdTipoIdentificacion = Convert.ToInt32(cmbIdentificacion.SelectedValue);
            empleadoActual.NumeroIdentificacion = txtIdentificación.Text.Trim();
            empleadoActual.Nombre = txtNombre.Text.Trim();
            empleadoActual.PrimerApellido = txtApellido1.Text.Trim();
            empleadoActual.SegundoApellido = txtApellido2.Text.Trim();
            empleadoActual.Sexo = cmbSexo.SelectedItem?.ToString();
            empleadoActual.FechaNacimiento = dtpNacimiento.Value;
            empleadoActual.FechaVencimientoDoc = dtpVencimiento.Value;
            empleadoActual.Email = txtEmail.Text.Trim();
            empleadoActual.Telefono = txtTeléfono.Text.Trim();
            empleadoActual.IdProvincia = Convert.ToInt32(cmbProvincia.SelectedValue);
            empleadoActual.Canton = txtCanton.Text.Trim();
            empleadoActual.Distrito = txtDistrito.Text.Trim();
            empleadoActual.IdRol = Convert.ToInt32(cmbRol.SelectedValue);

            if (empleadoActual.IdTipoIdentificacion <= 0 || empleadoActual.IdProvincia <= 0 || empleadoActual.IdRol <= 0)
            {
                MessageBox.Show("Debe seleccionar tipo de identificación, provincia y rol válidos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cmdEmpleado;

                if (txtIdentificación.ReadOnly) // MODO EDICIÓN
                {
                    cmdEmpleado = string.Format(
                        "UPDATE Empleado SET id_tipo_identificacion = {0}, nombre = '{1}', primer_apellido = '{2}', segundo_apellido = '{3}', sexo = '{4}', " +
                        "fecha_nacimiento = '{5}', fecha_vencimiento_doc = '{6}', email = '{7}', telefono = '{8}', id_provincia = {9}, canton = '{10}', distrito = '{11}', id_rol = {12}, id_estado = 1 " +
                        "WHERE numero_identificacion = '{13}'",
                        empleadoActual.IdTipoIdentificacion,
                        empleadoActual.Nombre,
                        empleadoActual.PrimerApellido,
                        empleadoActual.SegundoApellido,
                        empleadoActual.Sexo,
                        empleadoActual.FechaNacimiento.ToString("yyyy-MM-dd"),
                        empleadoActual.FechaVencimientoDoc.ToString("yyyy-MM-dd"),
                        empleadoActual.Email,
                        empleadoActual.Telefono,
                        empleadoActual.IdProvincia,
                        empleadoActual.Canton,
                        empleadoActual.Distrito,
                        empleadoActual.IdRol,
                        empleadoActual.NumeroIdentificacion
                    );

                    Utilidades.ejecutar(cmdEmpleado);
                    MessageBox.Show("Empleado actualizado correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // CREAR NUEVO EMPLEADO
                {
                    cmdEmpleado = string.Format("INSERT INTO Empleado (id_tipo_identificacion, numero_identificacion, nombre, primer_apellido, segundo_apellido, sexo, " +
                        "fecha_nacimiento, fecha_vencimiento_doc, email, telefono, id_provincia, canton, distrito, id_rol, id_estado) " +
                        "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, '{11}', '{12}', {13}, 1)",
                        empleadoActual.IdTipoIdentificacion,
                        empleadoActual.NumeroIdentificacion,
                        empleadoActual.Nombre,
                        empleadoActual.PrimerApellido,
                        empleadoActual.SegundoApellido,
                        empleadoActual.Sexo,
                        empleadoActual.FechaNacimiento.ToString("yyyy-MM-dd"),
                        empleadoActual.FechaVencimientoDoc.ToString("yyyy-MM-dd"),
                        empleadoActual.Email,
                        empleadoActual.Telefono,      
                        empleadoActual.IdProvincia,  
                        empleadoActual.Canton,
                        empleadoActual.Distrito,
                        empleadoActual.IdRol
                        );

                    Utilidades.ejecutar(cmdEmpleado);
                    MessageBox.Show("Empleado creado satisfactoriamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refrescar todos los registros
                cargarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al grabar empleado: " + ex.Message);
            }
        }

        //CARGAR DATOS EN EL DATAGRIDVIEW LUEGO DE GRABAR/ACTUALIZAR
        public void Cargar()
        {
            try
            {
                string cmd = string.Format("SELECT a.numero_identificacion AS Cedula, a.nombre, a.primer_apellido, a.segundo_apellido, a.sexo, a.fecha_nacimiento, " +
                    "a.fecha_vencimiento_doc, b.nombre AS Rol, a.email, a.telefono, a.canton, a.distrito, c.nombre AS Provincia, t.descripcion AS TipoIdentificacion " +
                    "FROM Empleado a, Rol b, Provincia c, TipoIdentificacion t " +
                    "WHERE a.id_rol = b.id_rol AND a.id_provincia = c.id_provincia AND a.id_tipo_identificacion = t.id_tipo AND a.numero_identificacion = '{0}'",
                    txtIdentificación.Text.Trim());

                ds = Utilidades.ejecutar(cmd);
                dgvDatos.DataSource = ds.Tables[0].DefaultView;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    empleadoActual.NumeroIdentificacion = row["Cedula"].ToString();

                    txtIdentificación.Text = empleadoActual.NumeroIdentificacion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al cargar 004: " + ex.Message);
            }
        }

        //BOTON CONSULTAR
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
                    "a.fecha_nacimiento, a.fecha_vencimiento_doc, a.id_rol, b.nombre AS Rol, a.email, a.telefono, a.id_provincia, c.nombre AS Provincia, a.canton, a.distrito " +
                    "FROM Empleado a, Rol b, Provincia c, TipoIdentificacion t  WHERE a.numero_identificacion = '{0}' AND a.id_rol = b.id_rol " +
                    "AND a.id_provincia = c.id_provincia AND a.id_tipo_identificacion = t.id_tipo",
                    txtIdentificación.Text.Trim());

                ds = Utilidades.ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dgvDatos.DataSource = ds.Tables[0].DefaultView;
                    DataRow row = ds.Tables[0].Rows[0];
                    empleadoActual.IdTipoIdentificacion = Convert.ToInt32(row["id_tipo_identificacion"]);
                    empleadoActual.TipoIdentificacionNombre = row["TipoIdentificacion"].ToString();
                    empleadoActual.NumeroIdentificacion = row["Cedula"].ToString();
                    empleadoActual.Nombre = row["nombre"].ToString();
                    empleadoActual.PrimerApellido = row["primer_apellido"].ToString();
                    empleadoActual.SegundoApellido = row["segundo_apellido"].ToString();
                    empleadoActual.Sexo = row["sexo"].ToString();
                    empleadoActual.FechaNacimiento = Convert.ToDateTime(row["fecha_nacimiento"]);
                    empleadoActual.FechaVencimientoDoc = Convert.ToDateTime(row["fecha_vencimiento_doc"]);
                    empleadoActual.IdRol = Convert.ToInt32(row["id_rol"]);
                    empleadoActual.RolNombre = row["Rol"].ToString();
                    empleadoActual.Email = row["email"].ToString();
                    empleadoActual.Telefono = row["telefono"].ToString();
                    empleadoActual.IdProvincia = Convert.ToInt32(row["id_provincia"]);
                    empleadoActual.Provincia = row["Provincia"].ToString();
                    empleadoActual.Canton = row["canton"].ToString();
                    empleadoActual.Distrito = row["distrito"].ToString();

                }
                else
                {
                    MessageBox.Show("El empleado no está registrado.", "Consulta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al consultar 005:  " + ex.Message);
            }
        }

        //BOTON ELIMINAR
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

                string cmd = string.Format("DELETE FROM Empleado WHERE numero_identificacion = '{0}'",
                    txtIdentificación.Text.Trim());

                Utilidades.ejecutar(cmd);

                MessageBox.Show("Empleado eliminado satisfactoriamente", "Eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();  
                Cargar();    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al eliminar: 006" + ex.Message);
            }
        }

        //CARGAR TODOS LOS EMPLEADOS EN EL DATAGRIDVIEW AL INICIAR EL FORMULARIO
        public void cargarTodo()
        {
            try
            {
                string cmd = "SELECT a.numero_identificacion AS Cedula, a.nombre, a.primer_apellido, a.segundo_apellido, " +
             "a.sexo, a.fecha_nacimiento, a.fecha_vencimiento_doc, b.nombre AS Rol, a.email, a.telefono, " +
             "c.nombre AS Provincia, a.canton, a.distrito, t.descripcion AS TipoIdentificacion " +
             "FROM Empleado a, Rol b, Provincia c, TipoIdentificacion t " +
             "WHERE a.id_rol = b.id_rol AND a.id_provincia = c.id_provincia AND a.id_tipo_identificacion = t.id_tipo";

                ds = Utilidades.ejecutar(cmd);
                dgvDatos.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos 007: " + ex.Message);
            }
        }

        // SELECCIONAR FILA DEL DATAGRIDVIEW PARA EDITAR
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                txtIdentificación.ReadOnly = true; // BLOQUEAR LA CEDULA PARA QUE NO SE PUEDA MODIFICAR AL EDITAR y SE EVITEN DUPLICADOS

                txtIdentificación.Text = fila.Cells["Cedula"].Value.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtApellido1.Text = fila.Cells["primer_apellido"].Value.ToString();
                txtApellido2.Text = fila.Cells["segundo_apellido"].Value.ToString();
                txtEmail.Text = fila.Cells["email"].Value.ToString();
                txtTeléfono.Text = fila.Cells["telefono"].Value.ToString();
                txtCanton.Text = fila.Cells["canton"].Value.ToString();
                txtDistrito.Text = fila.Cells["distrito"].Value.ToString();

                // Validar valores nulos 
                if (fila.Cells["fecha_nacimiento"].Value != DBNull.Value)
                    dtpNacimiento.Value = Convert.ToDateTime(fila.Cells["fecha_nacimiento"].Value);

                if (fila.Cells["fecha_vencimiento_doc"].Value != DBNull.Value)
                    dtpVencimiento.Value = Convert.ToDateTime(fila.Cells["fecha_vencimiento_doc"].Value);

                cmbSexo.SelectedItem = fila.Cells["sexo"].Value.ToString();
                cmbRol.Text = fila.Cells["Rol"].Value.ToString();
                cmbProvincia.Text = fila.Cells["Provincia"].Value.ToString();
                cmbIdentificacion.Text = fila.Cells["TipoIdentificacion"].Value.ToString();

            }
        }

        //VALIDACIONES DE ENTRADA EN LOS CAMPOS
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
