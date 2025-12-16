using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProyectoUsadosGrupo4
{
    public partial class frmManualUsuario : Form
    {
        public frmManualUsuario()
        {
            InitializeComponent();
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            Process.Start(@"AJUSTAR CON LA RUTA DONDE TIENEN EL MANUAL");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
