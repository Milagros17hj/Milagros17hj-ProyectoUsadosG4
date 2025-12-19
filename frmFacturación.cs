using libreriaIII2025;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoUsadosGrupo4
{
    public partial class frmFacturación : Form
    {
        private DataSet ds;
        private int idUsuarioLogueado;
        private int idCajera;
        private int idReservaSeleccionada;
        private int idVehiculoSeleccionado;
        private DataTable dtReservas;

        public frmFacturación(int idUsuario)
        {
            InitializeComponent();
            idUsuarioLogueado = idUsuario;

            cmbReserva.SelectedIndexChanged += cmbReserva_SelectedIndexChanged;
        
        }

        private void frmFacturación_Load(object sender, EventArgs e)
        {
            CargarDatosCajera(idUsuarioLogueado);
            CargarTiposPago();
            CargarReservasAprobadas();
            LimpiarFormulario();
        
        }
        private void CargarDatosCajera(int idUsuario)

        {
            idCajera = idUsuario;
            txtCajera.Text = "Cajera ID: " + idUsuario;
        }
        private void CargarTiposPago()
        {
            string cmd = "SELECT id_tipo_pago, descripcion FROM TipoPago";
            DataSet dsTipos = Utilidades.ejecutar(cmd);

            if (dsTipos.Tables.Count > 0 && dsTipos.Tables[0].Rows.Count > 0)
            {
                cmbTipoPago.DataSource = dsTipos.Tables[0];
                cmbTipoPago.DisplayMember = "descripcion";
                cmbTipoPago.ValueMember = "id_tipo_pago";
                cmbTipoPago.SelectedIndex = -1; 
            }
        }

        private void CargarReservasAprobadas()
        {
            string cmd = @"
SELECT 
    r.id_reserva,
    r.id_vehiculo,
    ci.id_cita,
    ISNULL(CONCAT(cl.nombre,' ',cl.primer_apellido), 'Cliente no asignado') AS cliente,
    c.monto_total,
    c.impuesto_iva,
    c.prima,
    c.tasa_interes,
    c.plazo_meses,
    c.cuota_mensual
FROM Reserva r
INNER JOIN Cita ci ON r.id_cita = ci.id_cita
INNER JOIN Calculo c ON ci.id_cita = c.id_cita
LEFT JOIN Cliente cl ON ci.id_cliente = cl.id_cliente
WHERE r.id_estado = 9";

            DataSet dsReservas = Utilidades.ejecutar(cmd);

            if (dsReservas.Tables.Count == 0 || dsReservas.Tables[0].Rows.Count == 0)
            {
                cmbReserva.DataSource = null;
                MessageBox.Show("No hay reservas aprobadas");
                return;
            }

            dtReservas = dsReservas.Tables[0];

            cmbReserva.DataSource = dtReservas;
            cmbReserva.DisplayMember = "cliente";
            cmbReserva.ValueMember = "id_reserva";
            cmbReserva.SelectedIndex = -1;
        }


        private void EstablecerValoresIniciales()
        {
            txtNombre.Clear();
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtPrima.Clear();
            txtInteres.Clear();
            txtPlazo.Clear();
            txtCuota.Clear();
            txtTotal.Clear();

            cmbTipoPago.SelectedIndex = -1;
            btnFacturar.Enabled = false;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = false;

            GenerarNumeroFactura();

            txtNombre.Enabled = true;
            txtSubtotal.Enabled = true;
            txtImpuesto.Enabled = true;
            txtTotal.Enabled = true;

            txtPrima.Enabled = false;
            txtInteres.Enabled = false;
            txtPlazo.Enabled = false;
            txtCuota.Enabled = false;
        }




        private void GenerarNumeroFactura()
        {
            Random rnd = new Random();
            int numeroFactura = rnd.Next(100000, 999999);
            txtFactura.Text = $"FACT-{numeroFactura:000000}";
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtSubtotal.Text = "";
            txtImpuesto.Text = "";
            txtPrima.Text = "";
            txtInteres.Text = "";
            txtPlazo.Text = "";
            txtCuota.Text = "";
            txtTotal.Text = "";

            cmbTipoPago.SelectedIndex = -1;
            btnFacturar.Enabled = false;
        }


        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPago.SelectedIndex == -1)
                return;

            if (cmbTipoPago.SelectedValue == null)
                return;

            int idTipoPago;

            if (!int.TryParse(cmbTipoPago.SelectedValue.ToString(), out idTipoPago))
                return;

            bool esFinanciamiento = idTipoPago == 3; // 3 = Financiado

            txtEntidadFinanciera.Enabled = esFinanciamiento;

            if (!esFinanciamiento)
            {
                txtEntidadFinanciera.Clear();
                txtPrima.Clear();
                txtInteres.Clear();
                txtPlazo.Clear();
                txtCuota.Clear();
            }
        }


        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (idReservaSeleccionada == 0 || cmbTipoPago.SelectedValue == null)
            {
                MessageBox.Show("Seleccione reserva y tipo de pago");
                return;
            }

            string cmdEnc = $@"INSERT INTO FacturaEncabezado(id_reserva, id_cajera, fecha, id_tipo_pago, total, id_entidad)
             VALUES ({idReservaSeleccionada}, {idCajera}, GETDATE(),
             {cmbTipoPago.SelectedValue}, {txtTotal.Text}, 1)";


            Utilidades.ejecutar(cmdEnc);

            string cmdFactura = "SELECT MAX(id_factura) AS id FROM FacturaEncabezado";
            ds = Utilidades.ejecutar(cmdFactura);
            int idFactura = Convert.ToInt32(ds.Tables[0].Rows[0]["id"]);

            string cmdDet = $@"
                INSERT INTO FacturaDetalle
                (id_factura, subtotal, iva, prima, interes, seguro, meses_plazo, cuota_mensual)
                VALUES ({idFactura}, {txtSubtotal.Text}, {txtImpuesto.Text},
                        {txtPrima.Text}, {txtInteres.Text}, 0,
                        {txtPlazo.Text}, {txtCuota.Text})";

            Utilidades.ejecutar(cmdDet);

            Utilidades.ejecutar($"UPDATE Reserva SET id_estado = 6 WHERE id_reserva = {idReservaSeleccionada}");
            Utilidades.ejecutar($"UPDATE Vehiculo SET id_estado = 7 WHERE id_vehiculo = {idVehiculoSeleccionado}");

            MessageBox.Show("Factura guardada correctamente");
            LimpiarFormulario();
            CargarReservasAprobadas();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbReserva_SelectedIndexChanged(object sender, EventArgs e)
           
        {

            if (dtReservas == null || cmbReserva.SelectedIndex == -1)
                return;

            if (!(cmbReserva.SelectedItem is DataRowView fila))
                return;

            idReservaSeleccionada = Convert.ToInt32(fila["id_reserva"]);
            idVehiculoSeleccionado = Convert.ToInt32(fila["id_vehiculo"]);

            txtNombre.Text = fila["cliente"].ToString();
            txtSubtotal.Text = fila["monto_total"].ToString();
            txtImpuesto.Text = fila["impuesto_iva"].ToString();
            txtPrima.Text = fila["prima"].ToString();
            txtInteres.Text = fila["tasa_interes"].ToString();
            txtPlazo.Text = fila["plazo_meses"].ToString();
            txtCuota.Text = fila["cuota_mensual"].ToString();

            // total = monto + iva
            decimal monto = Convert.ToDecimal(fila["monto_total"]);
            decimal iva = Convert.ToDecimal(fila["impuesto_iva"]);
            txtTotal.Text = (monto + iva).ToString("0.00");

            btnFacturar.Enabled = true;
        }

    }


}







   
    


