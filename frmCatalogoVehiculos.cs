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
    public partial class frmCatalogoVehiculos : Form
    {
        public frmCatalogoVehiculos()
        {
            InitializeComponent();
            
        }
        
        private void frmCatalogoVehiculos_Load(object sender, EventArgs e)
        {
            
            btnJac4.Tag = 10;
            btnZeerkX.Tag = 11;
            btnGeely.Tag = 12;
            btnJac1.Tag = 13;
            btnJacT8.Tag = 14;
            btnChevrolet.Tag = 15;
            btnNissan.Tag = 16;
            btnHilux.Tag = 17;
            btnAudi.Tag = 18;
            btnYaris.Tag = 19;
            btnSuzuki.Tag = 20;
            btnAccent.Tag = 21;
        }
        // BOTON SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Método para obtener los datos del vehículo por su ID
        private DatosVehiculo ObtenerVehiculoPorId(int idVehiculo)
        {
            try
            {
                DataSet ds = Utilidades.ejecutar("SELECT * FROM Vehiculo WHERE id_vehiculo = " + idVehiculo);
                DataTable tabla = ds.Tables[0];

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún vehículo con ese ID.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                DataRow fila = tabla.Rows[0];

                return new DatosVehiculo(
                    Convert.ToInt32(fila["id_vehiculo"]),
                    fila["clase"].ToString(),
                    fila["tipo_vehiculo"].ToString(),
                    fila["marca"].ToString(),
                    fila["modelo"].ToString(),
                    Convert.ToInt32(fila["año"]),
                    fila["motor"].ToString(),
                    fila["combustible"].ToString(),
                    fila["transmision"].ToString(),
                    Convert.ToInt32(fila["pasajeros"]),
                    fila["equipamiento_basico"].ToString(),
                    fila["confort"].ToString(),
                    fila["audio_video"].ToString(),
                    fila["seguridad"].ToString(),
                    fila["otros"].ToString(),
                    Convert.ToDecimal(fila["precio"]),
                    fila["imagen_path"].ToString(),
                    Convert.ToInt32(fila["id_estado"])
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar 001: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void btnJac4_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnZeerkX_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeely_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJac1_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJacT8_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChevrolet_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNissan_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHilux_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAudi_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYaris_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuzuki_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAccent_Click(object sender, EventArgs e)
        {
            try
            {
                int idVehiculo = Convert.ToInt32(((Button)sender).Tag);
                DatosVehiculo vehiculo = ObtenerVehiculoPorId(idVehiculo);

                if (vehiculo != null)
                {
                    frmDetallesVehiculo frmDetalles = new frmDetallesVehiculo(vehiculo);
                    frmDetalles.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el vehículo.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir los detalles 002: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}