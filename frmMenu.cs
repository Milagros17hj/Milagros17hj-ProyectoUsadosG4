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
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin login = new frmlogin();
            login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario registroUsuario = new frmRegistroUsuario();
            registroUsuario.MdiParent = this;
            registroUsuario.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRegistroEmpleado registroEmpleado = new frmRegistroEmpleado();
            registroEmpleado.MdiParent = this;
            registroEmpleado.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCliente registroCliente = new frmRegistroCliente();
            registroCliente.MdiParent = this;
            registroCliente.Show();
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManualUsuario manualUsuario = new frmManualUsuario();
            manualUsuario.MdiParent = this;
            manualUsuario.Show();
        }

        private void catálogoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogoVehiculos catalogoVehiculos = new frmCatalogoVehiculos();
            catalogoVehiculos.MdiParent = this;
            catalogoVehiculos.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarContraseña cambiarContraseña = new frmCambiarContraseña(usuarioActual);
            cambiarContraseña.MdiParent = this;
            cambiarContraseña.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCita cita = new frmCita();
            cita.MdiParent = this;
            cita.Show();
        }
    }
}
