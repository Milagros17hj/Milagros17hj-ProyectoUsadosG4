using libreriaIII2025;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUsadosGrupo4
{
    public partial class frmDetallesVehiculo : Form
    {
        public frmDetallesVehiculo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCatalogoVehiculos frmCatalogo = new frmCatalogoVehiculos();
            frmCatalogo.MdiParent = this.MdiParent; // mismo contenedor (menú)
            frmCatalogo.Show();
            this.Close(); // cerrar el detalle
        }


        

        private DatosVehiculo vehiculoActual;

            public frmDetallesVehiculo(DatosVehiculo vehiculo)
        {
            InitializeComponent();
            vehiculoActual = vehiculo;

            // Datos principales
            txtTipo.Text = vehiculoActual.TipoVehiculo;
            txtClase.Text = vehiculoActual.Clase;
            txtMarca.Text = vehiculoActual.Marca;
            txtModelo.Text = vehiculoActual.Modelo;
            txtAño.Text = vehiculoActual.Año.ToString();
            txtPrecio.Text = vehiculoActual.Precio.ToString("C");

            // Características técnicas
            txtMotor.Text = vehiculoActual.Motor;
            txtCombustible.Text = vehiculoActual.Combustible;
            txtTransmision.Text = vehiculoActual.Transmision;
            txtPasajeros.Text = vehiculoActual.Pasajeros.ToString();

            // Equipamiento
            rtbEqBasico.Text = vehiculoActual.EquipamientoBasico;
            rtbConfort.Text = vehiculoActual.Confort;
            rtbAudioVideo.Text = vehiculoActual.AudioVideo;
            rtbSeguridad.Text = vehiculoActual.Seguridad;
            rtbInfoExtra.Text = vehiculoActual.Otros;

        
            txtEstado.Text = ObtenerDescripcionEstado(vehiculoActual.IdEstado);

            // Imagen
            string ruta = Path.Combine(Application.StartupPath, "ImagenesVehiculos", vehiculoActual.ImagenPath);
                if (File.Exists(ruta))
                {
                    pbVehiculo.ImageLocation = ruta;
                    pbVehiculo.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pbVehiculo.Image = null;
                }
            }
        
        private string ObtenerDescripcionEstado(int idEstado)
        {
            try
            {
                DataSet ds = Utilidades.ejecutar("SELECT descripcion FROM Estado WHERE id_estado = " + idEstado);
                DataTable tabla = ds.Tables[0];

                if (tabla.Rows.Count > 0)
                {
                    return tabla.Rows[0]["descripcion"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró la descripción",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el estado 001 : " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }

        private void frmDetallesVehiculo_Load(object sender, EventArgs e)
        {
            btnCalculadora.Select();
        }

        private void pbVehiculo_Click(object sender, EventArgs e)
        {

        }


    }

    
}
