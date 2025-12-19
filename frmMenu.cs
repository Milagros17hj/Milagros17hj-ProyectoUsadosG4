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
    public partial class frmMenu : Form
    {
        private DatosUsuario usuarioActual;
        public frmMenu(DatosUsuario usuarioLogeado)
        {
            InitializeComponent();
            usuarioActual = usuarioLogeado; 
        }
        //CERRAR SESION
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }
        //SALIR
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //AGREGAR USUARIO
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario registroUsuario = new frmRegistroUsuario();
            registroUsuario.MdiParent = this;
            registroUsuario.Show();
        }
        //REGISTRO EMPLEADO
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegistroEmpleado registroEmpleado = new frmRegistroEmpleado();
            registroEmpleado.MdiParent = this;
            registroEmpleado.Show();
        }
        //REGISTRO CLIENTE
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCliente registroCliente = new frmRegistroCliente();
            registroCliente.MdiParent = this;
            registroCliente.Show();
        }
        //MANUAL DE USUARIO
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManualUsuario manualUsuario = new frmManualUsuario();
            manualUsuario.MdiParent = this;
            manualUsuario.Show();
        }
        //CATALOGO DE VEHICULOS
        private void catálogoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogoVehiculos catalogoVehiculos = new frmCatalogoVehiculos();
            catalogoVehiculos.MdiParent = this;
            catalogoVehiculos.Show();
        }
        //CAMBIAR CONTRASEÑA
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña cambiarContraseña = new frmCambiarContraseña(usuarioActual);
            cambiarContraseña.MdiParent = this;
            cambiarContraseña.Show();
        }
        // CITAS
        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCita cita = new frmCita();
            cita.MdiParent = this;
            cita.Show();
        }
        //RESERVA
        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReserva reserva = new frmReserva();
            reserva.MdiParent = this;
            reserva.Show();
        }
        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturación facturación = new frmFacturación(usuarioActual.IdUsuario);
            facturación.MdiParent = this;
            facturación.Show();
        }
        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentas reporteVentas = new frmReporteVentas();
            reporteVentas.MdiParent = this;
            reporteVentas.Show();
        }
        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ConfigurarPermisos(usuarioActual.Rol);
        }
        private void ConfigurarPermisos(string rolUsuario)
        {
            // PARA TODOS LOS ROLES (CERRAR SESIÓN, SALIR, MANUAL DE USUARIO)  
            cerrarSesionToolStripMenuItem.Enabled = true;
            salirToolStripMenuItem.Enabled = true;
            manualDeUsuarioToolStripMenuItem.Enabled = true;
            cambiarContraseñaToolStripMenuItem.Enabled = true;

            //PARA SOLO ADMINISTRADOR Y CLIENTE (CATALOGO DE VEHICULOS Y CALCULADORA )
            catálogoDeVehiculosToolStripMenuItem.Enabled = (rolUsuario == "Administrador" || rolUsuario == "Cliente");


            //SOLO ADMINISTRADOR (MANTENIMIENTO, REGISTRO EMPLEADO/CLIENTE, AGREGAR USUARIO)
            empleadosToolStripMenuItem.Enabled = (rolUsuario == "Administrador");
            clientesToolStripMenuItem.Enabled = (rolUsuario == "Administrador");
            agregarUsuarioToolStripMenuItem.Enabled = (rolUsuario == "Administrador");
            reporteDeVentasToolStripMenuItem.Enabled = (rolUsuario == "Administrador");
            //agregar los otros

            // TRANSACCIONES 
            reservasToolStripMenuItem.Enabled = (rolUsuario == "Administrador" || rolUsuario == "Recepcionista");
            citasToolStripMenuItem.Enabled = (rolUsuario == "Administrador" || rolUsuario == "Agente" || rolUsuario == "Recepcionista");
            facturaciónToolStripMenuItem.Enabled = (rolUsuario == "Administrador" || rolUsuario == "Cajera");
           
        }

        
    }
}
