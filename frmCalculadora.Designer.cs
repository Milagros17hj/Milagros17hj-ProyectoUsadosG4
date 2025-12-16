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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.chkContado = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReservarCita = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.checkedListBox1);
            this.grpDatos.Controls.Add(this.textBox8);
            this.grpDatos.Controls.Add(this.chkContado);
            this.grpDatos.Controls.Add(this.cmbTipoVehiculo);
            this.grpDatos.Controls.Add(this.textBox7);
            this.grpDatos.Controls.Add(this.textBox6);
            this.grpDatos.Controls.Add(this.textBox5);
            this.grpDatos.Controls.Add(this.textBox4);
            this.grpDatos.Controls.Add(this.textBox3);
            this.grpDatos.Controls.Add(this.textBox2);
            this.grpDatos.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(646, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(646, 291);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(147, 22);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 289);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(646, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(147, 22);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(944, 61);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(77, 22);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1036, 184);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(77, 22);
            this.textBox7.TabIndex = 17;
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(233, 184);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(204, 24);
            this.cmbTipoVehiculo.TabIndex = 18;
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
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(323, 416);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(147, 22);
            this.textBox8.TabIndex = 20;
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
            this.ClientSize = new System.Drawing.Size(1104, 746);
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMsesPlazo;
        private System.Windows.Forms.CheckBox chkContado;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnReservarCita;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}