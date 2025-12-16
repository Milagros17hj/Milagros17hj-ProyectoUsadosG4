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
        private decimal precioVehiculo = 0;

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            CargarEntidadesFinancieras();
            CargarServiciosAdicionales();
            InicializarValores();
        }
        public frmCalculadoraF()
        {
            InitializeComponent();
        }
        private void InicializarValores()
        {
            txtInteres.Text = "8.5";
            txtImpuesto.Text = "13"; // IVA 13%
            txtMesesPlazo.Text = "36";
            txtPrima.Text = "0";
        }
        private void CargarEntidadesFinancieras()
        {
            try
            {
                string comando = "SELECT IdEntidad, NombreEntidad, TasaInteres FROM EntidadFinanciera";
                ds = Utilidades.ejecutar(comando);

                if (ds.Tables.Count > 0)
                {
                    cmbEntidadFinanciera.DataSource = ds.Tables[0];
                    cmbEntidadFinanciera.DisplayMember = "NombreEntidad";
                    cmbEntidadFinanciera.ValueMember = "IdEntidad";
                    cmbEntidadFinanciera.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar bancos: {ex.Message}", "Error");

                CargarBancosSimulados();
            }
        }
        private void CargarBancosSimulados()
        {
            // Datos de respaldo por si falla la BD
            cmbEntidadFinanciera.Items.Clear();
            cmbEntidadFinanciera.Items.Add("Banco Nacional - 9.5%");
            cmbEntidadFinanciera.Items.Add("Banco de Costa Rica - 9.0%");
            cmbEntidadFinanciera.Items.Add("BAC Credomatic - 8.5%");
            cmbEntidadFinanciera.SelectedIndex = 0;
        }
        private void CargarServiciosAdicionales()
        {
            try
            {

                string comando = "SELECT IdServicio, descripcion, costo FROM ServicioAdicional";
                ds = Utilidades.ejecutar(comando);

                if (ds.Tables.Count > 0)
                {
                    checkedListBox1.Items.Clear();
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {

                        decimal costo = Convert.ToDecimal(row["costo"]);
                        string itemText = $"{row["descripcion"]} - ₡{costo:N0}";
                        checkedListBox1.Items.Add(itemText, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar servicios: {ex.Message}", "Error");
                // Si falla, carga datos simulados
                CargarServiciosSimulados();
            }

        }
        private void CargarServiciosSimulados()
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Financiamiento - ₡0");
            checkedListBox1.Items.Add("Mantenimiento - ₡180,000");
            checkedListBox1.Items.Add("Seguro - ₡55,000");
            checkedListBox1.Items.Add("Garantía extendida - ₡75,000");
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //  Validar que haya precio
                    if (!decimal.TryParse(txtPrecio.Text, out precioVehiculo) || precioVehiculo <= 0)
                    {
                        return;
                    }

                    // Calcular servicios seleccionados DESDE LA BD
                    decimal serviciosTotal = CalcularTotalServicios();

                    //  Calcular impuesto (13%)
                    decimal impuesto = precioVehiculo * 0.13m;
                    txtImpuesto.Text = impuesto.ToString("N0");

                    // Subtotal
                    decimal subtotal = precioVehiculo + serviciosTotal + impuesto;

                    // Si es CONTADO
                    if (chkContado.Checked)
                    {
                        txtTotalCalculo.Text = subtotal.ToString("N0");
                        txtCuotaMensual.Text = "0";
                        txtInteres.Text = "0";
                        return;
                    }

                    // Si es FINANCIADO
                    // Obtener prima
                    decimal prima = 0;
                    if (!decimal.TryParse(txtPrima.Text, out prima) || prima < 0)
                    {
                        prima = 0;
                        txtPrima.Text = "0";
                    }

                    // Obtener meses
                    int meses = 36;
                    if (!int.TryParse(txtMesesPlazo.Text, out meses) || meses < 12)
                    {
                        meses = 36;
                        txtMesesPlazo.Text = "36";
                    }

                    // Obtener tasa de interés DESDE LA BD
                    decimal tasaInteres = ObtenerTasaInteres();

                    // Calcular monto a financiar
                    decimal montoFinanciar = subtotal - prima;
                    if (montoFinanciar < 0) montoFinanciar = 0;

                    // Calcular interés total
                    decimal interesTotal = montoFinanciar * tasaInteres * (meses / 12m);

                    // Calcular cuota mensual
                    decimal totalPagar = montoFinanciar + interesTotal;
                    decimal cuotaMensual = meses > 0 ? totalPagar / meses : 0;

                    // Calcular total factura
                    decimal totalFactura = subtotal + interesTotal;

                    // Mostrar resultados
                    txtInteres.Text = (tasaInteres * 100).ToString("N1");
                    txtTotalCalculo.Text = totalFactura.ToString("N0");
                    txtCuotaMensual.Text = cuotaMensual.ToString("N0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en cálculo: " + ex.Message, "Error");
                }
            }
        }
        private decimal CalcularTotalServicios()
        {
            decimal total = 0;

            try
            {
                // Obtener datos de servicios desde la BD
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            // Extraer el costo del texto del item
                            string itemText = checkedListBox1.Items[i].ToString();

                            // Buscar el patrón "₡" seguido de números con/sin separadores
                            int colonIndex = itemText.IndexOf('₡');
                            if (colonIndex >= 0)
                            {
                                string costoStr = itemText.Substring(colonIndex + 1);

                                // Remover puntos (separadores de miles) y espacios
                                costoStr = costoStr.Replace(".", "").Replace(" ", "");

                                if (decimal.TryParse(costoStr, out decimal costo))
                                {
                                    total += costo;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al calcular servicios: {ex.Message}", "Error");
            }

            return total;
        }

        private decimal ObtenerTasaInteres()
        {
            try
            {
                if (cmbEntidadFinanciera.SelectedValue != null)
                {
                    // Obtener el ID de la entidad seleccionada
                    string idEntidad = cmbEntidadFinanciera.SelectedValue.ToString();

                    // Buscar la tasa de interés en los datos cargados
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        DataTable dt = ds.Tables[0];
                        DataRow[] rows = dt.Select($"IdEntidad = '{idEntidad}'");

                        if (rows.Length > 0)
                        {
                            // Asumiendo que la columna se llama "TasaInteres"
                            if (dt.Columns.Contains("TasaInteres"))
                            {
                                string tasaStr = rows[0]["TasaInteres"].ToString();
                                if (decimal.TryParse(tasaStr, out decimal tasaDecimal))
                                {
                                    return tasaDecimal / 100m; // Convertir porcentaje a decimal (ej: 8.5% -> 0.085)
                                }
                            }
                        }
                    }
                }

                
                return 0.085m; // 8.5%
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener tasa de interés: {ex.Message}", "Error");
                return 0.085m; // Valor por defecto
            }
        }

        
        private bool ValidarEntradas()
        {
            // Validar precio
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor ingrese un precio válido mayor a 0", "Validación");
                txtPrecio.Focus();
                return false;
            }

            // Validar prima (si es financiado)
            if (!chkContado.Checked)
            {
                if (!decimal.TryParse(txtPrima.Text, out decimal prima) || prima < 0)
                {
                    MessageBox.Show("Por favor ingrese una prima válida (0 o mayor)", "Validación");
                    txtPrima.Focus();
                    return false;
                }

                // Validar meses plazo
                if (!int.TryParse(txtMesesPlazo.Text, out int meses) || meses < 12 || meses > 84)
                {
                    MessageBox.Show("Por favor ingrese un plazo entre 12 y 84 meses", "Validación");
                    txtMesesPlazo.Focus();
                    return false;
                }
            }

            return true;
        }
    }
}