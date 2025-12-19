namespace ProyectoUsadosGrupo4
{
    partial class frmReserva
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
            this.grpDatosCliente = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblIdVehiculo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.cmbEstadoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblEstadoVehiculo = new System.Windows.Forms.Label();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.lblCita = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.cmbEstadoReserva = new System.Windows.Forms.ComboBox();
            this.cmbIdCita = new System.Windows.Forms.ComboBox();
            this.grpDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.grpReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosCliente
            // 
            this.grpDatosCliente.Controls.Add(this.txtApellido);
            this.grpDatosCliente.Controls.Add(this.txtNombre);
            this.grpDatosCliente.Controls.Add(this.lblApellido);
            this.grpDatosCliente.Controls.Add(this.lblNombre);
            this.grpDatosCliente.Controls.Add(this.txtIdCliente);
            this.grpDatosCliente.Controls.Add(this.lblIdCliente);
            this.grpDatosCliente.Location = new System.Drawing.Point(0, 0);
            this.grpDatosCliente.Name = "grpDatosCliente";
            this.grpDatosCliente.Size = new System.Drawing.Size(1088, 109);
            this.grpDatosCliente.TabIndex = 0;
            this.grpDatosCliente.TabStop = false;
            this.grpDatosCliente.Text = "Datos Cliente:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(849, 42);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(176, 22);
            this.txtApellido.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(520, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(176, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(735, 40);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(86, 24);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(403, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 24);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(145, 40);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(176, 22);
            this.txtIdCliente.TabIndex = 8;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(43, 40);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(96, 24);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "Id Cliente:";
            // 
            // lblIdVehiculo
            // 
            this.lblIdVehiculo.AutoSize = true;
            this.lblIdVehiculo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVehiculo.Location = new System.Drawing.Point(31, 30);
            this.lblIdVehiculo.Name = "lblIdVehiculo";
            this.lblIdVehiculo.Size = new System.Drawing.Size(111, 24);
            this.lblIdVehiculo.TabIndex = 1;
            this.lblIdVehiculo.Text = "Id Vehiculo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(62, 614);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(182, 88);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(468, 614);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 88);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(893, 614);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(182, 88);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(6, 213);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.RowHeadersWidth = 51;
            this.dgvCitas.RowTemplate.Height = 24;
            this.dgvCitas.Size = new System.Drawing.Size(1063, 236);
            this.dgvCitas.TabIndex = 5;
            this.dgvCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCitas_CellContentClick);
            // 
            // cmbEstadoVehiculo
            // 
            this.cmbEstadoVehiculo.FormattingEnabled = true;
            this.cmbEstadoVehiculo.Location = new System.Drawing.Point(249, 100);
            this.cmbEstadoVehiculo.Name = "cmbEstadoVehiculo";
            this.cmbEstadoVehiculo.Size = new System.Drawing.Size(227, 24);
            this.cmbEstadoVehiculo.TabIndex = 6;
            // 
            // lblEstadoVehiculo
            // 
            this.lblEstadoVehiculo.AutoSize = true;
            this.lblEstadoVehiculo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoVehiculo.Location = new System.Drawing.Point(19, 98);
            this.lblEstadoVehiculo.Name = "lblEstadoVehiculo";
            this.lblEstadoVehiculo.Size = new System.Drawing.Size(182, 24);
            this.lblEstadoVehiculo.TabIndex = 7;
            this.lblEstadoVehiculo.Text = "Estado del Vehiculo:";
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.Location = new System.Drawing.Point(148, 32);
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.ReadOnly = true;
            this.txtIdVehiculo.Size = new System.Drawing.Size(173, 22);
            this.txtIdVehiculo.TabIndex = 9;
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.Location = new System.Drawing.Point(739, 32);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(48, 24);
            this.lblCita.TabIndex = 10;
            this.lblCita.Text = "Cita:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(727, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaReserva.Location = new System.Drawing.Point(527, 98);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(157, 24);
            this.lblFechaReserva.TabIndex = 12;
            this.lblFechaReserva.Text = "Fecha de Reserva";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(508, 32);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(176, 22);
            this.txtModelo.TabIndex = 18;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(384, 30);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(80, 24);
            this.lblModelo.TabIndex = 17;
            this.lblModelo.Text = "Modelo:";
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.lblEstadoReserva);
            this.grpReserva.Controls.Add(this.cmbEstadoReserva);
            this.grpReserva.Controls.Add(this.cmbIdCita);
            this.grpReserva.Controls.Add(this.lblIdVehiculo);
            this.grpReserva.Controls.Add(this.txtModelo);
            this.grpReserva.Controls.Add(this.lblCita);
            this.grpReserva.Controls.Add(this.txtIdVehiculo);
            this.grpReserva.Controls.Add(this.lblModelo);
            this.grpReserva.Controls.Add(this.dgvCitas);
            this.grpReserva.Controls.Add(this.lblEstadoVehiculo);
            this.grpReserva.Controls.Add(this.dateTimePicker1);
            this.grpReserva.Controls.Add(this.cmbEstadoVehiculo);
            this.grpReserva.Controls.Add(this.lblFechaReserva);
            this.grpReserva.Location = new System.Drawing.Point(12, 115);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(1076, 471);
            this.grpReserva.TabIndex = 19;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Reserva";
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoReserva.Location = new System.Drawing.Point(294, 157);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(170, 24);
            this.lblEstadoReserva.TabIndex = 21;
            this.lblEstadoReserva.Text = "Estado de Reserva:";
            // 
            // cmbEstadoReserva
            // 
            this.cmbEstadoReserva.FormattingEnabled = true;
            this.cmbEstadoReserva.Location = new System.Drawing.Point(524, 159);
            this.cmbEstadoReserva.Name = "cmbEstadoReserva";
            this.cmbEstadoReserva.Size = new System.Drawing.Size(227, 24);
            this.cmbEstadoReserva.TabIndex = 20;
            // 
            // cmbIdCita
            // 
            this.cmbIdCita.FormattingEnabled = true;
            this.cmbIdCita.Location = new System.Drawing.Point(825, 34);
            this.cmbIdCita.Name = "cmbIdCita";
            this.cmbIdCita.Size = new System.Drawing.Size(227, 24);
            this.cmbIdCita.TabIndex = 19;
            this.cmbIdCita.SelectedIndexChanged += new System.EventHandler(this.cmbIdCita_SelectedIndexChanged);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.ControlBox = false;
            this.Controls.Add(this.grpReserva);
            this.Controls.Add(this.grpDatosCliente);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva Cita";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.grpDatosCliente.ResumeLayout(false);
            this.grpDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCliente;
        private System.Windows.Forms.Label lblIdVehiculo;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.ComboBox cmbEstadoVehiculo;
        private System.Windows.Forms.Label lblEstadoVehiculo;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.ComboBox cmbIdCita;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.ComboBox cmbEstadoReserva;
    }
}