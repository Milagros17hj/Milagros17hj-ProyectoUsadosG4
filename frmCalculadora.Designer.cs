namespace ProyectoUsadosGrupo4
{
    partial class frmCalculadora
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lbltipoVehiculo = new System.Windows.Forms.Label();
            this.lblEntidadFinanciera = new System.Windows.Forms.Label();
            this.lblPrima = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblCuotaCalculo = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblMsesPlazo = new System.Windows.Forms.Label();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtCuotaMensual = new System.Windows.Forms.TextBox();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtMesesPlazo = new System.Windows.Forms.TextBox();
            this.cmbEntidadFinanciera = new System.Windows.Forms.ComboBox();
            this.chkContado = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReservarCita = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTotalCalculo = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.checkedListBox1);
            this.grpDatos.Controls.Add(this.txtTotalCalculo);
            this.grpDatos.Controls.Add(this.chkContado);
            this.grpDatos.Controls.Add(this.cmbEntidadFinanciera);
            this.grpDatos.Controls.Add(this.txtMesesPlazo);
            this.grpDatos.Controls.Add(this.txtInteres);
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Controls.Add(this.txtPrima);
            this.grpDatos.Controls.Add(this.txtCuotaMensual);
            this.grpDatos.Controls.Add(this.txtImpuesto);
            this.grpDatos.Controls.Add(this.txtTipoVehiculo);
            this.grpDatos.Controls.Add(this.lblMsesPlazo);
            this.grpDatos.Controls.Add(this.lblInteres);
            this.grpDatos.Controls.Add(this.lblCuotaCalculo);
            this.grpDatos.Controls.Add(this.lblImpuesto);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.lblTotal);
            this.grpDatos.Controls.Add(this.lblPrima);
            this.grpDatos.Controls.Add(this.lblEntidadFinanciera);
            this.grpDatos.Controls.Add(this.lbltipoVehiculo);
            this.grpDatos.Location = new System.Drawing.Point(0, 0);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(1376, 533);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lbltipoVehiculo
            // 
            this.lbltipoVehiculo.AutoSize = true;
            this.lbltipoVehiculo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoVehiculo.Location = new System.Drawing.Point(53, 57);
            this.lbltipoVehiculo.Name = "lbltipoVehiculo";
            this.lbltipoVehiculo.Size = new System.Drawing.Size(132, 24);
            this.lbltipoVehiculo.TabIndex = 1;
            this.lbltipoVehiculo.Text = "Tipo Vehiculo:";
            // 
            // lblEntidadFinanciera
            // 
            this.lblEntidadFinanciera.AutoSize = true;
            this.lblEntidadFinanciera.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadFinanciera.Location = new System.Drawing.Point(53, 182);
            this.lblEntidadFinanciera.Name = "lblEntidadFinanciera";
            this.lblEntidadFinanciera.Size = new System.Drawing.Size(172, 24);
            this.lblEntidadFinanciera.TabIndex = 2;
            this.lblEntidadFinanciera.Text = "Entidad Financiera:";
            // 
            // lblPrima
            // 
            this.lblPrima.AutoSize = true;
            this.lblPrima.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrima.Location = new System.Drawing.Point(73, 289);
            this.lblPrima.Name = "lblPrima";
            this.lblPrima.Size = new System.Drawing.Size(65, 24);
            this.lblPrima.TabIndex = 3;
            this.lblPrima.Text = "Prima:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(227, 407);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 31);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(501, 57);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 24);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(482, 182);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(96, 24);
            this.lblImpuesto.TabIndex = 6;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblCuotaCalculo
            // 
            this.lblCuotaCalculo.AutoSize = true;
            this.lblCuotaCalculo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaCalculo.Location = new System.Drawing.Point(482, 289);
            this.lblCuotaCalculo.Name = "lblCuotaCalculo";
            this.lblCuotaCalculo.Size = new System.Drawing.Size(142, 24);
            this.lblCuotaCalculo.TabIndex = 7;
            this.lblCuotaCalculo.Text = "Cuota Mensual:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.Location = new System.Drawing.Point(825, 61);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(74, 24);
            this.lblInteres.TabIndex = 8;
            this.lblInteres.Text = "Interes:";
            // 
            // lblMsesPlazo
            // 
            this.lblMsesPlazo.AutoSize = true;
            this.lblMsesPlazo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsesPlazo.Location = new System.Drawing.Point(911, 182);
            this.lblMsesPlazo.Name = "lblMsesPlazo";
            this.lblMsesPlazo.Size = new System.Drawing.Size(119, 24);
            this.lblMsesPlazo.TabIndex = 9;
            this.lblMsesPlazo.Text = "Meses Plazo:";
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.Location = new System.Drawing.Point(233, 63);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.ReadOnly = true;
            this.txtTipoVehiculo.Size = new System.Drawing.Size(215, 22);
            this.txtTipoVehiculo.TabIndex = 11;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(646, 184);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(147, 22);
            this.txtImpuesto.TabIndex = 12;
            // 
            // txtCuotaMensual
            // 
            this.txtCuotaMensual.Location = new System.Drawing.Point(646, 291);
            this.txtCuotaMensual.Name = "txtCuotaMensual";
            this.txtCuotaMensual.ReadOnly = true;
            this.txtCuotaMensual.Size = new System.Drawing.Size(147, 22);
            this.txtCuotaMensual.TabIndex = 13;
            // 
            // txtPrima
            // 
            this.txtPrima.Location = new System.Drawing.Point(160, 289);
            this.txtPrima.Name = "txtPrima";
            this.txtPrima.Size = new System.Drawing.Size(147, 22);
            this.txtPrima.TabIndex = 14;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(646, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(147, 22);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(944, 61);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.Size = new System.Drawing.Size(77, 22);
            this.txtInteres.TabIndex = 16;
            // 
            // txtMesesPlazo
            // 
            this.txtMesesPlazo.Location = new System.Drawing.Point(1036, 184);
            this.txtMesesPlazo.Name = "txtMesesPlazo";
            this.txtMesesPlazo.Size = new System.Drawing.Size(77, 22);
            this.txtMesesPlazo.TabIndex = 17;
            // 
            // cmbEntidadFinanciera
            // 
            this.cmbEntidadFinanciera.FormattingEnabled = true;
            this.cmbEntidadFinanciera.Location = new System.Drawing.Point(233, 184);
            this.cmbEntidadFinanciera.Name = "cmbEntidadFinanciera";
            this.cmbEntidadFinanciera.Size = new System.Drawing.Size(204, 24);
            this.cmbEntidadFinanciera.TabIndex = 18;
            // 
            // chkContado
            // 
            this.chkContado.AutoSize = true;
            this.chkContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkContado.Location = new System.Drawing.Point(975, 299);
            this.chkContado.Name = "chkContado";
            this.chkContado.Size = new System.Drawing.Size(100, 24);
            this.chkContado.TabIndex = 19;
            this.chkContado.Text = "Contado";
            this.chkContado.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(160, 583);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(168, 77);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnReservarCita
            // 
            this.btnReservarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarCita.Location = new System.Drawing.Point(573, 583);
            this.btnReservarCita.Name = "btnReservarCita";
            this.btnReservarCita.Size = new System.Drawing.Size(168, 77);
            this.btnReservarCita.TabIndex = 21;
            this.btnReservarCita.Text = "Reservar Cita";
            this.btnReservarCita.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(915, 583);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 77);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTotalCalculo
            // 
            this.txtTotalCalculo.Location = new System.Drawing.Point(323, 416);
            this.txtTotalCalculo.Name = "txtTotalCalculo";
            this.txtTotalCalculo.ReadOnly = true;
            this.txtTotalCalculo.Size = new System.Drawing.Size(147, 22);
            this.txtTotalCalculo.TabIndex = 20;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(680, 407);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(491, 89);
            this.checkedListBox1.TabIndex = 21;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1385, 944);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReservarCita);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora de Financiamiento";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblCuotaCalculo;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrima;
        private System.Windows.Forms.Label lblEntidadFinanciera;
        private System.Windows.Forms.Label lbltipoVehiculo;
        private System.Windows.Forms.TextBox txtMesesPlazo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPrima;
        private System.Windows.Forms.TextBox txtCuotaMensual;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.Label lblMsesPlazo;
        private System.Windows.Forms.CheckBox chkContado;
        private System.Windows.Forms.ComboBox cmbEntidadFinanciera;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnReservarCita;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTotalCalculo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}