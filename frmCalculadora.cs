using libreriaIII2025;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUsadosGrupo4
{
    public partial class frmCalculadora : Form
    {
        private int _idVehiculo;
        private decimal _precioVehiculo;
        private decimal _Prima;
        private int _MesesPlazo;

        private decimal precioSeguro;
        private decimal precioMantenimiento;
        private decimal precioGarantia;


        public frmCalculadora(int idVehiculo, decimal precioVehiculo)
        {
            InitializeComponent();
            _idVehiculo = idVehiculo;
            _precioVehiculo = precioVehiculo;
        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmCatalogoVehiculos frmCatalogo = new frmCatalogoVehiculos();
            frmCatalogo.MdiParent = this.MdiParent; 
            frmCatalogo.Show();                     
            this.Close();
        }


        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            btnCita.Enabled = false; 

            txtPrima.Enabled = false;
            txtMesesPlazo.Enabled = false;
            ckbFinanciamiento.Checked = false;
            cmbEntidadFinanciera.Enabled = false;
            try
            {
                DataSet dsEntidades = Utilidades.ejecutar(
                    "SELECT id_entidad, NombreEntidad, Plazo, TasaInteres FROM EntidadFinanciera");

                DataTable tabla = dsEntidades.Tables[0];
                cmbEntidadFinanciera.DataSource = tabla;
                cmbEntidadFinanciera.DisplayMember = "NombreEntidad";
                cmbEntidadFinanciera.ValueMember = "id_entidad";
                cmbEntidadFinanciera.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar entidades financieras: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtVehiculo.Text = ObtenerNombreVehiculo(_idVehiculo);
            txtPrecio.Text = _precioVehiculo.ToString("N2");

            CargarServiciosAdicionales();
        }

        private string ObtenerNombreVehiculo(int idVehiculo)
        {
            try
            {
                DataSet ds = Utilidades.ejecutar("SELECT marca FROM Vehiculo WHERE id_vehiculo = " + idVehiculo);
                DataTable tabla = ds.Tables[0];

                if (tabla.Rows.Count > 0)
                    return tabla.Rows[0]["marca"].ToString();
                else
                    return "Marca no encontrada";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la marca: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }



        private void ckbFinanciamiento_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFinanciamiento.Checked)
            {
                cmbEntidadFinanciera.Enabled = true;
                txtMesesPlazo.Enabled = true;
                txtPrima.Enabled = true;
            }
            else
            {
                cmbEntidadFinanciera.Enabled = false;
                cmbEntidadFinanciera.SelectedIndex = -1;

                txtMesesPlazo.Enabled = false;
                txtMesesPlazo.Text = "";

                txtPrima.Enabled = false;
                txtPrima.Text = "";
            }

        }

        private void CargarServiciosAdicionales()
        {
            DataSet ds = Utilidades.ejecutar("SELECT descripcion, costo FROM ServicioAdicional");
            DataTable tabla = ds.Tables[0];

            foreach (DataRow fila in tabla.Rows)
            {
                string descripcion = fila["descripcion"].ToString();
                decimal costo = Convert.ToDecimal(fila["costo"]);

                if (descripcion == "Seguro") precioSeguro = costo;
                if (descripcion == "Mantenimiento") precioMantenimiento = costo;
                if (descripcion == "Garantía extendida") precioGarantia = costo;
            }
        }
        private decimal CalcularServiciosAdicionales()
        {
            decimal total = 0m;

            if (ckbSeguro.Checked) total += precioSeguro;
            if (ckbmantenimiento.Checked) total += precioMantenimiento;
            if (ckbGarantia.Checked) total += precioGarantia;

            return total;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            //Verificar si ya existe una reserva o venta activa para este vehículo
            string cmdCheckReserva = $"SELECT COUNT(*) AS Cantidad " +
                     $"FROM Reserva " +
                     $"WHERE id_vehiculo = {_idVehiculo} AND (id_estado = 1 OR id_estado = 8)";

            DataSet dsCheck = Utilidades.ejecutar(cmdCheckReserva);
            int cantidad = Convert.ToInt32(dsCheck.Tables[0].Rows[0]["Cantidad"]);

            if (cantidad > 0)
            {
                MessageBox.Show("Este vehículo ya está reservado o vendido. No se puede agendar otra cita.",
                                "Reserva/Venta existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnCita.Enabled = true; 

            // SIN financiamiento
            if (!ckbFinanciamiento.Checked)
            {
                decimal serviciosExtras = CalcularServiciosAdicionales();
                decimal impuesto = _precioVehiculo * 0.13m;
                decimal totalFactura = _precioVehiculo + impuesto + serviciosExtras;

                txtCuotaMensual.Text = "0.00";
                txtTotalCalculo.Text = totalFactura.ToString("0.00");
                txtInteres.Text = "0";
                txtImpuesto.Text = impuesto.ToString("0.00");
                return;
            }

            // Validar Prima
            if (!decimal.TryParse(txtPrima.Text.Trim(), out _Prima) || _Prima < 3600000)
            {
                MessageBox.Show("La prima debe ser mayor o igual a 3,600,000.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar Plazo
            if (!int.TryParse(txtMesesPlazo.Text.Trim(), out _MesesPlazo) || _MesesPlazo < 12 || _MesesPlazo > 60)
            {
                MessageBox.Show("El plazo debe estar entre 12 y 60 meses.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar entidad
            if (cmbEntidadFinanciera.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una entidad financiera.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView entidad = cmbEntidadFinanciera.SelectedItem as DataRowView;
            decimal tasaInteres = Convert.ToDecimal(entidad["TasaInteres"]);
            int plazoMaximo = Convert.ToInt32(entidad["Plazo"]);

            if (_MesesPlazo > plazoMaximo)
            {
                MessageBox.Show($"El plazo máximo permitido por la entidad es {plazoMaximo} meses.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal serviciosExtrasFin = CalcularServiciosAdicionales();

            Prestamo prestamo = new Prestamo(
                _precioVehiculo,
                _Prima,
                _MesesPlazo,
                tasaInteres,
                serviciosExtrasFin
            );

            if (prestamo.Calcular())
            {
                txtCuotaMensual.Text = prestamo.CuotaMensual.ToString("0.00");
                txtTotalCalculo.Text = prestamo.TotalFactura.ToString("0.00");
                txtInteres.Text = prestamo.TasaInteres.ToString("0.00");
                txtImpuesto.Text = prestamo.Impuesto.ToString("0.00");
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtPrima.Text = "";
            txtMesesPlazo.Text = "";
            txtCuotaMensual.Text = "";
            txtTotalCalculo.Text = "";
            txtInteres.Text = "";
            txtImpuesto.Text = "";

            ckbFinanciamiento.Checked = false;
            ckbSeguro.Checked = false;
            ckbmantenimiento.Checked = false;
            ckbGarantia.Checked = false;

            cmbEntidadFinanciera.SelectedIndex = -1;
            cmbEntidadFinanciera.Enabled = false;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            CrearCita();
        }
        private void CrearCita()
        {
            try
            {
                if (Sesiones.IdCliente <= 0)
                {
                    MessageBox.Show("No hay cliente logueado.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Función simple para limpiar espacios y símbolos que puedan causar error
                string limpiar(string valor)
                {
                    if (string.IsNullOrWhiteSpace(valor)) return "0";
                    // Eliminar símbolos y espacios que puedan romper el SQL
                    valor = valor.Replace("₡", "").Replace("%", "").Replace(" ", "").Trim();
                    valor = valor.Replace(",", "."); // para que decimal sea con punto
                    return valor;
                }
                if (Sesiones.IdCliente <= 0)
                {
                    MessageBox.Show("No hay cliente logueado.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

          

                // 1. Insertar cita
                string cmdInsertCita = "INSERT INTO Cita (id_cliente, id_vehiculo) " +
                                       "VALUES (" + Sesiones.IdCliente + ", " + _idVehiculo + "); SELECT SCOPE_IDENTITY();";

                DataSet dsCita = Utilidades.ejecutar(cmdInsertCita);
                int idCita = Convert.ToInt32(dsCita.Tables[0].Rows[0][0]);

                // 2. Preparar valores limpios para Calculo
                string montoTotal = limpiar(txtTotalCalculo.Text);
                string cuotaMensual = limpiar(txtCuotaMensual.Text);

                int plazoMesesInt = int.TryParse(txtMesesPlazo.Text.Trim(), out int p) ? p : 0;
                string prima = limpiar(txtPrima.Text);
                string impuesto = limpiar(txtImpuesto.Text);

                string tasaInteres = "0";
                string idEntidad = "NULL";

                if (cmbEntidadFinanciera.SelectedIndex >= 0)
                {
                    DataRowView entidad = (DataRowView)cmbEntidadFinanciera.SelectedItem;

                    tasaInteres = limpiar(entidad["TasaInteres"].ToString());

                    string rawEntidad = entidad["id_entidad"].ToString();
                    if (!string.IsNullOrWhiteSpace(rawEntidad))
                        idEntidad = rawEntidad.Trim();
                }

                // Armar consulta INSERT para Calculo
                string cmdInsertCalculo = "INSERT INTO Calculo " +
                    "(id_cita, monto_total, cuota_mensual, plazo_meses, prima, tasa_interes, id_entidad, impuesto_iva) " +
                    "VALUES (" + idCita + ", " + montoTotal + ", " + cuotaMensual + ", " + plazoMesesInt + ", " +
                    prima + ", " + tasaInteres + ", " + idEntidad + ", " + impuesto + "); SELECT SCOPE_IDENTITY();";

                DataSet dsCalculo = Utilidades.ejecutar(cmdInsertCalculo);
                int idCalculo = Convert.ToInt32(dsCalculo.Tables[0].Rows[0][0]);

                // 3. Insertar servicios adicionales
                if (ckbFinanciamiento.Checked)
                    Utilidades.ejecutar($"INSERT INTO CalculoServicio (id_calculo, id_servicio) VALUES ({idCalculo}, 1)");

                if (ckbmantenimiento.Checked)
                    Utilidades.ejecutar($"INSERT INTO CalculoServicio (id_calculo, id_servicio) VALUES ({idCalculo}, 2)");

                if (ckbSeguro.Checked)
                    Utilidades.ejecutar($"INSERT INTO CalculoServicio (id_calculo, id_servicio) VALUES ({idCalculo}, 3)");

                if (ckbGarantia.Checked)
                    Utilidades.ejecutar($"INSERT INTO CalculoServicio (id_calculo, id_servicio) VALUES ({idCalculo}, 4)");

                MessageBox.Show("Cita agendada correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cita : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }


}

