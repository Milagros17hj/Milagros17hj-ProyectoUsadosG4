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
    public partial class frmCalculadoraF : Form
    {
        private DataSet ds;
        private DataSet dsServicios;
        private decimal precioVehiculo = 0;

        public frmCalculadoraF()
        {
            InitializeComponent();
        }

        private void frmCalculadoraF_Load(object sender, EventArgs e)
        {
            InicializarValores();
            CargarEntidadesFinancieras();
            CargarServiciosAdicionales();
        }

        private void InicializarValores()
        {
            txtInteres.Text = "0";
            txtImpuesto.Text = "13";
            txtMesesPlazo.Text = "60";
            txtPrima.Text = "0";
            txtTipoVehiculo.Text = "Sedán";

            // Inicializar como contado
            chkContado.Checked = true;
            HabilitarControlesFinanciamiento();
        }

        private void CargarEntidadesFinancieras()
        {

            try
            {
                string comando = "SELECT id_entidad, NombreEntidad, TasaInteres, Plazo FROM EntidadFinanciera";
                ds = Utilidades.ejecutar(comando);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    cmbEntidadFinanciera.DataSource = ds.Tables[0];
                    cmbEntidadFinanciera.DisplayMember = "NombreEntidad";
                    cmbEntidadFinanciera.ValueMember = "id_entidad";
                    cmbEntidadFinanciera.SelectedIndex = 0;

                    // Cargar el plazo máximo después de cargar los datos
                    CargarPlazoMaximo();
                }
                else
                {
                    CargarDatosSimulados();
                }
            }
            catch
            {
                CargarDatosSimulados();
            }
        }

        private void CargarDatosSimulados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id_entidad", typeof(int));
            dt.Columns.Add("NombreEntidad", typeof(string));
            dt.Columns.Add("TasaInteres", typeof(decimal));
            dt.Columns.Add("Plazo", typeof(int));

            dt.Rows.Add(2, "Banco Nacional - 9.5%", 0.095m, 60);
            dt.Rows.Add(3, "BAC Credomatic - 8.5%", 0.085m, 60);
            dt.Rows.Add(4, "Banco de Costa Rica - 9.0%", 0.090m, 60);

            cmbEntidadFinanciera.DataSource = dt;
            cmbEntidadFinanciera.DisplayMember = "NombreEntidad";
            cmbEntidadFinanciera.ValueMember = "id_entidad";
            cmbEntidadFinanciera.SelectedIndex = 0;

      
            CargarPlazoMaximo();
        }

        private void CargarServiciosAdicionales()
        {
            try
            {
                string comando = "SELECT IdServicio, descripcion, costo FROM ServicioAdicional";
                dsServicios = Utilidades.ejecutar(comando);

                checkedListBox1.Items.Clear();

                if (dsServicios != null && dsServicios.Tables.Count > 0)
                {
                    foreach (DataRow row in dsServicios.Tables[0].Rows)
                    {
                        decimal costo = Convert.ToDecimal(row["costo"]);
                        string descripcion = row["descripcion"].ToString();
                        checkedListBox1.Items.Add($"{descripcion} - ₡{costo:N0}");
                    }
                }
                else
                {
                    checkedListBox1.Items.Add("Financiamiento - ₡0");
                    checkedListBox1.Items.Add("Seguro - ₡55,000");
                    checkedListBox1.Items.Add("Mantenimiento - ₡180,000");
                }
            }
            catch
            {
                checkedListBox1.Items.Add("Financiamiento - ₡0");
                checkedListBox1.Items.Add("Seguro - ₡55,000");
                checkedListBox1.Items.Add("Mantenimiento - ₡180,000");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
          /////////  if (!ValidarDatos()) return;

            precioVehiculo = decimal.Parse(txtPrecio.Text);

            // Calcular servicios
            decimal servicios = CalcularServicios();

            // Calcular IVA (13%)
            decimal iva = precioVehiculo * 0.13m;
            txtImpuesto.Text = iva.ToString("N0");

            // Calcular subtotal
            decimal subtotal = precioVehiculo + servicios + iva;

            // Si es CONTADO
            if (chkContado.Checked)
            {
                txtTotalCalculo.Text = subtotal.ToString("N0");
                txtCuotaMensual.Text = "0";
                txtInteres.Text = "0";
                return;
            }

            // Si es FINANCIADO
            decimal prima = decimal.Parse(txtPrima.Text);
            int meses = int.Parse(txtMesesPlazo.Text);
            decimal tasa = ObtenerTasaInteres();

            // Monto a financiar
            decimal montoFinanciar = subtotal - prima;
            if (montoFinanciar < 0) montoFinanciar = 0;

            // Calcular intereses
            decimal interesTotal = montoFinanciar * tasa * (meses / 12m);

            // Calcular cuota mensual
            decimal cuotaMensual = meses > 0 ? (montoFinanciar + interesTotal) / meses : 0;

            // Mostrar resultados
            txtInteres.Text = (tasa * 100).ToString("N1");
            txtCuotaMensual.Text = cuotaMensual.ToString("N0");
            txtTotalCalculo.Text = (subtotal + interesTotal).ToString("N0");
        }

        private decimal CalcularServicios()
        {
            decimal total = 0;

            foreach (string item in checkedListBox1.CheckedItems)
            {
                if (item.Contains("Financiamiento")) continue;

                int index = item.IndexOf('₡');
                if (index >= 0)
                {
                    string costoStr = item.Substring(index + 1).Replace(".", "").Replace(",", "");
                    if (decimal.TryParse(costoStr, out decimal costo))
                        total += costo;
                }
            }

            return total;
        }

        private decimal ObtenerTasaInteres()
        {
            try
            {
                if (cmbEntidadFinanciera.SelectedValue != null && ds != null)
                {
                    string id = cmbEntidadFinanciera.SelectedValue.ToString();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if (row["id_entidad"].ToString() == id)
                            return Convert.ToDecimal(row["TasaInteres"]);
                    }
                }
                return 0.085m;
            }
            catch
            {
                return 0.085m;
            }
        }

       

        private void chkContado_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarControlesFinanciamiento();
        }
        private void HabilitarControlesFinanciamiento()
        {
            bool habilitar = !chkContado.Checked;
            txtPrima.Enabled = habilitar;
            txtMesesPlazo.Enabled = habilitar;
            cmbEntidadFinanciera.Enabled = habilitar;

            if (chkContado.Checked)
            {
                txtInteres.Text = "0";
                txtCuotaMensual.Text = "0";
            }
            else if (cmbEntidadFinanciera.SelectedIndex >= 0)
            {
                // Cargar datos de la entidad seleccionada
                txtInteres.Text = (ObtenerTasaInteres() * 100).ToString("N1");
                CargarPlazoMaximo();
            }
        }

        private void cmbEntidadFinanciera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkContado.Checked && cmbEntidadFinanciera.SelectedIndex >= 0)
            {
                // Actualizar tasa de interés
                txtInteres.Text = (ObtenerTasaInteres() * 100).ToString("N1");

                // Actualizar plazo máximo
                CargarPlazoMaximo();
            }
        }

        private void btnReservarCita_Click(object sender, EventArgs e)
        {
            if (ValidarParaReservar())
            {
                string tipoPago = chkContado.Checked ? "CONTADO" : "FINANCIADO";
                string mensajeReserva = $"CITA RESERVADA EXITOSAMENTE\n\n";
                mensajeReserva += $"Tipo de vehículo: {txtTipoVehiculo.Text}\n";
                mensajeReserva += $"Precio: ₡{txtPrecio.Text}\n";
                mensajeReserva += $"Forma de pago: {tipoPago}\n";
                mensajeReserva += $"Total: ₡{txtTotalCalculo.Text}\n";

                if (!chkContado.Checked)
                {
                    mensajeReserva += $"Entidad: {cmbEntidadFinanciera.Text}\n";
                    mensajeReserva += $"Cuota mensual: ₡{txtCuotaMensual.Text}\n";
                }

                MessageBox.Show(mensajeReserva, "Reserva Confirmada",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidarParaReservar()
        {
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Debe ingresar un precio válido", "Validación");
                return false;
            }

            if (string.IsNullOrEmpty(txtTotalCalculo.Text) || txtTotalCalculo.Text == "0")
            {
                MessageBox.Show("Debe realizar el cálculo primero", "Validación");
                return false;
            }

            return true;
        }
        private void CargarPlazoMaximo()
        {
            try
            {
                if (cmbEntidadFinanciera.SelectedValue != null && ds != null && ds.Tables.Count > 0)
                {
                    string idEntidad = cmbEntidadFinanciera.SelectedValue.ToString();
                    DataTable dt = ds.Tables[0];

                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["id_entidad"].ToString() == idEntidad)
                        {
                            if (row["Plazo"] != DBNull.Value)
                            {
                                int plazo = Convert.ToInt32(row["Plazo"]);
                                txtMesesPlazo.Text = plazo.ToString();
                                return;
                            }
                        }
                    }
                }
                txtMesesPlazo.Text = "60"; // Valor por defecto si no se encuentra
            }
            catch
            {
                txtMesesPlazo.Text = "60";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
