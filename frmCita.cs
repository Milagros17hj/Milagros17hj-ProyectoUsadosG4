using libreriaIII2025;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUsadosGrupo4
{
    public partial class frmCita : Form
    {
        DataSet ds;
        private bool clienteCargado = false;
        private int idCitaSeleccionada = -1;

        public frmCita()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCita_Load(object sender, EventArgs e)
        {
            
            if (Sesiones.Rol == 3) // Recepcionista
            {
                btnAgendar.Enabled = true;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = false;
            }
            else if (Sesiones.Rol == 2) // Agente
            {
                btnAgendar.Enabled = false;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = true;
            }
            else if (Sesiones.Rol == 1) // Administrador
            {
                btnAgendar.Enabled = true;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }

            try
            {
                dgvCitas.Enabled = false;

                // CLIENTES
                string cmdCliente = "SELECT id_cliente, numero_identificacion FROM Cliente " +
                                    "WHERE id_cliente IN (SELECT id_cliente FROM Cita WHERE id_estado = 3)";
                DataSet dsCliente = Utilidades.ejecutar(cmdCliente);
                cmbCliente.DataSource = dsCliente.Tables[0];
                cmbCliente.DisplayMember = "numero_identificacion";
                cmbCliente.ValueMember = "id_cliente";
                cmbCliente.SelectedIndex = -1;
                clienteCargado = true;

                // AGENTES
                string cmdAgente = "SELECT id_empleado, nombre FROM Empleado WHERE id_rol = 2";
                DataSet dsAgente = Utilidades.ejecutar(cmdAgente);
                cmbAgente.DataSource = dsAgente.Tables[0];
                cmbAgente.DisplayMember = "nombre";
                cmbAgente.ValueMember = "id_empleado";
                cmbAgente.SelectedIndex = -1;

                // ESTADOS
                string cmdEstado = "SELECT id_estado, descripcion FROM Estado WHERE id_estado IN (3,4,5)";
                DataSet dsEstado = Utilidades.ejecutar(cmdEstado);
                cmbEstado.DataSource = dsEstado.Tables[0];
                cmbEstado.DisplayMember = "descripcion";
                cmbEstado.ValueMember = "id_estado";
                cmbEstado.SelectedIndex = -1;

                // GRID DE CITAS
                string cmdGrid = "SELECT " +
                                 "a.id_cita AS NumeroCita, " +
                                 "a.fecha AS Fecha, " +
                                 "a.hora AS Hora, " +
                                 "(SELECT nombre FROM Empleado WHERE id_empleado = a.id_agente AND id_rol = 2) AS Agente, " +
                                 "(SELECT nombre FROM Cliente WHERE id_cliente = a.id_cliente) AS Cliente, " +
                                 "(SELECT descripcion FROM Estado WHERE id_estado = a.id_estado) AS Estado, " +
                                 "(SELECT modelo FROM Vehiculo WHERE id_vehiculo = a.id_vehiculo) AS ModeloVehiculo " +
                                 "FROM Cita a";

                DataSet dsGrid = Utilidades.ejecutar(cmdGrid);
                dgvCitas.DataSource = dsGrid.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos 001: " + ex.Message);
            }

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue is DataRowView) return;

                string idCliente = cmbCliente.SelectedValue.ToString();

                string cmdCliente = "SELECT nombre, primer_apellido, segundo_apellido, numero_identificacion " +
                                    "FROM Cliente WHERE id_cliente = " + idCliente;

                DataSet dsCliente = Utilidades.ejecutar(cmdCliente);

                if (dsCliente.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsCliente.Tables[0].Rows[0];
                    txtNombre.Text = row["nombre"].ToString();
                    txtApellido1.Text = row["primer_apellido"].ToString();
                    txtApellido2.Text = row["segundo_apellido"].ToString();
                    txtIdentificación.Text = row["numero_identificacion"].ToString();
                }
                else
                {
                    txtNombre.Clear();
                    txtApellido1.Clear();
                    txtApellido2.Clear();
                    txtIdentificación.Clear();
                }

                string cmdVehiculo = "SELECT v.modelo " +
                                     "FROM Cita c " +
                                     "INNER JOIN Vehiculo v ON c.id_vehiculo = v.id_vehiculo " +
                                     "WHERE c.id_cliente = " + idCliente;

                DataSet dsVehiculo = Utilidades.ejecutar(cmdVehiculo);

                if (dsVehiculo.Tables[0].Rows.Count > 0)
                {
                    txtVehiculo.Text = dsVehiculo.Tables[0].Rows[0]["modelo"].ToString();
                }
                else
                {
                    txtVehiculo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos cliente/vehículo: " + ex.Message);
            }
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbCliente.SelectedValue == null || cmbCliente.SelectedValue is DataRowView) return;

                string cmd = "SELECT nombre, primer_apellido, segundo_apellido, numero_identificacion " +
                             "FROM Cliente WHERE id_cliente = " + cmbCliente.SelectedValue;

                DataSet dsLocal = Utilidades.ejecutar(cmd);

                if (dsLocal.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dsLocal.Tables[0].Rows[0];
                    txtNombre.Text = row["nombre"].ToString();
                    txtApellido1.Text = row["primer_apellido"].ToString();
                    txtApellido2.Text = row["segundo_apellido"].ToString();
                    txtIdentificación.Text = row["numero_identificacion"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos cliente: " + ex.Message);
            }

        }

        private void cmbAgente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbAgente.SelectedValue == null || cmbAgente.SelectedValue is DataRowView)
                {
                    dgvCitas.Enabled = false;
                    return;
                }

                dgvCitas.Enabled = true; 
                Consultar();             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al seleccionar agente 003: " + ex.Message);
            }


        }

        private void cmbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstado.SelectedValue == null || cmbEstado.SelectedValue is DataRowView) return;

                string idEstado = cmbEstado.SelectedValue.ToString();
   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al seleccionar estado 003 : " + ex.Message);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           limpiar();
        }

        public void limpiar()
        {
            cmbCliente.SelectedItem = null;
            txtNombre.Clear();
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtIdentificación.Clear();
            txtVehiculo.Clear();
            cmbAgente.SelectedItem = null;
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            cmbEstado.SelectedItem = null;

            dgvCitas.DataSource = null; 
            idCitaSeleccionada = -1;
            cmbCliente.SelectedIndex = -1;
            cmbCliente.Text = string.Empty;



            cmbCliente.Focus();
            Cargar();
        }



        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Agendar();
        }

        public void Agendar()
        {
            try
            {
                if (cmbAgente.SelectedValue == null || cmbEstado.SelectedValue == null)
                {
                    MessageBox.Show("Debe rellenar todos los campos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbAgente.Focus();
                    return;
                }

                if (!int.TryParse(cmbAgente.SelectedValue.ToString(), out int idAgente) ||
                    !int.TryParse(cmbEstado.SelectedValue.ToString(), out int idEstado))
                {
                    MessageBox.Show("Los valores seleccionados no son válidos", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string hora = DateTime.Now.ToString("HH:mm:ss");


                string modelo = txtVehiculo.Text.Replace("'", "''");
                string cmdBuscarCita = "SELECT TOP 1 id_cita FROM Cita " +
                                       "WHERE id_cliente = " + cmbCliente.SelectedValue +
                                       " AND id_vehiculo = (SELECT TOP 1 id_vehiculo FROM Vehiculo WHERE modelo = '" + modelo + "' AND id_cliente = " + cmbCliente.SelectedValue + ") " +
                                       "ORDER BY id_cita DESC";

                DataSet dsCita = Utilidades.ejecutar(cmdBuscarCita);

                if (dsCita.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró la cita previa para este cliente y vehículo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idCita = Convert.ToInt32(dsCita.Tables[0].Rows[0]["id_cita"]);


                string cmdUpdate = "UPDATE Cita SET " +
                                   "id_agente = " + idAgente + ", " +
                                   "id_recepcionista = " + Sesiones.IdEmpleado + ", " +
                                   "fecha = '" + fecha + "', " +
                                   "hora = '" + hora + "', " +
                                   "id_estado = " + idEstado + " " +
                                   "WHERE id_cita = " + idCita;

                Utilidades.ejecutar(cmdUpdate);

                MessageBox.Show("Cita agendada correctamente", "Guardado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agendar cita 004: " + ex.Message);
            }
        }
        private void Cargar()
        {

            string cmd = "SELECT " +
             "a.id_cita AS IdCita, " + 
             "a.fecha AS Fecha, " +
             "a.hora AS Hora, " +
             "(SELECT nombre FROM Empleado WHERE id_empleado = a.id_agente) AS Agente, " +
             "(SELECT nombre FROM Cliente WHERE id_cliente = a.id_cliente) AS Cliente, " +
             "(SELECT descripcion FROM Estado WHERE id_estado = a.id_estado) AS Estado " +
             "FROM Cita a";

            ds = Utilidades.ejecutar(cmd);
            dgvCitas.AutoGenerateColumns = true;
            dgvCitas.DataSource = ds.Tables[0];
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        public void Consultar()
        {
            try
            {
                if (cmbAgente.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar agente para consultar sus citas",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cmd = "SELECT " +
             "a.id_cita AS IdCita, " + 
             "a.fecha AS Fecha, " +
             "a.hora AS Hora, " +
             "(SELECT nombre FROM Empleado WHERE id_empleado = a.id_agente) AS Agente, " +
             "(SELECT nombre FROM Cliente WHERE id_cliente = a.id_cliente) AS Cliente, " +
             "(SELECT descripcion FROM Estado WHERE id_estado = a.id_estado) AS Estado, " +
             "(SELECT modelo FROM Vehiculo WHERE id_vehiculo = a.id_vehiculo) AS ModeloVehiculo " +
             "FROM Cita a " +
             "WHERE a.id_agente = " + cmbAgente.SelectedValue;


                ds = Utilidades.ejecutar(cmd);
                dgvCitas.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar citas 005: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        public void Actualizar()
        {
            try
            {
                if (cmbAgente.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un agente antes de actualizar.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvCitas.CurrentRow == null)
                {
                    MessageBox.Show("Debe seleccionar una cita en la tabla", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbEstado.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un nuevo estado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string idCita = dgvCitas.CurrentRow.Cells["IdCita"].Value.ToString(); 
                string nuevoEstado = cmbEstado.SelectedValue.ToString();

                string cmd = "UPDATE Cita SET id_estado = " + nuevoEstado + " WHERE id_cita = " + idCita;

                Utilidades.ejecutar(cmd);

                MessageBox.Show("Actualizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                Cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cita 006: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public void Eliminar()
        {
            try
            {

                if (Sesiones.Rol != 2 && Sesiones.Rol != 1)
                {
                    MessageBox.Show("Solo la recepcionista o el administrador pueden eliminar citas.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvCitas.SelectedRows.Count > 0)
                {
                    string idCita = dgvCitas.SelectedRows[0].Cells["IdCita"].Value.ToString(); 

                    DialogResult result = MessageBox.Show("¿Está segura de eliminar esta cita?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        string cmd = "DELETE FROM Cita WHERE id_cita = " + idCita;
                        Utilidades.ejecutar(cmd);

                        MessageBox.Show("Cita eliminada correctamente.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiar();
                        Cargar();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una cita completa.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cita: " + ex.Message);
            }
        }
        
        private void dgvCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvCitas.Rows[e.RowIndex];


                    idCitaSeleccionada = Convert.ToInt32(row.Cells["IdCita"].Value);


                    dtpFecha.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
                    dtpHora.Value = DateTime.Parse(row.Cells["Hora"].Value.ToString());
                    cmbCliente.Text = row.Cells["Cliente"].Value.ToString();
                    cmbEstado.Text = row.Cells["Estado"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar cita: " + ex.Message);
            }

        }
    }
    
}
