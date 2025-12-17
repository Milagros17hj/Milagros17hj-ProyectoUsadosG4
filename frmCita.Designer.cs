namespace ProyectoUsadosGrupo4
{
    partial class frmCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtIdentificación = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.grbDatosCita = new System.Windows.Forms.GroupBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.lblAgente = new System.Windows.Forms.Label();
            this.grbCitas = new System.Windows.Forms.GroupBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grbDatosCliente.SuspendLayout();
            this.grbDatosCita.SuspendLayout();
            this.grbCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.txtVehiculo);
            this.grbDatosCliente.Controls.Add(this.lblVehiculo);
            this.grbDatosCliente.Controls.Add(this.txtIdentificación);
            this.grbDatosCliente.Controls.Add(this.lblCedula);
            this.grbDatosCliente.Controls.Add(this.cmbCliente);
            this.grbDatosCliente.Controls.Add(this.lblCliente);
            this.grbDatosCliente.Controls.Add(this.txtApellido2);
            this.grbDatosCliente.Controls.Add(this.lblNombre);
            this.grbDatosCliente.Controls.Add(this.lblApellido);
            this.grbDatosCliente.Controls.Add(this.txtNombre);
            this.grbDatosCliente.Controls.Add(this.txtApellido1);
            this.grbDatosCliente.Controls.Add(this.lblApellido1);
            this.grbDatosCliente.Location = new System.Drawing.Point(52, 32);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(1006, 180);
            this.grbDatosCliente.TabIndex = 0;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos Cliente";
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiculo.Location = new System.Drawing.Point(819, 50);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(145, 27);
            this.txtVehiculo.TabIndex = 62;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(687, 55);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(78, 20);
            this.lblVehiculo.TabIndex = 61;
            this.lblVehiculo.Text = "Vehiculo:";
            // 
            // txtIdentificación
            // 
            this.txtIdentificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificación.Location = new System.Drawing.Point(495, 50);
            this.txtIdentificación.Name = "txtIdentificación";
            this.txtIdentificación.ReadOnly = true;
            this.txtIdentificación.Size = new System.Drawing.Size(145, 27);
            this.txtIdentificación.TabIndex = 60;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(363, 55);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(112, 20);
            this.lblCedula.TabIndex = 59;
            this.lblCedula.Text = "Identificación:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(150, 55);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(162, 24);
            this.cmbCliente.TabIndex = 58;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(58, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 20);
            this.lblCliente.TabIndex = 57;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(790, 98);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.ReadOnly = true;
            this.txtApellido2.Size = new System.Drawing.Size(162, 27);
            this.txtApellido2.TabIndex = 56;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 52;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(687, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(86, 20);
            this.lblApellido.TabIndex = 55;
            this.lblApellido.Text = "II Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(150, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(162, 27);
            this.txtNombre.TabIndex = 51;
            // 
            // txtApellido1
            // 
            this.txtApellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(465, 98);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(162, 27);
            this.txtApellido1.TabIndex = 54;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(363, 101);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(82, 20);
            this.lblApellido1.TabIndex = 53;
            this.lblApellido1.Text = "I Apellido:";
            // 
            // grbDatosCita
            // 
            this.grbDatosCita.Controls.Add(this.dtpHora);
            this.grbDatosCita.Controls.Add(this.dtpFecha);
            this.grbDatosCita.Controls.Add(this.cmbEstado);
            this.grbDatosCita.Controls.Add(this.lblEstado);
            this.grbDatosCita.Controls.Add(this.lblHora);
            this.grbDatosCita.Controls.Add(this.lblFecha);
            this.grbDatosCita.Controls.Add(this.cmbAgente);
            this.grbDatosCita.Controls.Add(this.lblAgente);
            this.grbDatosCita.Location = new System.Drawing.Point(52, 218);
            this.grbDatosCita.Name = "grbDatosCita";
            this.grbDatosCita.Size = new System.Drawing.Size(1006, 159);
            this.grbDatosCita.TabIndex = 1;
            this.grbDatosCita.TabStop = false;
            this.grbDatosCita.Text = "Datos Cita";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "\"HH:mm\"";
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(752, 45);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(200, 22);
            this.dtpHora.TabIndex = 66;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(440, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 65;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(150, 109);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(162, 24);
            this.cmbEstado.TabIndex = 64;
            this.cmbEstado.SelectionChangeCommitted += new System.EventHandler(this.cmbEstado_SelectionChangeCommitted);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(58, 109);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 63;
            this.lblEstado.Text = "Estado:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(674, 45);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 62;
            this.lblHora.Text = "Hora:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(363, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(60, 20);
            this.lblFecha.TabIndex = 61;
            this.lblFecha.Text = "Fecha:";
            // 
            // cmbAgente
            // 
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(150, 39);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(162, 24);
            this.cmbAgente.TabIndex = 60;
            this.cmbAgente.SelectionChangeCommitted += new System.EventHandler(this.cmbAgente_SelectionChangeCommitted);
            // 
            // lblAgente
            // 
            this.lblAgente.AutoSize = true;
            this.lblAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgente.Location = new System.Drawing.Point(58, 39);
            this.lblAgente.Name = "lblAgente";
            this.lblAgente.Size = new System.Drawing.Size(66, 20);
            this.lblAgente.TabIndex = 59;
            this.lblAgente.Text = "Agente:";
            // 
            // grbCitas
            // 
            this.grbCitas.Controls.Add(this.dgvCitas);
            this.grbCitas.Location = new System.Drawing.Point(52, 383);
            this.grbCitas.Name = "grbCitas";
            this.grbCitas.Size = new System.Drawing.Size(1006, 241);
            this.grbCitas.TabIndex = 2;
            this.grbCitas.TabStop = false;
            this.grbCitas.Text = "Datos Cita";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitas.Location = new System.Drawing.Point(27, 33);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.Size = new System.Drawing.Size(955, 189);
            this.dgvCitas.TabIndex = 3;
            this.dgvCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(933, 644);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 57);
            this.btnSalir.TabIndex = 77;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(361, 644);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 57);
            this.btnConsultar.TabIndex = 76;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(59, 644);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(125, 57);
            this.btnAgendar.TabIndex = 75;
            this.btnAgendar.Text = "&Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(204, 644);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 57);
            this.btnActualizar.TabIndex = 74;
            this.btnActualizar.Text = "Ac&tualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(790, 644);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(125, 57);
            this.btnLimpiar.TabIndex = 73;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(652, 644);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 57);
            this.btnEliminar.TabIndex = 78;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbCitas);
            this.Controls.Add(this.grbDatosCita);
            this.Controls.Add(this.grbDatosCliente);
            this.Name = "frmCita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCita";
            this.Load += new System.EventHandler(this.frmCita_Load);
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            this.grbDatosCita.ResumeLayout(false);
            this.grbDatosCita.PerformLayout();
            this.grbCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.GroupBox grbDatosCita;
        private System.Windows.Forms.GroupBox grbCitas;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtIdentificación;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.Label lblAgente;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
    }
}