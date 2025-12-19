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
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            CargarDatosCitas();
            ConfigurarComboEstadoReserva();
            ConfigurarComboEstadoVehiculo();
        }
        private void CargarDatosCitas()
        {
            try
            {
                string cmd = @"SELECT 
                                c.id_cita AS IdCita,
                                c.id_cliente AS IdCliente,
                                c.id_vehiculo AS IdVehiculo,
                                CONCAT(cl.nombre, ' ', cl.primer_apellido) AS Cliente,
                                cl.nombre AS Nombre,
                                cl.primer_apellido AS Apellido,
                                v.modelo AS Modelo,
                                v.id_estado AS IdEstadoVehiculo,
                                c.fecha AS Fecha,
                                c.hora AS Hora,
                                e.descripcion AS EstadoCita
                               FROM Cita c
                               INNER JOIN Cliente cl ON c.id_cliente = cl.id_cliente
                               INNER JOIN Vehiculo v ON c.id_vehiculo = v.id_vehiculo
                               INNER JOIN Estado e ON c.id_estado = e.id_estado
                               WHERE c.id_estado = 4"; 
                DataSet ds = Utilidades.ejecutar(cmd);
                dgvCitas.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count > 0)
                {
                    cmbIdCita.Items.Clear();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string descripcion = $"Cita #{row["IdCita"]} - {row["Cliente"]} - {row["Modelo"]}";
                        cmbIdCita.Items.Add(new KeyValuePair<int, string>(
                            Convert.ToInt32(row["IdCita"]),
                            descripcion));
                    }
                    cmbIdCita.DisplayMember = "Value";
                    cmbIdCita.ValueMember = "Key";
                    cmbIdCita.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar citas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarComboEstadoReserva()
        {
            cmbEstadoReserva.Items.Clear();
            cmbEstadoReserva.Items.Add("Aprobada");
            cmbEstadoReserva.Items.Add("Rechazada");
            cmbEstadoReserva.SelectedIndex = -1;
        }

        private void ConfigurarComboEstadoVehiculo()
        {
            try
            {
                cmbEstadoVehiculo.Items.Clear();
                string cmd = "SELECT id_estado, descripcion FROM Estado WHERE id_estado IN (7, 8)";

                DataSet ds = Utilidades.ejecutar(cmd);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmbEstadoVehiculo.Items.Add(new KeyValuePair<int, string>(
                        Convert.ToInt32(row["id_estado"]),
                        row["descripcion"].ToString()));
                }

                cmbEstadoVehiculo.DisplayMember = "Value";
                cmbEstadoVehiculo.ValueMember = "Key";
                cmbEstadoVehiculo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados de vehículo: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dgvCitas.Rows[e.RowIndex];

                    txtIdCliente.Text = row.Cells["IdCliente"].Value.ToString();
                    txtIdVehiculo.Text = row.Cells["IdVehiculo"].Value.ToString();
                    txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                    txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                    txtModelo.Text = row.Cells["Modelo"].Value.ToString();

                    dateTimePicker1.Value = DateTime.Now;

                    if (row.Cells["IdEstadoVehiculo"].Value != null)
                    {
                        int idEstadoVehiculo = Convert.ToInt32(row.Cells["IdEstadoVehiculo"].Value);
                        for (int i = 0; i < cmbEstadoVehiculo.Items.Count; i++)
                        {
                            KeyValuePair<int, string> item = (KeyValuePair<int, string>)cmbEstadoVehiculo.Items[i];
                            if (item.Key == idEstadoVehiculo)
                            {
                                cmbEstadoVehiculo.SelectedIndex = i;
                                break;
                            }
                        }
                    }

                    int idCita = Convert.ToInt32(row.Cells["IdCita"].Value);
                    for (int i = 0; i < cmbIdCita.Items.Count; i++)
                    {
                        KeyValuePair<int, string> item = (KeyValuePair<int, string>)cmbIdCita.Items[i];
                        if (item.Key == idCita)
                        {
                            cmbIdCita.SelectedIndex = i;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de la fila: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbIdCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdCita.SelectedItem != null)
            {
                try
                {
                    KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)cmbIdCita.SelectedItem;
                    int idCita = selectedItem.Key;

                    string cmd = @"SELECT 
                                    c.id_cliente,
                                    c.id_vehiculo,
                                    cl.nombre,
                                    cl.primer_apellido,
                                    v.modelo,
                                    v.id_estado
                                   FROM Cita c
                                   INNER JOIN Cliente cl ON c.id_cliente = cl.id_cliente
                                   INNER JOIN Vehiculo v ON c.id_vehiculo = v.id_vehiculo
                                   WHERE c.id_cita = " + idCita;

                    DataSet ds = Utilidades.ejecutar(cmd);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow row = ds.Tables[0].Rows[0];
                        txtIdCliente.Text = row["id_cliente"].ToString();
                        txtIdVehiculo.Text = row["id_vehiculo"].ToString();
                        txtNombre.Text = row["nombre"].ToString();
                        txtApellido.Text = row["primer_apellido"].ToString();
                        txtModelo.Text = row["modelo"].ToString();
                        dateTimePicker1.Value = DateTime.Now;

                      
                        int idEstadoVehiculo = Convert.ToInt32(row["id_estado"]);
                        for (int i = 0; i < cmbEstadoVehiculo.Items.Count; i++)
                        {
                            KeyValuePair<int, string> item = (KeyValuePair<int, string>)cmbEstadoVehiculo.Items[i];
                            if (item.Key == idEstadoVehiculo)
                            {
                                cmbEstadoVehiculo.SelectedIndex = i;
                                break;
                            }
                        }
                        foreach (DataGridViewRow dgvRow in dgvCitas.Rows)
                        {
                            if (dgvRow.Cells["IdCita"].Value != null &&
                                Convert.ToInt32(dgvRow.Cells["IdCita"].Value) == idCita)
                            {
                                dgvCitas.ClearSelection();
                                dgvRow.Selected = true;
                                dgvCitas.CurrentCell = dgvRow.Cells[0];
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de la cita: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0 && cmbIdCita.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cita primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbEstadoReserva.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado de reserva (Aprobada o Rechazada).", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idCita;
                string fechaReserva = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                if (dgvCitas.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvCitas.SelectedRows[0];
                    idCita = Convert.ToInt32(row.Cells["IdCita"].Value);
                }
                else if (cmbIdCita.SelectedItem != null)
                {
                    KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)cmbIdCita.SelectedItem;
                    idCita = selectedItem.Key;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna cita.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string estadoReserva = cmbEstadoReserva.SelectedItem.ToString();

                int idEstadoReserva = 0;

                if (estadoReserva == "Aprobada")
                    idEstadoReserva = 9;   
                else if (estadoReserva == "Rechazada")
                    idEstadoReserva = 10;  


                if (estadoReserva == "Aprobada" && cmbEstadoVehiculo.SelectedItem != null)
                {
                    KeyValuePair<int, string> estadoVehiculo = (KeyValuePair<int, string>)cmbEstadoVehiculo.SelectedItem;
                    int idEstadoVehiculo = estadoVehiculo.Key;

                    string cmdUpdateVehiculo = $"UPDATE Vehiculo SET id_estado = 7 WHERE id_vehiculo = " + txtIdVehiculo.Text;
                    Utilidades.ejecutar(cmdUpdateVehiculo);
                }

                string cmdVerificarReserva = $"SELECT COUNT(*) FROM Reserva WHERE id_cita = {idCita}";
                DataSet dsVerificar = Utilidades.ejecutar(cmdVerificarReserva);
                int existeReserva = Convert.ToInt32(dsVerificar.Tables[0].Rows[0][0]);

                if (existeReserva > 0)
                {

                    string cmdUpdateReserva =
                        $"UPDATE Reserva SET fecha_reserva = '{fechaReserva}', id_estado = {idEstadoReserva} WHERE id_cita = {idCita}";

                    Utilidades.ejecutar(cmdUpdateReserva);

                }
                else
                {

                    string cmdInsertReserva = $@"INSERT INTO Reserva 
                       (id_cita, id_vehiculo, fecha_reserva, id_estado) 
                       VALUES 
                       ({idCita}, {txtIdVehiculo.Text}, '{fechaReserva}', {idEstadoReserva})";
                    Utilidades.ejecutar(cmdInsertReserva);
                }


                string cmdGetReservaId = $"SELECT id_reserva FROM Reserva WHERE id_cita = {idCita}";
                DataSet dsReserva = Utilidades.ejecutar(cmdGetReservaId);
                int idReserva = Convert.ToInt32(dsReserva.Tables[0].Rows[0]["id_reserva"]);

                string cmdGetCalculoId = $"SELECT id_calculo FROM Calculo WHERE id_cita = {idCita}";
                DataSet dsCalculo = Utilidades.ejecutar(cmdGetCalculoId);
                int idCalculo = Convert.ToInt32(dsCalculo.Tables[0].Rows[0]["id_calculo"]);


                string cmdGetServicios = $"SELECT id_servicio FROM CalculoServicio WHERE id_calculo = {idCalculo}";
                DataSet dsServicios = Utilidades.ejecutar(cmdGetServicios);

                foreach (DataRow row in dsServicios.Tables[0].Rows)
                {
                    int idServicio = Convert.ToInt32(row["id_servicio"]);

                    string cmdInsertReservaServicio =
                        $@"INSERT INTO Reserva_Servicio (id_reserva, id_servicio) 
           VALUES ({idReserva}, {idServicio})";

                    Utilidades.ejecutar(cmdInsertReservaServicio);
                }
                string cmdUpdateCita = $@"UPDATE Cita SET 
                id_estado = 11
                WHERE id_cita = {idCita}";
                Utilidades.ejecutar(cmdUpdateCita);

                MessageBox.Show($"Reserva {estadoReserva} correctamente.\nFecha de reserva: {fechaReserva}", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar este formulario y volver al menú principal
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la reserva: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.SelectedRows.Count == 0 && cmbIdCita.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una cita primero.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar esta reserva?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    int idCita;

                    if (dgvCitas.SelectedRows.Count > 0)
                    {
                        DataGridViewRow row = dgvCitas.SelectedRows[0];
                        idCita = Convert.ToInt32(row.Cells["IdCita"].Value);
                    }
                    else if (cmbIdCita.SelectedItem != null)
                    {
                        KeyValuePair<int, string> selectedItem = (KeyValuePair<int, string>)cmbIdCita.SelectedItem;
                        idCita = selectedItem.Key;
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ninguna cita.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Eliminar de la BD
                    string cmdDelete = $"DELETE FROM Cita WHERE id_cita = {idCita}";
                    Utilidades.ejecutar(cmdDelete);

                    MessageBox.Show("Reserva eliminada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar datos
                    CargarDatosCitas();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la reserva: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtIdVehiculo.Clear();
            txtNombre.Clear(); 
            txtApellido.Clear(); 
            txtModelo.Clear();
            cmbEstadoReserva.SelectedIndex = -1;
            cmbEstadoVehiculo.SelectedIndex = -1;
            cmbIdCita.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;

            if (dgvCitas.Rows.Count > 0)
            {
                dgvCitas.ClearSelection();
            }
        }

        public void ActualizarDesdeCita(int idCliente, int idVehiculo, string nombre, string apellido, string modelo, int idEstadoVehiculo)
        {
            txtIdCliente.Text = idCliente.ToString();
            txtIdVehiculo.Text = idVehiculo.ToString();
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtModelo.Text = modelo;
            dateTimePicker1.Value = DateTime.Now;
            for (int i = 0; i < cmbEstadoVehiculo.Items.Count; i++)
            {
                KeyValuePair<int, string> item = (KeyValuePair<int, string>)cmbEstadoVehiculo.Items[i];
                if (item.Key == idEstadoVehiculo)
                {
                    cmbEstadoVehiculo.SelectedIndex = i;
                    break;
                }
            }

            CargarDatosCitas();
        }


    }
}
    



