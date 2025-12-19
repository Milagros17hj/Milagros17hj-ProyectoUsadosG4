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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtTotalCalculo = new System.Windows.Forms.TextBox();
            this.cmbEntidadFinanciera = new System.Windows.Forms.ComboBox();
            this.txtMesesPlazo = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtPrima = new System.Windows.Forms.TextBox();
            this.txtCuotaMensual = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblMsesPlazo = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblCuotaCalculo = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrima = new System.Windows.Forms.Label();
            this.lblEntidadFinanciera = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCita = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbCalculos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbServiciosAd = new System.Windows.Forms.GroupBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.ckbGarantia = new System.Windows.Forms.CheckBox();
            this.ckbSeguro = new System.Windows.Forms.CheckBox();
            this.ckbmantenimiento = new System.Windows.Forms.CheckBox();
            this.ckbFinanciamiento = new System.Windows.Forms.CheckBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.grbCalculos.SuspendLayout();
            this.grbServiciosAd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Controls.Add(this.txtVehiculo);
            this.grpDatos.Controls.Add(this.lblPrecio);
            this.grpDatos.Controls.Add(this.lblVehiculo);
            this.grpDatos.Location = new System.Drawing.Point(12, 30);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(1080, 137);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(617, 57);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(147, 22);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(288, 59);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(215, 22);
            this.txtVehiculo.TabIndex = 11;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(530, 57);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(68, 24);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(155, 57);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(89, 24);
            this.lblVehiculo.TabIndex = 1;
            this.lblVehiculo.Text = "Vehiculo:";
            // 
            // txtTotalCalculo
            // 
            this.txtTotalCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCalculo.Location = new System.Drawing.Point(597, 169);
            this.txtTotalCalculo.Name = "txtTotalCalculo";
            this.txtTotalCalculo.ReadOnly = true;
            this.txtTotalCalculo.Size = new System.Drawing.Size(147, 27);
            this.txtTotalCalculo.TabIndex = 20;
            // 
            // cmbEntidadFinanciera
            // 
            this.cmbEntidadFinanciera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntidadFinanciera.FormattingEnabled = true;
            this.cmbEntidadFinanciera.Location = new System.Drawing.Point(223, 32);
            this.cmbEntidadFinanciera.Name = "cmbEntidadFinanciera";
            this.cmbEntidadFinanciera.Size = new System.Drawing.Size(204, 28);
            this.cmbEntidadFinanciera.TabIndex = 18;
            // 
            // txtMesesPlazo
            // 
            this.txtMesesPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesesPlazo.Location = new System.Drawing.Point(223, 117);
            this.txtMesesPlazo.Name = "txtMesesPlazo";
            this.txtMesesPlazo.Size = new System.Drawing.Size(77, 27);
            this.txtMesesPlazo.TabIndex = 17;
            // 
            // txtInteres
            // 
            this.txtInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.Location = new System.Drawing.Point(223, 72);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.ReadOnly = true;
            this.txtInteres.Size = new System.Drawing.Size(77, 27);
            this.txtInteres.TabIndex = 16;
            // 
            // txtPrima
            // 
            this.txtPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrima.Location = new System.Drawing.Point(597, 84);
            this.txtPrima.Name = "txtPrima";
            this.txtPrima.Size = new System.Drawing.Size(147, 27);
            this.txtPrima.TabIndex = 14;
            // 
            // txtCuotaMensual
            // 
            this.txtCuotaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuotaMensual.Location = new System.Drawing.Point(216, 169);
            this.txtCuotaMensual.Name = "txtCuotaMensual";
            this.txtCuotaMensual.ReadOnly = true;
            this.txtCuotaMensual.Size = new System.Drawing.Size(147, 27);
            this.txtCuotaMensual.TabIndex = 13;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpuesto.Location = new System.Drawing.Point(597, 34);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ReadOnly = true;
            this.txtImpuesto.Size = new System.Drawing.Size(147, 27);
            this.txtImpuesto.TabIndex = 12;
            // 
            // lblMsesPlazo
            // 
            this.lblMsesPlazo.AutoSize = true;
            this.lblMsesPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsesPlazo.Location = new System.Drawing.Point(24, 120);
            this.lblMsesPlazo.Name = "lblMsesPlazo";
            this.lblMsesPlazo.Size = new System.Drawing.Size(111, 20);
            this.lblMsesPlazo.TabIndex = 9;
            this.lblMsesPlazo.Text = "Meses Plazo:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.Location = new System.Drawing.Point(24, 75);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(65, 20);
            this.lblInteres.TabIndex = 8;
            this.lblInteres.Text = "Interes:";
            // 
            // lblCuotaCalculo
            // 
            this.lblCuotaCalculo.AutoSize = true;
            this.lblCuotaCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaCalculo.Location = new System.Drawing.Point(24, 167);
            this.lblCuotaCalculo.Name = "lblCuotaCalculo";
            this.lblCuotaCalculo.Size = new System.Drawing.Size(126, 20);
            this.lblCuotaCalculo.TabIndex = 7;
            this.lblCuotaCalculo.Text = "Cuota Mensual:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.Location = new System.Drawing.Point(475, 34);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(82, 20);
            this.lblImpuesto.TabIndex = 6;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(475, 176);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblPrima
            // 
            this.lblPrima.AutoSize = true;
            this.lblPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrima.Location = new System.Drawing.Point(475, 86);
            this.lblPrima.Name = "lblPrima";
            this.lblPrima.Size = new System.Drawing.Size(58, 20);
            this.lblPrima.TabIndex = 3;
            this.lblPrima.Text = "Prima:";
            // 
            // lblEntidadFinanciera
            // 
            this.lblEntidadFinanciera.AutoSize = true;
            this.lblEntidadFinanciera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidadFinanciera.Location = new System.Drawing.Point(24, 32);
            this.lblEntidadFinanciera.Name = "lblEntidadFinanciera";
            this.lblEntidadFinanciera.Size = new System.Drawing.Size(153, 20);
            this.lblEntidadFinanciera.TabIndex = 2;
            this.lblEntidadFinanciera.Text = "Entidad Financiera:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(568, 511);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(168, 77);
            this.btnConsultar.TabIndex = 20;
            this.btnConsultar.Text = "&Calcular";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCita
            // 
            this.btnCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCita.Location = new System.Drawing.Point(893, 511);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(168, 77);
            this.btnCita.TabIndex = 21;
            this.btnCita.Text = "Solicitar &Cita";
            this.btnCita.UseVisualStyleBackColor = true;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(42, 511);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(168, 77);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "&Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // grbCalculos
            // 
            this.grbCalculos.Controls.Add(this.label1);
            this.grbCalculos.Controls.Add(this.cmbEntidadFinanciera);
            this.grbCalculos.Controls.Add(this.txtInteres);
            this.grbCalculos.Controls.Add(this.lblEntidadFinanciera);
            this.grbCalculos.Controls.Add(this.lblPrima);
            this.grbCalculos.Controls.Add(this.lblInteres);
            this.grbCalculos.Controls.Add(this.txtPrima);
            this.grbCalculos.Controls.Add(this.txtTotalCalculo);
            this.grbCalculos.Controls.Add(this.txtImpuesto);
            this.grbCalculos.Controls.Add(this.lblImpuesto);
            this.grbCalculos.Controls.Add(this.lblTotal);
            this.grbCalculos.Controls.Add(this.txtMesesPlazo);
            this.grbCalculos.Controls.Add(this.lblMsesPlazo);
            this.grbCalculos.Controls.Add(this.txtCuotaMensual);
            this.grbCalculos.Controls.Add(this.lblCuotaCalculo);
            this.grbCalculos.Location = new System.Drawing.Point(14, 185);
            this.grbCalculos.Name = "grbCalculos";
            this.grbCalculos.Size = new System.Drawing.Size(758, 235);
            this.grbCalculos.TabIndex = 23;
            this.grbCalculos.TabStop = false;
            this.grbCalculos.Text = "Cálculos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 21;
            // 
            // grbServiciosAd
            // 
            this.grbServiciosAd.Controls.Add(this.lblGarantia);
            this.grbServiciosAd.Controls.Add(this.lblSeguro);
            this.grbServiciosAd.Controls.Add(this.lblMat);
            this.grbServiciosAd.Controls.Add(this.ckbGarantia);
            this.grbServiciosAd.Controls.Add(this.ckbSeguro);
            this.grbServiciosAd.Controls.Add(this.ckbmantenimiento);
            this.grbServiciosAd.Controls.Add(this.ckbFinanciamiento);
            this.grbServiciosAd.Location = new System.Drawing.Point(793, 185);
            this.grbServiciosAd.Name = "grbServiciosAd";
            this.grbServiciosAd.Size = new System.Drawing.Size(288, 235);
            this.grbServiciosAd.TabIndex = 24;
            this.grbServiciosAd.TabStop = false;
            this.grbServiciosAd.Text = "Servicios Adicionales";
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGarantia.Location = new System.Drawing.Point(193, 160);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(75, 23);
            this.lblGarantia.TabIndex = 24;
            this.lblGarantia.Text = " ₡75000";
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.Location = new System.Drawing.Point(193, 124);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(79, 23);
            this.lblSeguro.TabIndex = 23;
            this.lblSeguro.Text = " ₡55,000";
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(193, 84);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(89, 23);
            this.lblMat.TabIndex = 22;
            this.lblMat.Text = " ₡180,000";
            // 
            // ckbGarantia
            // 
            this.ckbGarantia.AutoSize = true;
            this.ckbGarantia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGarantia.Location = new System.Drawing.Point(19, 161);
            this.ckbGarantia.Name = "ckbGarantia";
            this.ckbGarantia.Size = new System.Drawing.Size(171, 24);
            this.ckbGarantia.TabIndex = 3;
            this.ckbGarantia.Text = "Garantía extendida";
            this.ckbGarantia.UseVisualStyleBackColor = true;
            // 
            // ckbSeguro
            // 
            this.ckbSeguro.AutoSize = true;
            this.ckbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSeguro.Location = new System.Drawing.Point(18, 125);
            this.ckbSeguro.Name = "ckbSeguro";
            this.ckbSeguro.Size = new System.Drawing.Size(84, 24);
            this.ckbSeguro.TabIndex = 2;
            this.ckbSeguro.Text = "Seguro";
            this.ckbSeguro.UseVisualStyleBackColor = true;
            // 
            // ckbmantenimiento
            // 
            this.ckbmantenimiento.AutoSize = true;
            this.ckbmantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbmantenimiento.Location = new System.Drawing.Point(18, 84);
            this.ckbmantenimiento.Name = "ckbmantenimiento";
            this.ckbmantenimiento.Size = new System.Drawing.Size(140, 24);
            this.ckbmantenimiento.TabIndex = 1;
            this.ckbmantenimiento.Text = "Mantenimiento";
            this.ckbmantenimiento.UseVisualStyleBackColor = true;
            // 
            // ckbFinanciamiento
            // 
            this.ckbFinanciamiento.AutoSize = true;
            this.ckbFinanciamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFinanciamiento.Location = new System.Drawing.Point(18, 45);
            this.ckbFinanciamiento.Name = "ckbFinanciamiento";
            this.ckbFinanciamiento.Size = new System.Drawing.Size(144, 24);
            this.ckbFinanciamiento.TabIndex = 0;
            this.ckbFinanciamiento.Text = "Financiamiento";
            this.ckbFinanciamiento.UseVisualStyleBackColor = true;
            this.ckbFinanciamiento.CheckedChanged += new System.EventHandler(this.ckbFinanciamiento_CheckedChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(283, 511);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 77);
            this.btnLimpiar.TabIndex = 25;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 737);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grbServiciosAd);
            this.Controls.Add(this.grbCalculos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCita);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grpDatos);
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Financiamiento";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grbCalculos.ResumeLayout(false);
            this.grbCalculos.PerformLayout();
            this.grbServiciosAd.ResumeLayout(false);
            this.grbServiciosAd.PerformLayout();
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
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtMesesPlazo;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPrima;
        private System.Windows.Forms.TextBox txtCuotaMensual;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.Label lblMsesPlazo;
        private System.Windows.Forms.ComboBox cmbEntidadFinanciera;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTotalCalculo;
        private System.Windows.Forms.GroupBox grbCalculos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbServiciosAd;
        private System.Windows.Forms.CheckBox ckbGarantia;
        private System.Windows.Forms.CheckBox ckbSeguro;
        private System.Windows.Forms.CheckBox ckbmantenimiento;
        private System.Windows.Forms.CheckBox ckbFinanciamiento;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}