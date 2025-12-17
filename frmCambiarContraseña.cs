using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaIII2025;

namespace ProyectoUsadosGrupo4
{
    public partial class frmCambiarContraseña : Form
    {
        DataSet ds;
        private DatosUsuario usuario;
        public frmCambiarContraseña(DatosUsuario usuarioLogeado)
        {
            InitializeComponent();
            usuario = usuarioLogeado;

            txtUsuario.Text = usuario.NombreUsuario;
            txtUsuario.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            cambiar();
        }

        private void cambiar()
        {
            string actual = txtContraseñaAct.Text.Trim();
            string nueva = txtContraseñaNueva.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            // VALIDAR QUE NINGÚN CAMPO ESTÉ VACÍO O SOLO ESPACIOS
            if (string.IsNullOrWhiteSpace(actual) ||string.IsNullOrWhiteSpace(nueva) ||string.IsNullOrWhiteSpace(confirmar))
            {
                MessageBox.Show("Debe completar todos los campos",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDAR QUE NUEVA Y CONFIRMAR COINCIDAN
            if (nueva != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // VALIDAR QUE LA CONTRASEÑA ACTUAL ES CORRECTA
            ds = Utilidades.ejecutar("SELECT contrasena FROM Usuario WHERE id_usuario = " + usuario.IdUsuario);

            string contrasenaBD = ds.Tables[0].Rows[0]["contrasena"].ToString();

            if (contrasenaBD != Utilidades.codificar(actual))
            {
                MessageBox.Show("La contraseña actual es incorrecta.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // CAMBIAR CONTRASEÑA
            Utilidades.ejecutar("UPDATE Usuario SET contrasena = '" + Utilidades.codificar(nueva) +
                                "' WHERE id_usuario = " + usuario.IdUsuario);

            usuario.Contrasena = Utilidades.codificar(nueva);

            MessageBox.Show("La contraseña se ha actualizado.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
